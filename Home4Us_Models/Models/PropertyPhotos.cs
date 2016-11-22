using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home4Us_Models.Models
{
    public class PropertyPhotos:BaseClassID
    {
        [Required]
        public string Photo { get; set; }

        public virtual ICollection<Property> Property { get; set; }
    }
}
