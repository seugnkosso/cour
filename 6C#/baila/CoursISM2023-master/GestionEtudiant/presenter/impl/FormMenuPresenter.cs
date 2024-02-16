using GestionEtudiant.back.data.dto;
using GestionEtudiant.back.data.repositories;
using GestionEtudiant.back.data.repositories.impl;
using GestionEtudiant.back.services;
using GestionEtudiant.back.services.impl;
using GestionEtudiant.front.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.presenter.impl
{
    public class FormMenuPresenter : IFormMenuPresenter
    {
        private IFormMenuView view;

        public FormMenuPresenter(IFormMenuView view, UserConnectDto userConnectDto)
        {
            this.view = view;
            this.view.UserConnectDto = userConnectDto;
            view.showViewClasse += showClasseHandler;
            this.view.ShowForm();
        }

        public void showClasseHandler(object sender, EventArgs e)
        {
            IFormClasseView view = new VClasse();
            IFiliereRepository filiereRepository = new FiliereRepository();
            INiveauRepository niveauRepository = new NiveauRepository();
            IClasseRepository classeRepository = new ClasseRepository();
            IClasseService classeService=new ClasseService(classeRepository, filiereRepository, niveauRepository);
            IFormClassePresenter presenter = new FormClassePresenter(classeService,view);
            view.ShowForm();
        }


    }
}
