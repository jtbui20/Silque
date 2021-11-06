using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silque.CoreMagi.Handlers
{
    public class UnityHandler : IHandler
    {
        Spell _parent;
        public delegate void UnityFunction();

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

        public UnityHandler (Spell Parent)
        {
            _parent = Parent;
        }

        /**<summary>
         * <para>Unity binding for <c>MonoBehaviour.Start()</c></para>
         * </summary> */
        public UnityFunction Start { get; set; }
        

        /**<summary>
         * <para>Unity binding for <c>MonoBehaviour.Update()</c></para>
         * </summary> */

        public UnityFunction Update { get; set; }

        /**<summary>
         * <para>Unity binding for <c>MonoBehaviour.FixedUpdate()</c></para>
         * </summary> */
        public UnityFunction FixedUpdate { get; set; }

        /**<summary>
         * <para>Unity binding for <c>MonoBehaviour.LateUpdate()</c></para>
         * </summary> */
        public UnityFunction LateUpdate { get; set; }
    }
}
