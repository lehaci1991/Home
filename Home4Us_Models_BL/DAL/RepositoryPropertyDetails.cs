using System.Data.Entity;
using Home4Us_Models;
using Home4Us_Models_BL.BSL;
using System;

namespace Home4Us_Models_BL.DAL
{
    public class RepositoryPropertyDetails : GenericRepository<PropertyDetails>, IDisposable
    {
        public RepositoryPropertyDetails()
            :this(new DataBaseConfiguration())
        {
        }

        public RepositoryPropertyDetails(DbContext context) : base(context)
        {
            Entity = ((DataBaseConfiguration)context).PropertyDetails;
        }

        public int CreateDetails(PropertyDetails details)
        {
            Create(details);
            Context.SaveChanges();
            return details.ID;
        }

        public void Dispose()
        {

        }
    }
}
