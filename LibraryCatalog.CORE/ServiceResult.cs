using System;
using System.Collections.Generic;

namespace LibraryCatalog.CORE
{
    public class ServiceResult<T>
    {
        public ServiceResult(ResponseCode ResponseCode, string Error, T Result)
        {
            this.ResponseCode = ResponseCode;
            this.Error = Error;
            this.Result = Result;
        }

        public ResponseCode ResponseCode { get; set; }

        public string Error { get; set; }

        public T Result { get; set; }

        public static ServiceResult<T> ErrorResult(string error)
        {
            return new ServiceResult<T>(ResponseCode.Error, error, default(T));
        }

        public static ServiceResult<T> SuccessResult(T entity)
        {
            return new ServiceResult<T>(ResponseCode.Success, string.Empty, entity);
        }
    }
}
