namespace Silque.CoreMagi.Handlers {
    public sealed class OutputHandler {
        Spell _parent;

        public OutputHandler(Spell parent)
        {
            _parent = parent;
        }

        void Compute()
        {

        }

        public float Power;
        public float Cost;

        public float Cooldown;
        public float Startup;
    }
}