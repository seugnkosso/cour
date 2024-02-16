using GestionEtudiant.back.core;
using GestionEtudiant.back.data.entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.back.data.repositories
{
    public interface INiveauRepository : IRepository<Niveau>
    {
        List<Niveau> GetAll();
    }
}
