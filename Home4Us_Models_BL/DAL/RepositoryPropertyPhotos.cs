using Home4Us_Models.Models;
using System;
using System.Data.Entity;

namespace Home4Us_Models_BL.BSL
{
    public class RepositoryPropertyPhotos : GenericRepository<PropertyPhotos>, IDisposable
    {
        public RepositoryPropertyPhotos(DbContext context) : base(context)
        {
            Entity = ((DataBaseConfiguration)context).Photos;
        }

        public RepositoryPropertyPhotos()
            :this(new DataBaseConfiguration())
        {
        }

        public int CreatePhotos(PropertyPhotos photo)
        {
            Create(photo);
            Context.SaveChanges();
            return photo.ID;
        }

        public void Dispose()
        {
        }
    }
}