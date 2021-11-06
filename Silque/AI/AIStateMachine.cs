using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silque.AI
{
    public class AIStateMachine
    {
        public object Owner;
        public Dictionary<IState, IAction[]> States;
        public string GetState;


    }
}
