﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Core.Results.Concrete
{
    public class ErrorResult : Result
    {
        public ErrorResult(): base(false)
        {
        }

        public ErrorResult(string message) : base(message, false)
        {
        }
    }
}
