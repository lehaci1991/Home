using Home4Us_Models.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Home4Us_Models
{
    public class PropertyDetails : BaseClassID
    {
        [Display(Name ="Price")]
        public int Price{ get; set; }

        [Display(Name ="Rooms")]
        public Rooms RoomsId { get; set; }

        [Display(Name = "Space")]
        public int SpaceM2 { get; set; }

        [Display(Name = "More Details")]

        [StringLength(500)]
        public string MoreDetails { get; set; }

        public virtual ICollection<Property> Property { get; set; }

    }
}