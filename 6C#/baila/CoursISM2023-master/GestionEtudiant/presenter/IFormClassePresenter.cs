using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.presenter
{
    public interface IFormClassePresenter
    {
        void loadData();
        void AjouterClasseHandler(object sender,EventArgs e);
        void EditClasseHandler(object sender, EventArgs e);
        void DeleteClasseHandler(object sender, EventArgs e);

        void SelectClasseHandler(object sender, EventArgs e);
        public void ActiveEventHandler();
    }
}
