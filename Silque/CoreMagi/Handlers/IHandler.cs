using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silque.CoreMagi.Handlers
{
    public interface IHandler
    {
        public void Compute();
        public void Detach();
        public void GetParent();
    }
}
