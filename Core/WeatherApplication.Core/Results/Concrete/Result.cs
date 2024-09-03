﻿using System;
using WeatherApplication.Core.Results.Abstract;

namespace WeatherApplication.Core.Results.Concrete
{
    public class Result:IResult
    {
        public Result(bool IsSuccess)
        {
            IsSuccess = IsSuccess;
        }

        public Result(string message,bool IsSuccess):this(IsSuccess)
        {
            Message = message;
        }

        public string Message { get; }

        public bool IsSuccess { get; }
    }
}

