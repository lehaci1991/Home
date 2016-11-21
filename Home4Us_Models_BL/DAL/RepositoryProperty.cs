using Home4Us_Models;
using Home4Us_Models_BL.BSL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home4Us_Models_BL.DAL
{
    public class RepositoryProperty : GenericRepository<Property>, IDisposable
    {
        public RepositoryProperty()
            : this(new DataBaseConfiguration())
        {
        }

        public RepositoryProperty(DbContext context) : base(context)
        {
            Entity = ((DataBaseConfiguration)context).Property;
        }

        public void CreateProperty(Property property)
        {
            Create(property);
            Context.SaveChanges();
        }

        public void Dispose()
        {
        }
    }
}
