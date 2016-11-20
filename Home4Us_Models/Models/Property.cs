using Home4Us_Models.Models;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> c9e61d4b4903094bd14f1bae4b0705a5c3059269

namespace Home4Us_Models
{
    public class Property : BaseClassID
    {
<<<<<<< HEAD
        [Required]
        public string Name { get; set; }

        [Required]
        public int AddressId { get; set; }

        [Required]
        public int DetailsId { get; set; }

        [Required]
=======

        public int AddressId { get; set; }

        public int DetailsId { get; set; }

>>>>>>> c9e61d4b4903094bd14f1bae4b0705a5c3059269
        public int StatusId { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }

        public virtual PropertyAddress PropertyAddress { get; set; }

        public virtual PropertyDetails PropertyDetails { get; set; }

        public virtual PropertyStatus PropertyStatus { get; set; }
    }
}