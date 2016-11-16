using Home4Us_Models;
using System;
using System.Collections.Generic;

namespace Home4Us_Models_BL.BSL
{
    public class UsersService
    {
       public UsersService()
        {

        }

        public static Users GetUser(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("id");
            }

            using (var context = new RepositoryUsers())
            {
                
                 var test =  context.GetUser(id);
                return test;
            }
        }

        public static IEnumerable<Users> GetAllUsers()
        {
            return new RepositoryUsers().GetAllUser();
        } 

        public static void RemoveUsers(int id)
        {
            using (var context = new RepositoryUsers())
            {
                context.RemoveUser(id);
            }

        }

    }
}
