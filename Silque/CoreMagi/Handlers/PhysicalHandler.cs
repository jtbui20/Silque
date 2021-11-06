using System.Collections.Generic;
using Silque.CoreMagi.Properties;

namespace Silque.CoreMagi.Handlers {
    public sealed class PhysicalHandler : IHandler {
        Spell _parent;

        public PhysicalHandler (Spell parent)
        {
            _parent = parent;

            Compute();
        }

        void Compute()
        {

        }
    }
}