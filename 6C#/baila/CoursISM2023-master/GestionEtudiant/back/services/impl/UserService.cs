
using GestionEtudiant.back.data.entites;
using GestionEtudiant.back.data.repositories;
using GestionEtudiant.back.data.repositories.impl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.back.services.impl
{
    public class UserService : IUserService
    {

        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User connexion(string login, string password)
        {
            User user = null;
            DataTable dataTable = userRepository.findUserByLogin(login);
            if (dataTable.Rows.Count != 0)
            {
                DataRow item = dataTable.Rows[0];
                user = new User()
                {
                    Id = int.Parse(item.ItemArray[0].ToString()),
                    FullName = item.ItemArray[1].ToString(),
                    Password= item.ItemArray[2].ToString(),
                    Login = item.ItemArray[3].ToString(),
                   Role=new Role()
                   {
                       Id= int.Parse(item.ItemArray[5].ToString()),
                       Name= item.ItemArray[6].ToString(),
                       Description= item.ItemArray[7].ToString()
                   }
                };
            }
            if ((user == null || password != user.Password))
            {
                return null;
            }
            else
            {
                return user;
            }

        }

     
        
    }
}
