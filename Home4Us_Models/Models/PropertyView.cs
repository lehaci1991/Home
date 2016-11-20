using Home4Us_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home4Us.Models
{
    public class PropertyView
    {
        public Property Property { get; set; }

        public PropertyAddress Address { get; set; }

        public PropertyDetails Details{ get; set; }

    }
}
