namespace WeatherApplication.Core.Results.Concrete
{
    public class SuccessResult:Result
    {
        public SuccessResult(bool IsSuccess):base(true)
        {

        }
        public SuccessResult(string message,bool IsSuccess):base(message,true)
        {

        }
    }
}

