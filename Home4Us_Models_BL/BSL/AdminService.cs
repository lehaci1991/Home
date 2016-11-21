using Home4Us_Models;
using Home4Us_Models.Models;
using Home4Us_Models.Models.State;
using Home4Us_Models_BL.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home4Us_Models_BL.BSL
{
    public class AdminService
    {
        public AdminService()
        {
        }

        public static void AddProperty(string name, int address, int detail)
        {
            var property = new Property
            {
                Name = name,
                AddressId = address,
                DetailsId = detail,
                Status = PropertyState.Waiting
            };

            using(var context = new RepositoryProperty())
            {
                context.CreateProperty(property);
            }
        }

        public static int AddDetails(int price, int space, string detail, Rooms room, int propId)
        {
            var details = new PropertyDetails
            {
                Price = price,
                SpaceM2 = space,
                RoomsId = room,
                MoreDetails = detail,
                ID = propId
            };

            using (var context = new RepositoryPropertyDetails())
            {
                return context.CreateDetails(details);
            }
        }

        public static int AddAddress(string city, string street, string block,int apartment)
        {
            var address = new PropertyAddress
            {
                City = city,
                Street = street,
                Block = block,
                Apartment = apartment
            };

            using (var context = new RepositoryPropertyAddresses())
            {
                return context.AddAddress(address);
            };
        }

        //public IEnumerable<Orders> GetAllOrders()
        //{
        //    return new RepositoryOrders().Read()
        //        .Include(u => u.Users)
        //         .Include("Property")
        //         .Include("Property.PropertyStatus");
        //}

    }
}
