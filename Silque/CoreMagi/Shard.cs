using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silque.CoreMagi
{
    public class Shard
    {
        public Spell spell;

        public Shard(Spell spell)
        {
            this.spell = spell;
        }
    }

    public class AIShard : IInstructable
    {
        public Spell spell;
        public Instructor instructor;

        public AIShard(Spell spell)
        {
            this.spell = spell;
        }
    }
}
