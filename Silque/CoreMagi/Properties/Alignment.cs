using System;
using System.Collections.Generic;

namespace Silque.CoreMagi.Properties
{
    public class Alignment : Property<Alignment>, IEquatable<Alignment>, IProperty
    {
        public Alignment (uint ID, string Name) : base (ID, Name)
        {

        }

        

        public bool Equals(Alignment other) => base.Equals(other);
    }
}