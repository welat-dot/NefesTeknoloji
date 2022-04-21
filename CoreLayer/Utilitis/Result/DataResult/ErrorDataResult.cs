using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Utilitis.Result.DataResult
{
    public class ErrorDataResult<TData> : DataResult<TData>
    {
        public ErrorDataResult(TData data) : base(false, data)
        {
        }
        public ErrorDataResult(string message, TData data) : base(false, message, data)
        {
        }
    }
}
