using GestionEtudiant.back.data.entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.back.data.dto
{
    public class UserConnectDto
    {
        private int id;
        private string fullName;
        private string roleName;

        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string RoleName { get => roleName; set => roleName = value; }

        public UserConnectDto(User user) { 
            Id = user.Id;
            FullName = user.FullName;
            RoleName=user.Role.Name;
        }
    }
}
