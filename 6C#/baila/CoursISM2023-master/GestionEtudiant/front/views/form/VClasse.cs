using GestionEtudiant.back.data.entites;
using GestionEtudiant.front.views;
using System.Windows.Forms;

namespace GestionEtudiant
{
    public partial class VClasse : Form,IFormClasseView
    {
        private bool isEdit=false;
        private bool isSuccessull = false;
        private string message;
        public VClasse()
        {
            InitializeComponent();
            ActiveEvent();
        }

        public int ClasseId { get => int.Parse(txtId.Text); set => txtId.Text = value.ToString(); }
        public Filiere FiliereSelected { get => cboFiliere.SelectedItem as Filiere; set => cboFiliere.Text=value.Name; }
        public Niveau NiveauSelected { get => cboNiveau.SelectedItem as Niveau ; set => cboNiveau.Text = value.Name; }
        public string Code { get => txtCode.Text; set => throw new NotImplementedException(); }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessFull { get =>isSuccessull; set => isSuccessull=value; }
        public string Message { get => message; set => message = value; }

        public event EventHandler clickBtnAddEvent;
        public event EventHandler clickBtnEditEvent;
        public event EventHandler clickBtnDelEvent;
        public event EventHandler SelectClasseEvent;

        private void ActiveEvent()
        {
            btnADD.Click += delegate { 
                clickBtnAddEvent.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };
            btnDEL.Click += delegate {
                clickBtnDelEvent.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };

            btnUP.Click += delegate {
               clickBtnEditEvent.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };

            dgvClasses.SelectionChanged += delegate {
                SelectClasseEvent.Invoke(this, EventArgs.Empty);
            };

        }

        public void setBindingSource(BindingSource classeList, BindingSource filiereList, BindingSource niveauList)
        {
            cboFiliere.DataSource = filiereList;
            cboFiliere.DisplayMember = "name";
            cboNiveau.DataSource = niveauList;
            cboNiveau.DisplayMember = "name";
            dgvClasses.DataSource = classeList;
        }

        private void VClasse_Load(object sender, EventArgs e)
        {
          
        }

        public void ShowForm()
        {
            Show();
        }
    }
}
