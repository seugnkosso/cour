using GestionEtudiant.back.core.impl;
using GestionEtudiant.back.data.entites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.back.data.repositories.impl
{
    public class UserRepository : DataBase, IUserRepository
    {
        public int add(User entity)
        {
            throw new NotImplementedException();
        }

        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable findUserByLogin(string login)
        {
            string SQL_ALL = String.Format("select u.*,r.* from users u,roles r where u.role_id=r.id and  u.login='{0}'", login) ;
            TableName = "USERCONNECT";
              DataTable dataTable = ExecuteSelect(SQL_ALL);
              return dataTable;
        }

        public User GetValue(int id)
        {
            throw new NotImplementedException();
        }

        public int update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
