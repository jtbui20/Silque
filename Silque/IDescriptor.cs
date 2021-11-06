using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silque
{
    public interface IDescriptor
    {
        internal string ShortDescription { get; }
        internal string MediumDescription { get; }   
        internal string FullDsecription { get; } 
    }
}
