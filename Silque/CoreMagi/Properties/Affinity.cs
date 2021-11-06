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

        public bool Equals(Affinity other) => base.Equals(other);

    }
}