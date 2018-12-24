using System;
using System.Collections.Generic;

namespace TODOList.Entities
{
    public class List
    {
        public int Id { get;  set; }
        public int CategoryId { get;  set; }
        public string Description { get;  set; }
        public bool Bookmark { get;  set; }                                        
        public DateTime CreationDate { get;  set; }
        public DateTime ExpirationDate { get;  set; }

        public ICollection<Element> Elements {get; set;}

        //public List(int categoryId, string descripcion,  bool bookmark, DateTime creationDate, 
        //    DateTime expirationDate)
        //{
        //    CategoryId = categoryId;
        //    Description = descripcion;
        //    Bookmark = bookmark;
        //    CreationDate = creationDate;
        //    ExpirationDate = expirationDate;          
        //}
    }
}
