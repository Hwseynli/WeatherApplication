using System;
namespace WeatherApplication.Core.Results.Concrete
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, bool issuccess) : base(data, issuccess)
        {
        }

        public SuccessDataResult(T data, string message, bool IsSuccess) : base(data, message, IsSuccess)
        {
        }
    }
}

