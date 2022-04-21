namespace CoreLayer.Utilitis.Result
{
    public class Result : IResult
    {

        public Result(bool success)
        {
            this.success = success;
        }

        public Result(bool success,string message):this(success)
        {
            this.message = message;
        } 


        public string message { get; } = "";

        public bool success { get; } = false;
    }
}
