namespace CoreLayer.Utilitis.Result.DataResult
{
    public interface IDataResult<TData> : IResult
    {
        TData data { get; }
    }
}
