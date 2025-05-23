﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinetPsihologic_WindowsForms
{
    public partial class MeniuPrincipal: Form
    {
        public MeniuPrincipal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            FormPersonal formPersonal = new FormPersonal();
            formPersonal.Show();
        }

        private void btnPacienti_Click(object sender, EventArgs e)
        {
            FormPacient formPacient = new FormPacient();
            formPacient.Show();
        }
    }
}
