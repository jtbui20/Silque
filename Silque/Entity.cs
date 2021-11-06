namespace Silque
{
    public class Entity
    {
        public Entity(uint ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        /** <summary>
         * The ID associated with the entity.
         * </summary> */
        public uint ID { get; set; }

        /** <summary>
         * The name associated with the entity
         * </summary> */
        public string Name { get; set; }
    }
}
