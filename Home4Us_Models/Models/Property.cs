using Home4Us_Models.Models;
using Home4Us_Models.Models.State;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Home4Us_Models
{
    public class Property : BaseClassID
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        public int AddressId { get; set; }

        [Required]
        public int DetailsId { get; set; }

        [Required]
        public PropertyState Status { get; set; }

        [Required]
        public int PhotosId { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }

        public virtual PropertyAddress PropertyAddress { get; set; }

        public virtual PropertyDetails PropertyDetails { get; set; }
    }
}