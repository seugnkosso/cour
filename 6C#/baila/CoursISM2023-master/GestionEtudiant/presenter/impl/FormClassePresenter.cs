using GestionEtudiant.back.data.entites;
using GestionEtudiant.back.services;
using GestionEtudiant.front.views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEtudiant.presenter.impl
{
    public class FormClassePresenter:IFormClassePresenter
    {
        private IClasseService classeService;
        private IFormClasseView view;
        private BindingSource bindingSourceFiliere =new BindingSource();
        private BindingSource bindingSourceNiveau = new BindingSource();
        private BindingSource bindingSourceClasse = new BindingSource();

        public FormClassePresenter(IClasseService classeService, IFormClasseView view)
        {
            this.classeService = classeService;
            this.view = view;
            loadData();
            ActiveEventHandler();            
        }

        public void ActiveEventHandler()
        {
            view.clickBtnAddEvent += AjouterClasseHandler;
            view.clickBtnEditEvent += EditClasseHandler;
            view.SelectClasseEvent += SelectClasseHandler;
            view.clickBtnDelEvent += DeleteClasseHandler;

        }

        public void AjouterClasseHandler(object sender, EventArgs e)
        {
           
            if (view.IsEdit == false)
            {
                try
                {
                        Filiere filiere = view.FiliereSelected;
                        Niveau niveau = bindingSourceNiveau.Current as Niveau;
                        String code=view.Code;
                       string nomClasse = string.Format("{0} {1} {2}",niveau.Name,filiere.Name, code) ;
                        int id = classeService.addClasse(new Classe() {
                           Name = nomClasse,
                           Filiere = filiere,
                           Niveau = niveau              
                        });
                        view.IsSuccessFull = id!=0;
                        if (view.IsSuccessFull)
                        {
                          bindingSourceClasse.DataSource = classeService.getAllClasse();
                          view.Message = "Classe Ajoutee avec Success";
                        }                       
                }
                catch (Exception)
                {
                    view.IsSuccessFull=false;
                    view.Message = "Erreur Ajout"; 
                }
            }
            else
            {
                view.Message = "Vous etes en Mode Edit";
            }
        }

        public void DeleteClasseHandler(object sender, EventArgs e)
        {
            if (view.IsEdit == true)
            {
                try
                {
                    DialogResult confirm = MessageBox.Show("Veuillez confirmer la suppression","Confirmation Suppression!!!",MessageBoxButtons.OKCancel)  ;
                    if (confirm==DialogResult.OK)
                    {
                        view.IsSuccessFull = classeService.deleteClasse(view.ClasseId) != 0;
                        if (view.IsSuccessFull)
                        {
                            bindingSourceClasse.DataSource = classeService.getAllClasse();
                            view.Message = "Classe Supprimee avec Success";
                            view.IsEdit = false;
                        }
                    }

                }
                catch (Exception)
                {
                    view.IsSuccessFull = false;
                    view.Message = "Erreur Ajout";
                }

            }
            else
            {
                view.Message = "Vous etes en Mode Edit";
            }
        }

        public void EditClasseHandler(object sender, EventArgs e)
        {
            if (view.IsEdit == true)
            {
                try
                {
                    Filiere filiere = view.FiliereSelected;
                    Niveau niveau = bindingSourceNiveau.Current as Niveau;
                    String code = view.Code;
                    
                    string nomClasse = string.Format("{0} {1} {2}", niveau.Name, filiere.Name, code);
                    int id = classeService.updateClasse(new Classe()
                    {
                        Id= view.ClasseId,
                        Name = nomClasse,
                        Filiere = filiere,
                        Niveau = niveau

                    });
                    view.IsSuccessFull = id != 0;
                    if (view.IsSuccessFull)
                    {
                        bindingSourceClasse.DataSource = classeService.getAllClasse();
                        view.Message = "Classe Modifiee avec Success";
                        view.IsEdit= false;
                    }


                }
                catch (Exception)
                {
                    view.IsSuccessFull = false;
                    view.Message = "Erreur Ajout";
                }

            }
            else
            {
                view.Message = "Vous etes en Mode Edit";
            }
        }

        public void loadData()
        {
            bindingSourceFiliere.DataSource = classeService.getAllFiliere();
            bindingSourceNiveau.DataSource=classeService.getAllNiveau();
            bindingSourceClasse.DataSource=classeService.getAllClasse();
            view.setBindingSource(bindingSourceClasse, bindingSourceFiliere, bindingSourceNiveau);

        }

        public void SelectClasseHandler(object sender, EventArgs e)
        {
            view.IsEdit = true;
            DataRowView dataRowView = bindingSourceClasse.Current as DataRowView;
            DataRow row = dataRowView.Row;
            view.ClasseId = int.Parse(row.ItemArray[0].ToString());
            view.FiliereSelected = new Filiere()
            {
                Name= row.ItemArray[2].ToString()
            };
            view.NiveauSelected = new Niveau()
            {
                Name = row.ItemArray[3].ToString()
            };

        }
    }
}
