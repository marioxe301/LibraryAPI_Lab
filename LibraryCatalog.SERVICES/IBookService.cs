using System;
using System.Collections.Generic;
using LibraryCatalog.CORE;
using LibraryCatalog.CORE.Models;

namespace LibraryCatalog.SERVICES
{
    public interface IBookService
    {
        ServiceResult<BookDataTransferObjet> Add(BookDataTransferObjet book);

        ServiceResult<IEnumerable<BookDataTransferObjet>> GetAll();
    }
}
