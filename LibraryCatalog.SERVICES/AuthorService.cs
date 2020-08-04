using System;
using System.Collections.Generic;
using System.Linq;
using LibraryCatalog.CORE;
using LibraryCatalog.CORE.Models;
using LibraryCatalog.DATA.Models;

namespace LibraryCatalog.SERVICES
{
    public class AuthorService : IAuthorService
    {

        private readonly IRepository<Author> _authorRepository;

        public AuthorService(IRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public ServiceResult<AuthorDataTransferObjet> Add(AuthorDataTransferObjet author)
        {
            var authorEntity = new Author
            {
                Id = author.Id,
                age = author.age,
                name = author.name
            };
            _authorRepository.Add(authorEntity);
            _authorRepository.SaveChanges();
            author.Id = authorEntity.Id;
            return ServiceResult<AuthorDataTransferObjet>.SuccessResult(author);
        }

        public ServiceResult<IEnumerable<AuthorDataTransferObjet>> GetAll()
        {
            var authors = _authorRepository.All()
                .Select(x => new AuthorDataTransferObjet
                {
                    Id = x.Id,
                    age = x.age,
                    name = x.name
                });
            return ServiceResult<IEnumerable<AuthorDataTransferObjet>>.SuccessResult(authors);
        }
    }
}
