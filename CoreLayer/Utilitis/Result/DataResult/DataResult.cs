using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Utilitis.Result.DataResult
{
    public class DataResult<TData> : Result, IDataResult<TData>
    {

        public DataResult(bool success,TData data):base(success)
        {
            this.data = data;
        }
        public DataResult(bool success,string message, TData data) : base(success,message)
        {
            this.data = data;
        }




        public TData data { get; }
    }
}
