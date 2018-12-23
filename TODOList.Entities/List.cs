using System;
using System.Collections.Generic;

namespace TODOList.Entities
{
    public class List
    {
        public int Id { get; private set; }
        public int CategoryId { get; private set; }
        public string Description { get; private set; }
        public bool Bookmark { get; private set; }                                        
        public DateTime CreationDate { get; private set; }
        public DateTime ExpirationDate { get; private set; }

        public ICollection<Element> Elements {get; set;}

        public List(int categoryId, string descripcion,  bool bookmark, DateTime creationDate, 
            DateTime expirationDate)
        {
            CategoryId = categoryId;
            Description = descripcion;
            Bookmark = bookmark;
            CreationDate = creationDate;
            ExpirationDate = expirationDate;          
        }
    }
}
