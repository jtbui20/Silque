using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silque.CoreMagi.Properties
{
    /// <summary>
    /// Defines the behaviours expected of a Property.
    /// </summary>
    
    // Property<T> does not include IProperty as it is expect that children will include IProperty.
    public interface IProperty : IValue, IDescriptor
    {
        public uint ID { get; set; }
        public string Name { get; set; }
    }
}
