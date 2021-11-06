using System.Collections.Generic;
using System.Xml;

namespace Silque.CoreMagi {
    public class SpellLibrary {
        private List<Spell> _spells;

        public SpellLibrary () {
            // read from file
            _spells = new List<Spell>();
        }

        public SpellLibrary (XmlNode XmlData)
        {
            
        }  

        // Library owns properties
        // Library only holds the character's set, not the actual set

        public void Update() {
            foreach (Spell spell in _spells) {
                spell.UnityHandler.Update();
            }
        }
    }
}