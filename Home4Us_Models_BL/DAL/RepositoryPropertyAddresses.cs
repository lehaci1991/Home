using Home4Us_Models_BL.BSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Home4Us_Models;

namespace Home4Us_Models_BL.DAL
{
   public class RepositoryPropertyAddresses : GenericRepository<PropertyAddress>, IDisposable
    {
        public RepositoryPropertyAddresses()
          : this(new DataBaseConfiguration())
        {

        }
        public RepositoryPropertyAddresses(DbContext context) : base(context)
        {
            Entity = ((DataBaseConfiguration)context).PropertyAddress;
        }

        public int AddAddress(PropertyAddress address)
        {
            Create(address);
            Context.SaveChanges();
            return address.ID;
        }

        public void Dispose()
        {
        }
    }
}
