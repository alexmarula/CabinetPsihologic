using ClaseCabinet;
using System;
using System.Collections.Generic;

namespace Administrator
{
    public class AdminCabinet
    {
        protected List<Pacient> Pacienti;
        protected List<Personal> Angajati;
        public AdminCabinet()
        {
            Pacienti = new List<Pacient>();
            Angajati = new List<Personal>();
        }

        public void AddPacient(Pacient PacientNou)
        {
            if (PacientNou == null) return;
            Pacienti.Add(PacientNou);
        }
        public void AddPersonal(Personal PersonalNou)
        {
            if (PersonalNou == null) return;
            Angajati.Add(PersonalNou);
        }
        public List<Personal> GetPersonal()
        {
            return Angajati;
        }
        public List<Pacient> GetPacienti()
        {
            return Pacienti;
        }
        public string InfoPacienti()
        {
            string Info = "";
            for (int i = 0; i < Pacienti.Count; i++)
            {
                if (Pacienti[i] == null) break;
                Info += Pacienti[i].InfoPacient();
            }
            return Info;
        }

        public Pacient CautaPacient(string nume, string prenume)
        {
            foreach (var pacient in Pacienti)
            {
                if (pacient != null && pacient.Nume.Equals(nume, StringComparison.OrdinalIgnoreCase) &&
                    pacient.Prenume.Equals(prenume, StringComparison.OrdinalIgnoreCase))
                {
                    return pacient;
                }
            }
            return null;
        }
        public Personal CautaPersonal(string nume, string prenume)
        {
            foreach (Personal pers in Angajati)
            {
                if (pers != null && pers.Nume.Equals(nume, StringComparison.OrdinalIgnoreCase) &&
                    pers.Prenume.Equals(prenume, StringComparison.OrdinalIgnoreCase))
                {
                    return pers;
                }
            }
            return null;
        }
    }
}
