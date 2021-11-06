using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silque.AI
{
    public interface IState
    {
        public uint ID { get; }
        public string Name { get; }
        public int CalculateValue();
        public IAction[] ActionList { get; }
        public void Execute();
    }
}
