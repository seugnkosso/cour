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
    public partial class LoginForm : Form,ILoginFormView
    {
        private string message;
        public LoginForm()
        {
            InitializeComponent();
            btnConnexion.Click += delegate
            {
                clickBtnAddConnexion.Invoke(this,EventArgs.Empty);
            };
        }
        public string ErrorMessage { get => message; set => message=value; }
        public string Login { get => txtLogin.Text.Trim(); set => throw new NotImplementedException(); }
        public string Password { get => txtPassword.Text.Trim(); set => throw new NotImplementedException(); }

        public event EventHandler clickBtnAddConnexion;

        public void HideForm()
        {
            Hide();
        }
    }
}
