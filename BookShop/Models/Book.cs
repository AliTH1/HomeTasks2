using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
    }
}
