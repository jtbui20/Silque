using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silque.AI
{
    public interface IAction
    {
        public uint ID { get; }
        public string Name { get; }
        public void DoAction();
        public void InterruptAction();
        public string State { get; }
        public int Cost { get; }
    }
}
