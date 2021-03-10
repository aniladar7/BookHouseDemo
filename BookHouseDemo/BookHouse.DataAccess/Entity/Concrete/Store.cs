using BookHouse.DataAccess.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHouse.DataAccess.Entity.Concrete
{
    public class Store : IEntity
    {
        public int Id { get; set; }
        public string StoreName { get; set; }
        public List<Book> Books { get; set; }
        public string Adress { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }

    }
}
