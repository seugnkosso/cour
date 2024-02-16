
using GestionEtudiant.back.data.entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.back.services
{
    public interface IUserService
    {
       User connexion(string login, string password);
    }
}
