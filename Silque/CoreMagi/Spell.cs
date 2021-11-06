using System.Collections.Generic;
using Silque;
using Silque.CoreMagi.Handlers;
using Silque.CoreMagi.Properties;

namespace Silque.CoreMagi {
    /**<summary>
    The <c>spell</c> class is the foundation object within Silque Magic System.
    </summary>**/
    public class Spell : IDescriptor {
        internal Element _elem;
        internal List<Affinity> _affin;
        internal Alignment _align;
        internal List<SpellAttribute> _attributes;

        InfoHandler _info;
        PhysicalHandler _phs;
        OutputHandler _output;
        StateHandler _state;
        UnityHandler _uni;

        internal Spell(Element Element, List<Affinity> Affinity, Alignment Alignment, List<SpellAttribute> Attributes)
        {
            _elem = Element;
            _affin = Affinity;
            _align = Alignment;
            _attributes = Attributes;

            _phs = new (this);
            _info = new (this);
            _output = new (this);
            _state = new (this);
            _uni = new (this);
        }

        public InfoHandler Information => _info;
        public PhysicalHandler PhysicalInformation => _phs;
        public OutputHandler Output => _output;
        public StateHandler State => _state;
        public UnityHandler UnityHandler => _uni;

        // Interface compatability layer

        string IDescriptor.ShortDescription => throw new System.NotImplementedException();

        string IDescriptor.MediumDescription => throw new System.NotImplementedException();

        string IDescriptor.FullDsecription => throw new System.NotImplementedException();
    }
}
