using GestionEtudiant.back.data.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEtudiant.front.views.form
{
    public partial class MenuForm : Form, IFormMenuView
    {
        private UserConnectDto userConnectDto;
        public MenuForm()
        {
            InitializeComponent();
            mnuClasse.Click += delegate
            {
                showViewClasse.Invoke(this, EventArgs.Empty);
            };
        }

        public UserConnectDto UserConnectDto { get => userConnectDto; set => userConnectDto=value; }

        public event EventHandler showViewClasse;

       

        public void ShowForm()
        {
            lblUserConnect.Text = userConnectDto.FullName;
            Show();
        }
    }
}
