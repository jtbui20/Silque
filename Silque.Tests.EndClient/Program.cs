using System;
using Silque.CoreMagi;

namespace Silque.Tests.EndClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellGenerator sg = new SpellGenerator();
            sg.LoadProperties("SpellProperties.xml");
            Spell s = sg.MakeSpell(new SpellTemplate(
                "Fire", "Projectile",
                new string[] { "chaos", "anima" },
                new string[] { "large", "fast", "penetration" }));
        }
    }
}
