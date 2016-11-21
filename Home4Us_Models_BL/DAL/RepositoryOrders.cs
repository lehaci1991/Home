using Home4Us_Models;
using Home4Us_Models_BL.BSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Home4Us_Models_BL.DAL
{
    public class RepositoryOrders : GenericRepository<Orders>
    {
        public RepositoryOrders()
            :this(new DataBaseConfiguration())
        {

        }

        public RepositoryOrders(DbContext context) : base(context)
        {
            Entity = ((DataBaseConfiguration)context).Orders;
        }
    }
}
