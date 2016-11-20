using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home4Us_Models.Models
{
    public class Rooms:BaseClassID
    {
        [Required]
        public int Bathrooms { get; set; }

        [Required]
        public int Bedrooms { get; set; }

        [Required]
        public int Livingrooms { get; set; }

        [Required]
        public int Balconys { get; set; }

        [Required]
        public int Kitchens { get; set; }

        [Required]
        public int Storage { get; set; }
    }
}
