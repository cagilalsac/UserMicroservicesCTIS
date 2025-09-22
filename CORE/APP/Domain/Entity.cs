namespace CORE.APP.Domain
{
    public abstract class Entity
    {
        //private int id;

        //public int GetId()
        //{
        //    return id;
        //}

        //public void SetId(int id)
        //{
        //    this.id = id;
        //}

        public int Id { get; set; }

        public string Guid { get; set; }
    }
}
