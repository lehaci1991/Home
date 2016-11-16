using Home4Us_Models.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Home4Us_Models
{
    public class PropertyAddress : BaseClassID
    {
        

        [Required]
        [StringLength(20)]
        public string City { get; set; }

        [Required]
        [StringLength(20)]
        public string Street { get; set; }

        [Required]
        [StringLength(20)]
        public string Block { get; set; }

        public int Apartment { get; set; }

        public virtual ICollection<Property> Property { get; set; }

    }
}