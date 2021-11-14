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

        public void Detach()
        {
            throw new System.NotImplementedException();
        }

        public void GetParent()
        {
            throw new System.NotImplementedException();
        }

        void Compute()
        {

        }

        void IHandler.Compute()
        {
            throw new System.NotImplementedException();
        }
    }
}