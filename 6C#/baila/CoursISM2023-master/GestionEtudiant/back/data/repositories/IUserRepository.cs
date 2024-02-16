using GestionEtudiant.back.core;
using GestionEtudiant.back.data.entites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.back.data.repositories
{
    public interface IUserRepository: IRepository<User>
    {
       DataTable findUserByLogin(string login);
    }
}
