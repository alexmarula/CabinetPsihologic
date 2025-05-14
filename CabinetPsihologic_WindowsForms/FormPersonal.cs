using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ClaseCabinet;
using Administrator;

namespace CabinetPsihologic_WindowsForms
{
    public partial class FormPersonal: Form
    {
        
        private AdminFisier Admin;
        public FormPersonal()
        {
            InitializeComponent();
            string FisierPacienti = "";
            string FisierPersonal = ConfigurationManager.AppSettings["FisierPersonal"];
            Admin = new AdminFisier(FisierPacienti, FisierPersonal);
            dataPersonal.ColumnCount = 5;
            dataPersonal.Columns[0].Name = "Nume";
            dataPersonal.Columns[1].Name = "Prenume";
            dataPersonal.Columns[2].Name = "Functie";
            dataPersonal.Columns[3].Name = "Email";
            dataPersonal.Columns[4].Name = "Salariu";
            dataPersonal.RowHeadersVisible = false;
            Admin.IncarcaPersonal();
            foreach (Personal pers in Admin.GetPersonal())
            {
                dataPersonal.Rows.Add(pers.Nume, pers.Prenume, pers.Functie, pers.Email, pers.Salariu.ToString());
            }
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Personal PersonalNou = new Personal(txtNume.Text, txtPrenume.Text, txtFunctie.Text, txtEmail.Text, int.Parse(txtSalariu.Text));
            Admin.AddPersonal(PersonalNou);
            Admin.SalvarePersonal();
            string[] row = new string[] { txtNume.Text, txtPrenume.Text, txtFunctie.Text, txtEmail.Text, txtSalariu.Text };
            dataPersonal.Rows.Add(row);
            txtNume.Text = "";
            txtPrenume.Text = "";
            txtFunctie.Text = "";
            txtEmail.Text = "";
            txtSalariu.Text = "";
            lblMesaj.Text = "Personal introdus cu succes!";
            lblMesaj.ForeColor = Color.Blue;
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNume.Text) || string.IsNullOrWhiteSpace(txtPrenume.Text))
            {
                lblMesaj.Text = "Introduceti un nume si prenume pentru cautare!";
                lblMesaj.ForeColor = Color.Red;
                return;
            }
            Personal persGasit = Admin.CautaPersonal(txtNume.Text, txtPrenume.Text);
            if(persGasit == null)
            {
                lblMesaj.Text = "Angajatul nu a fost gasit!";
                lblMesaj.ForeColor = Color.Red;
                return;
            }
            lblMesaj.Text = "Angajatul a fost gasit!\n";
            lblMesaj.Text += persGasit.InfoPersonal();
            lblMesaj.ForeColor = Color.Blue;
            txtNume.Text = ""; 
            txtPrenume.Text = "";
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            int i = 0;
            DataGridViewRow rand;
            foreach(Personal pers in Admin.GetPersonal())
            {
                if (i < dataPersonal.RowCount - 1)
                {
                    rand = dataPersonal.Rows[i];
                    pers.Nume = rand.Cells[0].Value.ToString();
                    pers.Prenume = rand.Cells[1].Value.ToString();
                    pers.Functie = rand.Cells[2].Value.ToString();
                    pers.Email = rand.Cells[3].Value.ToString();
                    pers.Salariu = int.Parse(rand.Cells[4].Value.ToString());
                    i++;
                }
            }
            Admin.SalvarePersonal();
            lblMesaj.Text = "Modificarea a fost realizata cu succes!";
            lblMesaj.ForeColor = Color.Blue;
        }
    }
}
