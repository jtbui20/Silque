using System;
using System.Collections.Generic;

namespace Silque.CoreMagi.Properties
{
    public class Alignment : Property<Alignment>, IEquatable<Alignment>, IProperty
    {
        public Alignment (uint ID, string Name) : base (ID, Name)
        {

        }

        public override Dictionary<string, float> Values { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Equals(Alignment other) => base.Equals(other);
    }
}