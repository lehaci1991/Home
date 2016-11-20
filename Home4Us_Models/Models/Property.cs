using Home4Us_Models.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Home4Us_Models
{
    public class Property : BaseClassID
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int AddressId { get; set; }

        [Required]
        public int DetailsId { get; set; }

        [Required]

        public int StatusId { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }

        public virtual PropertyAddress PropertyAddress { get; set; }

        public virtual PropertyDetails PropertyDetails { get; set; }

        public virtual PropertyStatus PropertyStatus { get; set; }
    }
}