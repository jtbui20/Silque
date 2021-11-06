using System;
using System.Collections.Generic;
using System.Xml;

namespace Silque.CoreMagi.Properties {
    // Requires scuffed generic due to handling of return type casting
    public abstract class Property<T> : Entity, IProperty, IEquatable<Property<T>> where T : Property<T>
    {
        static List<T> group = new();
        readonly T self;

        public abstract Dictionary<string, float> Values{ get; set; }

        string IDescriptor.ShortDescription { get; }

        string IDescriptor.MediumDescription { get; }

        string IDescriptor.FullDsecription { get; }

        /** <summary>
         * Generates a property of a derived type and stores in its type list.
         * </summary> */
        public Property(uint ID, string Name) : base (ID, Name)
        {

            self = (T)this;
            AddToAll();
        }

        /** <summary>
         * Adds the property to its associated type's dictionary list
         * </summary> */
        void AddToAll()
        {
            if (group.Contains(self)) throw new ArgumentException(
                $"{typeof(T).Name} of ID: {ID} already exists as {GetByID(ID).Name}."
            );

            group.Add(self);
        }

        /// <summary>
        /// Retrieves an array of all properties of the same type
        /// </summary>
        public static T[] GetAll() => group.ToArray();

        /// <summary>
        /// Returns a property of the same type using a specified ID
        /// </summary>
        /// <param name="ID">The identifier value of the property</param>
        public static T GetByID(uint ID) => group.Find(i => i.ID == ID);

        /// <summary>
        /// Returns the first property of the same type using a specified Name
        /// </summary>
        /// <param name="Name">The name value of the property</param>
        public static T GetByName(string Name) => group.Find(i => i.Name == Name);

        /// <summary>
        /// Removes the property from the list.
        /// </summary>
        public bool DestroySelf() => group.Remove(self);

        /// <summary>
        /// Resets the entire property group.
        /// </summary>
        public static void ResetAll() => group = new();

        public bool Equals(Property<T> other) => ID == other.ID;

        public override string ToString() => Name;
    }
}