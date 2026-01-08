using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yale.Helper
{
    public class BaseResult
    {
        public SystemEnums.Result Status { get; set; }=SystemEnums.Result.Success;

        public string Msg { get; set; }=string.Empty;
    }

    public class BaseResult<T>: BaseResult
    {
        public List<T> Data { get; set; }
    }
}
