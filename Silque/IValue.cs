using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silque
{
    public interface IValue
    {
        public Dictionary<string, float> Values { get; }
    }
}
