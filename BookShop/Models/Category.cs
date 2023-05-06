using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    internal class Category
    {
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}
