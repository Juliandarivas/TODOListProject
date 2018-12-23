using TODOList.Enumerables;

namespace TODOList.Entities
{
    public class Element
    {
        public int Id { get; private set; }
        public int ListId { get; private set; }
        public string Description { get; private set; }
        public Priority Priority { get; private set; }
        public bool IsDone { get; private set; }

        public Element(int listId, string description, Priority priority, bool isDone)
        {
            ListId = listId;
            Description = description;
            Priority = priority;
            IsDone = isDone;
        }
    }
}