using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }=false;
        [Required]
        public string Name { get; set; }
    }
}
