using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Services.Interfaces
{
    internal interface IBook
    {
        void Create(string title);
        void Delete(string title);
        Models.Book GetByCategoryId(int id);
    }
}
