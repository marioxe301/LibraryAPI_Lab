using System;
using System.Linq;
using LibraryCatalog.CORE;
using LibraryCatalog.DATA.Models;

namespace LibraryCatalog.DATA.Repositories
{
    public class BookRepository : IRepository<Book>
    {

        private readonly LibraryCatalogContext context;


        public BookRepository(LibraryCatalogContext context)
        {
            this.context = context;
        }

        public Book Add(Book entity)
        {
            context.Book.Add(entity);
            return entity;
        }

        public IQueryable<Book> All()
        {
            return context.Book;
        }

        public Book GetById(long id)
        {
            return context.Book.FirstOrDefault(x => x.authorId == id);
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
