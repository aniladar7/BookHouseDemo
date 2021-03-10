using BookHouse.DataAccess.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHouse.DataAccess.Entity.Concrete
{
    public class Author:IEntity
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        [MaxLength(1000)]
        public string Biography { get; set; }
        public List<Book> Books { get; set; }
        public List<Publisher> Publishers { get; set; }
    }
}
