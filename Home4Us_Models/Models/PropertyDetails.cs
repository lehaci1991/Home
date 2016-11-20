using Home4Us_Models.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Home4Us_Models
{
    public class PropertyDetails : BaseClassID
    {
       

        public int Rooms { get; set; }

        public int SpaceM2 { get; set; }

        [StringLength(500)]
        public string MoreDetails { get; set; }

        public virtual ICollection<Property> Property { get; set; }

    }
}