using Home4Us_Models.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Home4Us_Models
{
    public class PropertyStatus : BaseClassID
    {
       

        [Required]
        [StringLength(20)]
        public string StardDate { get; set; }

        [Required]
        [StringLength(20)]
        public string EndDate { get; set; }

        public bool? PropertyState { get; set; }

        public virtual ICollection<Property> Property { get; set; }

    }
}