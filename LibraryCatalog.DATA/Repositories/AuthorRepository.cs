using System;
using System.Linq;
using LibraryCatalog.CORE;
using LibraryCatalog.DATA.Models;

namespace LibraryCatalog.DATA.Repositories
{
    public class AuthorRepository : IRepository<Author>
    {

        private readonly LibraryCatalogContext context;

        public AuthorRepository(LibraryCatalogContext context)
        {
            this.context = context;
        }

        public Author Add(Author entity)
        {
            context.Author.Add(entity);
            return entity;
        }

        public IQueryable<Author> All()
        {
            return context.Author;
        }

        public Author GetById(long id)
        {
            return context.Author.FirstOrDefault(x => x.Id == id);
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
