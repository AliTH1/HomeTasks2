using BookShop.Models;
using BookShop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Services.Implementations.Book
{
    internal class BookService : IBook
    {
        List<Models.Book> books = new List<Models.Book>();

        public void Create(string title)
        {
            Models.Book book = new Models.Book();
            book.Title = title;
            books.Add(book);
        }

        public void Delete(string title)
        {
            foreach (Models.Book book in books)
            {
                if (book.Title == title)
                {
                    books.Remove(book);
                }
            }
        }

        public Models.Book GetByCategoryId(int id)
        {
            return books.Find(x => x.CategoryId == id);
        }
    }
}
