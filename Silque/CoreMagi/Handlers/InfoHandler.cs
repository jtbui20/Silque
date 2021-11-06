using System.Collections.Generic;
using Silque.CoreMagi.Properties;

namespace Silque.CoreMagi.Handlers {
    /// <summary>
    /// InfoDict is a compiled resource that depicts the configuration of the spell.
    /// It serves as the access point to any properties relevant to the spell.
    /// All 
    /// </summary>
    public sealed class InfoHandler : IHandler {
        Spell parent;

        public object GetInfo (string key)
        {
            return new object();
        }

        public InfoHandler (Spell parent)
        {
            this.parent = parent;
        }

        public void Compute() { }

        public SpellState State => parent.State.Current;

        public Element Element => parent._elem;
        public List<Affinity> Affinities => parent._affin;
        public Alignment Alignment => parent._align;
        public List<SpellAttribute> Attributes => parent._attributes;
    }
}