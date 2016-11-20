using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home4Us_Models.Models
{
    public abstract class BaseClassID
    {
        [Required]
        public int ID { get; set; }
    }
}
