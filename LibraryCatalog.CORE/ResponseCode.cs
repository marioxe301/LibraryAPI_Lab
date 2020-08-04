using System;
namespace LibraryCatalog.CORE
{
    public enum ResponseCode
    {
        Success,
        Error,
        InternalServerError = 500,
        NotFound
    }
}
