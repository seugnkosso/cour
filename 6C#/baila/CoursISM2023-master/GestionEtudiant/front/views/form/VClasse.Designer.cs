namespace GestionEtudiant
{
    partial class VClasse
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtId = new TextBox();
            btnDEL = new Button();
            btnUP = new Button();
            btnADD = new Button();
            label3 = new Label();
            txtCode = new TextBox();
            label2 = new Label();
            cboFiliere = new ComboBox();
            label1 = new Label();
            cboNiveau = new ComboBox();
            groupBox2 = new GroupBox();
            dgvClasses = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnDEL);
            groupBox1.Controls.Add(btnUP);
            groupBox1.Controls.Add(btnADD);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboFiliere);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboNiveau);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1116, 187);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nouvelle Classe";
            // 
            // txtId
            // 
            txtId.Location = new Point(374, 137);
            txtId.Name = "txtId";
            txtId.Size = new Size(79, 39);
            txtId.TabIndex = 9;
            // 
            // btnDEL
            // 
            btnDEL.Location = new Point(873, 137);
            btnDEL.Name = "btnDEL";
            btnDEL.Size = new Size(112, 44);
            btnDEL.TabIndex = 8;
            btnDEL.Text = "DEL";
            btnDEL.UseVisualStyleBackColor = true;
            // 
            // btnUP
            // 
            btnUP.Location = new Point(752, 137);
            btnUP.Name = "btnUP";
            btnUP.Size = new Size(112, 44);
            btnUP.TabIndex = 7;
            btnUP.Text = "UP";
            btnUP.UseVisualStyleBackColor = true;
            // 
            // btnADD
            // 
            btnADD.Location = new Point(634, 137);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(112, 44);
            btnADD.TabIndex = 6;
            btnADD.Text = "ADD";
            btnADD.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(778, 31);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 5;
            label3.Text = "Code";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(778, 72);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(178, 39);
            txtCode.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 34);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 3;
            label2.Text = "Filiere";
            // 
            // cboFiliere
            // 
            cboFiliere.FormattingEnabled = true;
            cboFiliere.Location = new Point(372, 75);
            cboFiliere.Name = "cboFiliere";
            cboFiliere.Size = new Size(332, 40);
            cboFiliere.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 34);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 1;
            label1.Text = "Niveau";
            // 
            // cboNiveau
            // 
            cboNiveau.FormattingEnabled = true;
            cboNiveau.Location = new Point(18, 75);
            cboNiveau.Name = "cboNiveau";
            cboNiveau.Size = new Size(332, 40);
            cboNiveau.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvClasses);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(22, 227);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1116, 554);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Liste des Classes";
            // 
            // dgvClasses
            // 
            dgvClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasses.Location = new Point(38, 59);
            dgvClasses.Name = "dgvClasses";
            dgvClasses.RowHeadersWidth = 62;
            dgvClasses.Size = new Size(1046, 473);
            dgvClasses.TabIndex = 0;
            // 
            // VClasse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 822);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "VClasse";
            Text = "Form1";
            Load += VClasse_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private ComboBox cboFiliere;
        private Label label1;
        private ComboBox cboNiveau;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox txtCode;
        private Button btnDEL;
        private Button btnUP;
        private Button btnADD;
        private DataGridView dgvClasses;
        private TextBox txtId;
    }
}
