using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silque.CoreMagi
{
    
    public interface IInstructable
    {

    }

    /// <summary>
    /// IInstructable provides AI supplemental functionality to allow AIs to interact and understand the requirements for each action, along with conducting them. ALL actions must be overwritten.
    /// </summary>

    public abstract class Instructor
    {
        Spell src;
        object requirements;

        public Instructor(Spell spell)
        {
            src = spell;
        }

        /// <summary>
        /// Determines whether an action is ready and valid to be conducted.
        /// </summary>
        /// <returns></returns>
        public abstract bool isPrimed();
        /// <summary>
        /// Initiates an action sequence. A spell will automatically progress through all sequences unless interrupted.
        /// </summary>
        /// <returns>Validity or completion of the action</returns>
        public abstract bool DoAction();

        /// <summary>
        /// The sum cost of an action. This will generally be affected by many attributes, e.g. dmg, heal val, distance, fall offs, etc.
        /// </summary>
        public int Priority
        {
            get;
        }
    }
}
