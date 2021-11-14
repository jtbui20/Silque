using System;
using System.Collections.Generic;
using System.Xml;

namespace Silque.CoreMagi.Properties
{
    public class Affinity : Property<Affinity>, IEquatable<Affinity>
    {
        public Affinity (uint ID, string Name) : base (ID, Name)
        {

        }

        public override Dictionary<string, float> Values { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Equals(Affinity other) => base.Equals(other);

    }
}