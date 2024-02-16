using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.back.data.entites
{
    public  class User
    {
        private int id;
        private string fullName;
        private string password;
        private string login;
        private Role role;
        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Password { get => password; set => password = value; }
        public string Login { get => login; set => login = value; }
        public Role Role { get => role; set => role = value; }
    }
}
