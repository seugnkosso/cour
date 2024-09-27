using GestionEtudiant.back.data.entites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.back.services
{
    public interface IClasseService
    {
        int addClasse(Classe classe);
        int updateClasse(Classe classe);
        int deleteClasse(int id);
        DataTable getAllClasse();
        List<Niveau> getAllNiveau();
        List<Filiere> getAllFiliere();
    }
}
