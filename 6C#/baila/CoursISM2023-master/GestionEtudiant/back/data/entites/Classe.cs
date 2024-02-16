using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.back.data.entites
{
    public class Classe
    {
        private int id;
        private string name;

        private Filiere filiere;
        private Niveau niveau;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public Filiere Filiere { get => filiere; set => filiere = value; }
        public Niveau Niveau { get => niveau; set => niveau = value; }

        public Classe() { }

        public Classe(int id, string name, Filiere filiere, Niveau niveau)
        {
            this.id = id;
            this.name = name;
            this.filiere = filiere;
            this.niveau = niveau;
        }

        public Classe(string name, Filiere filiere, Niveau niveau)
        {
            this.name = name;
            this.filiere = filiere;
            this.niveau = niveau;
        }
    }
}
