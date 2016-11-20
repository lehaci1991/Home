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

        public static Users GetUser(string email)
        {
            using (var context = new RepositoryUsers())
            {
                var test = context.GetUser(email);
                return test;
            }
        }

        public static void AddUser(string firstName,string lastName,string email,string password,string zipCode)
        {
            var user = new Users
            {
                FirstName = firstName,
                LastName = lastName,
                ZipCode = zipCode,
                Email = email,
                Passwrd = password,
            };
            using (var context = new RepositoryUsers())
            {
                context.CreateUser(user);
            }
        }

        public static IEnumerable<Users> GetAllUsers()
        {
            return new RepositoryUsers().GetAllUser();
        }

        public  IEnumerable<Users> GetUsers()
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
