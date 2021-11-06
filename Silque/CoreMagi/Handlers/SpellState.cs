namespace Silque.CoreMagi.Handlers {
    public enum SpellState {
        /** <summary>
         * The spell cannot be used.
         * </summary> */
        Disabled,
        /** <summary>
         * The spell is currently preparing to be used.
         * </summary> */
        Cooldown,
        /** <summary>
         * The spell is ready to be used
         * </summary> */
        Ready,
        /** <summary>
         * The spell is currently being channeled
         * </summary> */
        Casting, Active
    }
}