using Home4Us_Models.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Home4Us_Models
{
    public class PropertyDetails : BaseClassID
    {
<<<<<<< HEAD
        [Display(Name ="Price")]
        public int Price{ get; set; }

        [Display(Name ="Rooms")]
        public Rooms RoomsId { get; set; }

        [Display(Name = "Space")]
        public int SpaceM2 { get; set; }

        [Display(Name = "More Details")]
=======
       

        public int Rooms { get; set; }

        public int SpaceM2 { get; set; }

>>>>>>> c9e61d4b4903094bd14f1bae4b0705a5c3059269
        [StringLength(500)]
        public string MoreDetails { get; set; }

        public virtual ICollection<Property> Property { get; set; }

    }
}