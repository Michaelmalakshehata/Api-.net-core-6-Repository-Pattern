using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.ResponseViewModel
{
    public class ResponseModel<T>
    {
        public ResponseModel(T data ,bool success,string message)
        {
            Data = data;
            IsSuccess = success;
            Message = message;
        }
        public T Data { set; get; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
