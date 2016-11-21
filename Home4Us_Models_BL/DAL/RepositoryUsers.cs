using Home4Us_Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Home4Us_Models_BL.BSL
{
    public class RepositoryUsers : GenericRepository<Users>, IDisposable
    {
        public RepositoryUsers()
            :this(new DataBaseConfiguration())
        {
        }

        public RepositoryUsers(DbContext context) : base(context)
        {
            Entity = ((DataBaseConfiguration)context).Users;
        }

        public Users GetUser(int id)
        {
            try
            {
                return Read(id);
            }
            catch(Exception ex)
            {
                //log error??

                throw;
            }
        }

        public Users GetUser(string name)
        {
            try
            {
                return GetAllUser().Single(x=>x.Email == name);
            }
            catch (Exception ex)
            {
                //log error??
                return null;
            }
        }

        public IList<Users> GetAllUser()
        {
            using (var context = new DataBaseConfiguration())
            {

                /**
                 * connect to db and fetch all tests
                 */

                return context.Users.ToList();
            }
        } 

        public void CreateUser(Users user)
        {
            var u = user;
            Create(user);
            Context.SaveChanges();
        }

        public  void RemoveUser(int id)
        {
            var User = GetUser(id);
            Delete(User);
            Context.SaveChanges();
        }

        public void Dispose()
        {
            
        }
    }
}
