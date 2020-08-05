using System;
using System.Collections.Generic;
using System.Linq;
using LibraryCatalog.CORE;
using LibraryCatalog.CORE.Models;
using LibraryCatalog.DATA.Models;

namespace LibraryCatalog.SERVICES
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> _bookRepository;

        public BookService(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public ServiceResult<BookDataTransferObjet> Add(BookDataTransferObjet book)
        {
            var bookEntity = new Book
            {
                name = book.name,
                authorId = book.authorId,
                postDate = book.postDate,
            };
            _bookRepository.Add(bookEntity);
            _bookRepository.SaveChanges();

            return ServiceResult<BookDataTransferObjet>.SuccessResult(book);
        }

        public ServiceResult<IEnumerable<BookDataTransferObjet>> GetAll()
        {
            var books = _bookRepository.All()
                .Select(x => new BookDataTransferObjet
                {
                    authorId = x.authorId,
                    AuthorName = x.author.name,
                    name = x.name,
                    postDate = x.postDate
                });
            return ServiceResult<IEnumerable<BookDataTransferObjet>>.SuccessResult(books);
        }
    }
}
