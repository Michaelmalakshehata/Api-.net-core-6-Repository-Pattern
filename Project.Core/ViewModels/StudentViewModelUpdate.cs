using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.ViewModels
{
    public class StudentViewModelUpdate
    {
        public int id { set; get; }
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }
        [StringLength(10, MinimumLength = 3)]
        public string ClassName { set; get; }
    }
}
