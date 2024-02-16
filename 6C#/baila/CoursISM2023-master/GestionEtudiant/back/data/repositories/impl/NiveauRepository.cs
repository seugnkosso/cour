using GestionEtudiant.back.data.entites;
using GestionEtudiant.back.data.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.back.data.repositories.impl
{
    public class NiveauRepository : INiveauRepository
    {
        private List<Niveau> niveauList = new List<Niveau>();

        public int add(Niveau entity)
        {
            niveauList.Add(entity);
            return 1;
        }

        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Niveau> GetAll()
        {
            add(new Niveau(1, "L1"));
            add(new Niveau()
            {
                Id = 2,
                Name = "L2"
            });

            return niveauList;

        }

        public Niveau GetValue(int id)
        {
            throw new NotImplementedException();
        }

        public int update(Niveau entity)
        {
            throw new NotImplementedException();
        }
    }
}
