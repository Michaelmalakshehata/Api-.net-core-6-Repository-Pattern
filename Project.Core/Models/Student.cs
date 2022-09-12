using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class Student:BaseClass
    {
        
        [Required]
        public string ClassName{ set; get; }
    }
}
