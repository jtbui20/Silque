using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silque.CoreMagi
{
    /// <summary>
    /// A string oriented template for generating new Spells. SpellTemplates are the preferred method of creating a new spell.
    /// </summary>
    public struct SpellTemplate
    {
        public string Element;
        public string Alignment;
        public string[] Affinities;
        public string[] Attributes;

        public SpellTemplate(string Element, string Alignment, string[] Affinities, string[] Attributes)
        {
            this.Element = Element;
            this.Alignment = Alignment;
            this.Affinities = Affinities;
            this.Attributes = Attributes;
        }
    }
}
