using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Veda_bookStore.Data;
using Veda_bookStore.Models;

namespace Veda_bookStore.Repository
{
    public class BookRepository
    {
        private readonly BookStoreContext _context = null;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }

      
        public  int AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Author = model.Author,
                CreatedOn = DateTime.UtcNow,
                Description = model.Description,
                Title = model.Title,
                TotalPages = model.TotalPages.HasValue ? model.TotalPages.Value : 0,
                UpdatedOn = DateTime.UtcNow,
            };

             _context.Books.AddAsync(newBook);
             _context.SaveChangesAsync();

            return newBook.Id;

        }

        public BookModel GetBookById(int id)
        {
            return null;
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return null;
        }

    }
}
