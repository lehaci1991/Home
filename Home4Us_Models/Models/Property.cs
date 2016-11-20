using Home4Us_Models.Models;
using System.Collections.Generic;

namespace Home4Us_Models
{
    public class Property : BaseClassID
    {

        public int AddressId { get; set; }

        public int DetailsId { get; set; }

        public int StatusId { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }

        public virtual PropertyAddress PropertyAddress { get; set; }

        public virtual PropertyDetails PropertyDetails { get; set; }

        public virtual PropertyStatus PropertyStatus { get; set; }
    }
}