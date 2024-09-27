using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEtudiant.back.data.entites;

namespace GestionEtudiant.front.views
{
    public interface IFormClasseView : IView
    {
        string Message { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessFull { get; set; }

        //Donnees manipulees par la vue
        int ClasseId { get; set; }
        Filiere FiliereSelected { get; set; }
        Niveau NiveauSelected { get; set; }
        string Code { get; set; }
        //Events Declenches dans la Vue
        event EventHandler clickBtnAddEvent;
       
        event EventHandler clickBtnDelEvent;
        //Event de l'Edition
        event EventHandler SelectClasseEvent;
        event EventHandler clickBtnEditEvent;
        //Methodes de Chargement des donnees dans la vue
        void setBindingSource(BindingSource classeList, BindingSource filiereList, BindingSource niveauList);

      
    }
}
