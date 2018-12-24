using TODOList.Enumerables;

namespace TODOList.Entities
{
    public class Element
    {
        public int Id { get;  set; }
        public int ListId { get;  set; }
        public string Description { get;  set; }
        public Priority Priority { get;  set; }
        public bool IsDone { get;  set; }

        //public Element(int listId, string description, Priority priority, bool isDone)
        //{
        //    ListId = listId;
        //    Description = description;
        //    Priority = priority;
        //    IsDone = isDone;
        //}
    }
}