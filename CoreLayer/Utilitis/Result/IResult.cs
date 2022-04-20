namespace CoreLayer.Utilitis.Result
{
    public interface IResult
    {
        public string message { get; }
        public bool success { get; }
    }
}
