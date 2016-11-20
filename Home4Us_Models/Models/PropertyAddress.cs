using Home4Us_Models.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Home4Us_Models
{
    public class PropertyAddress : BaseClassID
    {
<<<<<<< HEAD
=======
        

>>>>>>> c9e61d4b4903094bd14f1bae4b0705a5c3059269
        [Required]
        [StringLength(20)]
        public string City { get; set; }

        [Required]
        [StringLength(20)]
        public string Street { get; set; }

        [Required]
        [StringLength(20)]
        public string Block { get; set; }

<<<<<<< HEAD
        [Required]
=======
>>>>>>> c9e61d4b4903094bd14f1bae4b0705a5c3059269
        public int Apartment { get; set; }

        public virtual ICollection<Property> Property { get; set; }

    }
}