using System;
using System.Collections.Generic;
using System.IO;
using ClaseCabinet;

namespace Administrator
{
    public class AdminFisier : AdminCabinet
    {
        private string FisierPacienti;
        private string FisierPersonal;

        public AdminFisier(string fisierPacienti = "", string fisierPersonal = "") : base()
        {
            this.FisierPacienti = fisierPacienti;
            this.FisierPersonal = fisierPersonal;
            if(!string.IsNullOrWhiteSpace(FisierPacienti) && !File.Exists(FisierPacienti)) File.Create(FisierPacienti).Close();
            if(!string.IsNullOrWhiteSpace(FisierPersonal) && !File.Exists(FisierPersonal)) File.Create(FisierPersonal).Close();
        }

        public void SalvarePacienti()
        {
            if (FisierPacienti == "") return;
            using (StreamWriter sw = new StreamWriter(FisierPacienti, false))
            {
                foreach (Pacient pacient in Pacienti)
                {
                    sw.WriteLine(pacient.PacientToString());
                }
            }
        }
        public void SalvarePersonal()
        {
            if (FisierPersonal == "") return;
            using (StreamWriter sw = new StreamWriter(FisierPersonal, false))
            {
                foreach (Personal pers in Angajati)
                {
                    sw.WriteLine(pers.PersonalToString());
                }
            }
        }

        public void IncarcaPacienti()
        {
            if (FisierPacienti == "") return;
            try
            {
                string[] linii = File.ReadAllLines(FisierPacienti);;
                foreach (var linie in linii)
                {
                    Pacient pacient = new Pacient(linie);
                    Pacienti.Add(pacient);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la citirea fișierului: " + ex.Message);
            }
        }
        public void IncarcaPersonal()
        {
            if (FisierPersonal == "") return;
            try
            {
                string[] linii = File.ReadAllLines(FisierPersonal); ;
                foreach (var linie in linii)
                {
                    Personal pers = new Personal(linie);
                    Angajati.Add(pers);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la citirea fișierului: " + ex.Message);
            }
        }
    }
}
