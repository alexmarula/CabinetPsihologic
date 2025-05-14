using Administrator;
using ClaseCabinet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinetPsihologic_WindowsForms
{
    public partial class FormPacient: Form
    {
        AdminFisier Admin;
        public FormPacient()
        {
            InitializeComponent();
            string FisierPacienti = ConfigurationManager.AppSettings["FisierPacienti"];
            Admin = new AdminFisier(FisierPacienti, "");
            dataPacient.ColumnCount = 6;
            dataPacient.Columns[0].Name = "Nume";
            dataPacient.Columns[1].Name = "Prenume";
            dataPacient.Columns[2].Name = "Telefon";
            dataPacient.Columns[3].Name = "Varsta";
            dataPacient.Columns[4].Name = "Exercitii";
            dataPacient.Columns[5].Name = "Tratament";
            dataPacient.RowHeadersVisible = false;

            for(int i = 0; i < 100; i++)
            {
                cboxVarsta.Items.Add(i.ToString());
            }
            Admin.IncarcaPacienti();
            foreach (Pacient pacient in Admin.GetPacienti())
            {
                dataPacient.Rows.Add(pacient.Nume, pacient.Prenume, pacient.NumarTelefon, pacient.Varsta.ToString(),
                                    pacient.Ex, pacient.Tratament);
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            TipExercitiu Exercitiu = TipExercitiu.Niciunul;
            TratamentMedicamentos Tratament = TratamentMedicamentos.Niciunul;
            CheckBox[] Exercitii = { checkBox1, checkBox2, checkBox3, checkBox4 };
            foreach(CheckBox ch in Exercitii)
            {
                if (ch.Checked)
                {
                    Exercitiu |= (TipExercitiu)Enum.Parse(typeof(TipExercitiu), ch.Text);
                    ch.Checked = false;
                }
            }

            RadioButton[] Tratamente = { radioButton1, radioButton2, radioButton3, radioButton4 };
            foreach(RadioButton rdb in Tratamente)
            {
                if (rdb.Checked) Tratament = (TratamentMedicamentos)Enum.Parse(typeof(TratamentMedicamentos), rdb.Text);
                rdb.Checked = false;
            }


            Pacient PacientNou = new Pacient(txtNume.Text, txtPrenume.Text, txtTelefon.Text, int.Parse(cboxVarsta.Text), Exercitiu, Tratament);
            
            Admin.AddPacient(PacientNou);
            Admin.SalvarePacienti();
            
            string[] row = new string[] { txtNume.Text, txtPrenume.Text, txtTelefon.Text, cboxVarsta.Text, Exercitiu.ToString(), Tratament.ToString()};
            
            dataPacient.Rows.Add(row);
            txtNume.Text = "";
            txtPrenume.Text = "";
            txtTelefon.Text = "";
            cboxVarsta.Text = "";

            lblMesaj.Text = "Pacient introdus cu succes!";
            lblMesaj.ForeColor = Color.Blue;


        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text) || string.IsNullOrWhiteSpace(txtPrenume.Text))
            {
                lblMesaj.Text = "Introduceti un nume si prenume pentru cautare!";
                lblMesaj.ForeColor = Color.Red;
                return;
            }
            Pacient persGasit = Admin.CautaPacient(txtNume.Text, txtPrenume.Text);
            if (persGasit == null)
            {
                lblMesaj.Text = "Pacientul nu a fost gasit!";
                lblMesaj.ForeColor = Color.Red;
                return;
            }
            lblMesaj.Text = "Pacientul a fost gasit!\n";
            lblMesaj.Text += persGasit.InfoPacient();
            lblMesaj.ForeColor = Color.Blue;
            txtNume.Text = "";
            txtPrenume.Text = "";
        }
    }
}
