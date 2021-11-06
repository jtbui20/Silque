using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silque.CoreMagi.Handlers
{
    public class StateHandler : IHandler
    {
        Spell _parent;
        SpellState _state = SpellState.Disabled;

        public void Compute()
        {
            throw new NotImplementedException();
        }

        public void Detach()
        {
            throw new NotImplementedException();
        }

        public void GetParent()
        {
            throw new NotImplementedException();
        }

        public StateHandler(Spell Parent)
        {
            _parent = Parent;
        }

        internal void NextState()
        {
            switch (_state)
            {
                case SpellState.Disabled:
                    break;
            }
        }

        /// <summary>
        /// Returns the current state of the spell. 
        /// </summary>
        public SpellState Current => _state;
        /// <summary>
        /// Alias for StateHandler.Current.
        /// </summary>
        /// <param name="s"></param>
        public static implicit operator SpellState(StateHandler s) => s.Current;
        /**<summary>
         * <para><c>OnCast()</c> defines behaviour when the spell first enters the casting state.</para>
         * <example>Examples of tasks conducted: Graphics / UI adjustment, animation start, etc... </example>
         * <para><c>SpellState: Ready -> Casting</c></para>
         * </summary>**/
        public virtual void OnCast() { }
        /**<summary>
         * <para><c>WhileCasting()</c> defines behaviour when the spell the spell is in the casting state.
         * This should be called after <c>OnCast()</c></para>
         * <example>Examples of tasks conducted: Cast time elapsed, animation, mana drain, etc...</example>
         * <para><c>SpellState: Casting</c></para>
         * </summary>**/
        public virtual void WhileCasting() { }
        /**<summary>
         * <para><c>OnEnter()</c> defines behaviour when the spell first enters the active state.</para>
         * <example>Examples of tasks conducted: Initialize velocity, instantiate objects, etc...</example>
         * <para><c>SpellState: Casting -> Active</c></para>
         * </summary>**/
        public virtual void OnEnter() { }
        /**<summary>
         * <para><c>OnUpdate()</c> defines behaviour when the spell is in its active state.</para>
         * <example>Examples of tasks conducted: Position update, DoT trigger, instantiate objects, etc...</example>
         * <para><c>SpellState: Active</c></para>
         * </summary>**/
        public virtual void OnUpdate() { }
        /**<summary>
         * <para><c>OnCollision()</c> defines behaviour when the spell collides with another object.</para>
         * <para>NOTE: This function should only be used for spells with physical properties. Spells with absolute targetting should use <c>OnExit()</c> instead.</para>
         * <example>Examples of tasks conducted: Dissipate spell, stop spell, apply effect, etc...</example>
         * <para><c>SpellState: Active -> Contact -> Exit</c></para>
         * </summary>**/
        public virtual void OnCollision() { }
        /**<summary>
         * <para><c>OnExit()</c> defines behaviour when the spell finalizes its instance.</para>
         * <example>Examples of tasks conducted: Restart cooldown, end anim state, etc...</example>
         * <para><c>SpellState: Active -> Exit</c></para>
         * </summary>**/
        public virtual void OnExit() { }
    }
}
