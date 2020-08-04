using System;
using System.Collections.Generic;
using LibraryCatalog.CORE;
using LibraryCatalog.CORE.Models;

namespace LibraryCatalog.SERVICES
{
    public interface IAuthorService
    {
        ServiceResult<AuthorDataTransferObjet> Add(AuthorDataTransferObjet author);

        ServiceResult<IEnumerable<AuthorDataTransferObjet>> GetAll();
    }
}
