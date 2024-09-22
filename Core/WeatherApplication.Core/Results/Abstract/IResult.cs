﻿using System;
namespace WeatherApplication.Core.Results.Abstract
{
    public interface IResult
    {
        string Message { get; }
        bool IsSuccess { get; }
    }
}

