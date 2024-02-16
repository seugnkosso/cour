using GestionEtudiant.back.data.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.front.views
{
    public interface IFormMenuView:IView
    {
        event EventHandler showViewClasse;
        UserConnectDto UserConnectDto { get; set; }
        
    }
}
