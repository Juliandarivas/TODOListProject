using System.Collections.Generic;

namespace TODOList.Entities
{
    public class Category
    {
        public int Id { get;  set; }
        public string Description { get;  set; }
        public string Color { get;  set; }
        public ICollection<List> Lists { get; set; }

        //public Category(string description, string color)
        //{
        //    Description = description;
        //    Color = color;
        //}
    }
}
