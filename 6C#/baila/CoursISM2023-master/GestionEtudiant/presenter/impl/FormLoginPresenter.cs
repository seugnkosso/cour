using GestionEtudiant.back.data.dto;
using GestionEtudiant.back.data.entites;
using GestionEtudiant.back.services;
using GestionEtudiant.front.views;
using GestionEtudiant.front.views.form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.presenter.impl
{
    public class FormLoginPresenter : IFormLoginPresenter
    {
        private ILoginFormView view;
        private IUserService userService;

        public FormLoginPresenter(ILoginFormView view, IUserService userService)
        {
            this.view = view;
            this.userService = userService;
            view.clickBtnAddConnexion += connexionHandler;
        }

        public void connexionHandler(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(view.Login) && !String.IsNullOrEmpty(view.Password))
            {
                User userConnect = userService.connexion(view.Login, view.Password);
                if (userConnect != null)
                {

                    IFormMenuView menuView = new MenuForm() ;
                    IFormMenuPresenter presenter = new FormMenuPresenter(menuView, new UserConnectDto(userConnect));
                    view.HideForm();
                }
                else
                {
                    view.ErrorMessage = "Login ou Mot de Passe Incorrect";
                }

            } else
            {
                view.ErrorMessage = "Login ou Mot de passe vide";
            }
        }
    }
}
