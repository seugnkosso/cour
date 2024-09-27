using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.back.data.entites
{
    public class Role
    {
        private  int id;
        private string name;
        private string description;

        public string Description { get => description; set => description = value; }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
       
    }
}
