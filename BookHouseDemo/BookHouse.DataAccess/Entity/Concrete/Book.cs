using BookHouse.DataAccess.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHouse.DataAccess.Entity.Concrete
{
    public class Book:IEntity
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public string BookName { get; set; }
        public string Summary { get; set; }
        public decimal UnitPrice { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public List<Store> Stores { get; set; }
    }
}
