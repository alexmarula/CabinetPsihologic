using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClaseCabinet;
using Administrator;

namespace CabinetPsihologicGUI
{
    public partial class Form1 : Form
    {
        private List<Pacient> pacienti = new List<Pacient>();
        private AdminFisier admin;

        public Form1()
        {
            InitializeComponent();
            string fisier = ConfigurationManager.AppSettings["FisierPacienti"];
            admin = new AdminFisier(fisier);

            cmbExercitii.DataSource = Enum.GetValues(typeof(exercitii));
            cmbTratament.DataSource = Enum.GetValues(typeof(tratament_medicamentos));
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                Pacient p = new Pacient(
                    txtNume.Text,
                    txtPrenume.Text,
                    txtTelefon.Text,
                    int.Parse(txtVarsta.Text),
                    (exercitii)cmbExercitii.SelectedItem,
                    (tratament_medicamentos)cmbTratament.SelectedItem
                );

                pacienti.Add(p);
                AfiseazaPacienti();
                MessageBox.Show("Pacient adăugat cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text.Trim();
            string prenume = txtPrenume.Text.Trim();

            var gasit = pacienti.FirstOrDefault(p => p.Nume.Equals(nume, StringComparison.OrdinalIgnoreCase) &&
                                                      p.Prenume.Equals(prenume, StringComparison.OrdinalIgnoreCase));

            if (gasit != null)
                MessageBox.Show("Pacient găsit:\n\n" + gasit.InfoPacient());
            else
                MessageBox.Show("Pacientul nu a fost găsit.");
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            admin.SalvarePacienti(pacienti);
            MessageBox.Show("Pacienții au fost salvați în fișier.");
        }

        private void btnIncarca_Click(object sender, EventArgs e)
        {
            pacienti = admin.IncarcaPacienti();
            AfiseazaPacienti();
            MessageBox.Show("Pacienții au fost încărcați din fișier.");
        }

        private void AfiseazaPacienti()
        {
            lstPacienti.Items.Clear();
            foreach (var p in pacienti)
            {
                lstPacienti.Items.Add(p.Nume + " " + p.Prenume + " | " + p.Varsta + " ani");
            }
        }
    }
}
