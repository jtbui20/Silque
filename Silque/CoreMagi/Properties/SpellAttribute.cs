using System;
using System.Collections.Generic;

namespace Silque.CoreMagi.Properties {
    public class SpellAttribute : Property<SpellAttribute>, IEquatable<SpellAttribute> {
        Alignment _align;
        Affinity _affin;
        SpellAttribute[] _pre_Req;
        SpellAttribute[] _incomp;
        float _prop_val;

        public SpellAttribute (uint ID, string Name, Alignment Alignment, Affinity Affinity)
            : base (ID, Name)
        {
            _align = Alignment;
            _affin = Affinity;
        }

        /** <summary>
         * The alignment which is associated with the attribute.
         * </summary> */
        public Alignment Alignment
        {
            get => _align;
        }

        /** <summary>
         * The affinity which is associated with the attribute.
         * </summary> */
        public Affinity Affinity
        {
            get => _affin;
        }

        /** <summary>
         * A list of required pre-requisite attributes that are required before applying this attribute.
         * </summary> */
        public SpellAttribute[] PreRequisites
        {
            get => _pre_Req;
        }

        /** <summary>
         * A list of incompatible attributes that cannot be applied whist this attribute is attached, and vice versa.
         * </summary> */
        public SpellAttribute[] Incompatabilities
        {
            get => _incomp;
        }
        public override Dictionary<string, float> Values { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Equals(SpellAttribute other) => base.Equals(other);
    }
}