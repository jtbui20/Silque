using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silque.CoreMagi.Properties
{
    public delegate void RelationHandler(Spell target);

    public class Relation : Property<Relation>, IEquatable<Relation>
    {
        RelationHandler output;
        IProperty TargetA;
        IProperty TargetB;

        public Relation (uint ID, IProperty TargetA, IProperty TargetB) : base (ID, $"hi")
        {

        }

        public override Dictionary<string, float> Values { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Equals(Relation other) => ID == other.ID;
    }
}
