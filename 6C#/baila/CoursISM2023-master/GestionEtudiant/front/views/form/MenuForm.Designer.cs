namespace GestionEtudiant.front.views.form
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblUserConnect = new Label();
            button1 = new Button();
            mnuClasse = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUserConnect);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(mnuClasse);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 559);
            panel1.TabIndex = 0;
            // 
            // lblUserConnect
            // 
            lblUserConnect.AutoSize = true;
            lblUserConnect.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUserConnect.Location = new Point(9, 10);
            lblUserConnect.Name = "lblUserConnect";
            lblUserConnect.Size = new Size(84, 32);
            lblUserConnect.TabIndex = 7;
            lblUserConnect.Text = "label1";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 500);
            button1.Name = "button1";
            button1.Size = new Size(312, 47);
            button1.TabIndex = 6;
            button1.Text = "Deconnexion";
            button1.UseVisualStyleBackColor = true;
            // 
            // mnuClasse
            // 
            mnuClasse.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            mnuClasse.Location = new Point(9, 122);
            mnuClasse.Name = "mnuClasse";
            mnuClasse.Size = new Size(312, 47);
            mnuClasse.TabIndex = 5;
            mnuClasse.Text = "Classe";
            mnuClasse.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 559);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MenuForm";
            Text = "Menu Gestion Etudiant";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblUserConnect;
        private Button button1;
        private Button mnuClasse;
    }
}