using System.Collections.Generic;

namespace TODOList.Entities
{
    public class Category
    {
        public int Id { get; private set; }
        public string Description { get; private set; }
        public string Color { get; private set; }
        public ICollection<List> Lists { get; set; }

        public Category(string description, string color)
        {
            Description = description;
            Color = color;
        }
    }
}
