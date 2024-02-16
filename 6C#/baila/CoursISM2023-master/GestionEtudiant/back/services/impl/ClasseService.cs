using GestionEtudiant.back.data.entites;
using GestionEtudiant.back.data.repositories;
using GestionEtudiant.back.services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.back.services.impl
{
    public class ClasseService : IClasseService
    {
        private IClasseRepository classeRepository;
        private IFiliereRepository filiereRepository;
        private INiveauRepository niveauRepository;

        public ClasseService(IClasseRepository classeRepository, IFiliereRepository filiereRepository, INiveauRepository niveauRepository)
        {
            this.classeRepository = classeRepository;
            this.filiereRepository = filiereRepository;
            this.niveauRepository = niveauRepository;
        }

        public int addClasse(Classe classe)
        {
            return classeRepository.add(classe);
        }

        public int deleteClasse(int id)
        {
           return classeRepository.delete(id);
        }

        public DataTable getAllClasse()
        {
           return classeRepository.GetAll();
        }

        public List<Filiere> getAllFiliere()
        {
           DataTable dataTable= filiereRepository.GetAll();
            List < Filiere > filieres = new List<Filiere >();
            foreach (DataRow item in dataTable.Rows)
            {
                Filiere filiere = new Filiere()
                {
                    Id = int.Parse(item.ItemArray[0].ToString()),
                    Name= item.ItemArray[1].ToString()
                };
                filieres.Add(filiere);
            }
               return  filieres;
        }

        public List<Niveau> getAllNiveau()
        {
            return niveauRepository.GetAll();
        }

        public int updateClasse(Classe classe)
        {
            return classeRepository.update(classe);
        }
    }
}
