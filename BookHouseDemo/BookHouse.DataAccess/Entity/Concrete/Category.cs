using BookHouse.DataAccess.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHouse.DataAccess.Entity.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string CategoryName { get; set; }
        public Category Parent { get; set; }
        public List<Category> Children { get; set; }
    }
}
