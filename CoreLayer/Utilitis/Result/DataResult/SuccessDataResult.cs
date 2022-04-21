namespace CoreLayer.Utilitis.Result.DataResult
{
    public class SuccessDataResult<TData> : DataResult<TData>
    {
        public SuccessDataResult(TData data) : base(true, data)
        {
        }
        public SuccessDataResult(string message, TData data) : base(true,message, data)
        {
        }
    }
}
