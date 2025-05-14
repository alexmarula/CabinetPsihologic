namespace CabinetPsihologicGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.cmbExercitii = new System.Windows.Forms.ComboBox();
            this.cmbTratament = new System.Windows.Forms.ComboBox();
            this.lstPacienti = new System.Windows.Forms.ListBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnIncarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(30, 30);
            this.txtNume.Name = "txtNume";
            this.txtNume.PlaceholderText = "Nume";
            this.txtNume.Size = new System.Drawing.Size(150, 23);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(200, 30);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.PlaceholderText = "Prenume";
            this.txtPrenume.Size = new System.Drawing.Size(150, 23);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(30, 70);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.PlaceholderText = "Telefon";
            this.txtTelefon.Size = new System.Drawing.Size(150, 23);
            // 
            // txtVarsta
            // 
            this.txtVarsta.Location = new System.Drawing.Point(200, 70);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.PlaceholderText = "Vârstă";
            this.txtVarsta.Size = new System.Drawing.Size(150, 23);
            // 
            // cmbExercitii
            // 
            this.cmbExercitii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExercitii.Location = new System.Drawing.Point(30, 110);
            this.cmbExercitii.Name = "cmbExercitii";
            this.cmbExercitii.Size = new System.Drawing.Size(150, 23);
            // 
            // cmbTratament
            // 
            this.cmbTratament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTratament.Location = new System.Drawing.Point(200, 110);
            this.cmbTratament.Name = "cmbTratament";
            this.cmbTratament.Size = new System.Drawing.Size(150, 23);
            // 
            // lstPacienti
            // 
            this.lstPacienti.FormattingEnabled = true;
            this.lstPacienti.ItemHeight = 15;
            this.lstPacienti.Location = new System.Drawing.Point(30, 200);
            this.lstPacienti.Name = "lstPacienti";
            this.lstPacienti.Size = new System.Drawing.Size(320, 154);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(30, 150);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 30);
            this.btnAdauga.Text = "Adaugă";
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(120, 150);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 30);
            this.btnCauta.Text = "Caută";
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(210, 150);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(75, 30);
            this.btnSalveaza.Text = "Salvează";
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnIncarca
            // 
            this.btnIncarca.Location = new System.Drawing.Point(300, 150);
            this.btnIncarca.Name = "btnIncarca";
            this.btnIncarca.Size = new System.Drawing.Size(75, 30);
            this.btnIncarca.Text = "Încarcă";
            this.btnIncarca.Click += new System.EventHandler(this.btnIncarca_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtVarsta);
            this.Controls.Add(this.cmbExercitii);
            this.Controls.Add(this.cmbTratament);
            this.Controls.Add(this.lstPacienti);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.btnIncarca);
            this.Name = "Form1";
            this.Text = "Cabinet Psihologic";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.ComboBox cmbExercitii;
        private System.Windows.Forms.ComboBox cmbTratament;
        private System.Windows.Forms.ListBox lstPacienti;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnIncarca;
    }
}
