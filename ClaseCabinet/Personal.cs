using System;
using System.Security.Permissions;

namespace ClaseCabinet
{
    public class Personal
    {
        private const char separator = ';';
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Functie { get; set; }
        public string Email { get; set; }
        public int Salariu { get; set; }

        public Personal(string nume = "", string prenume = "", string functie = "", string email = "", int salariu = 0)
        {
            Nume = nume;
            Prenume = prenume;
            Functie = functie;
            Email = email;
            Salariu = salariu;
        }

        public Personal(string linieFisier)
        {
            string[] date = linieFisier.Split(separator);
            Nume = date[0];
            Prenume = date[1];
            Functie = date[2];
            Email = date[3];
            Salariu = int.Parse(date[4]);
        }

        public string PersonalToString()
        {
            return $"{Nume}{separator}{Prenume}{separator}{Functie}{separator}{Email}{separator}{Salariu}{separator}";
        }

        public string InlineInfoPersonal()
        {
            return $"{Nume}\t{Prenume}\t{Functie}\t{Email}\t{Salariu}\n";
        }
        public string InfoPersonal()
        {
            return $"Nume: {Nume}\n" +
                $"Prenume: {Prenume}\n" +
                $"Functie: {Functie}\n" +
                $"Email: {Email}\n" +
                $"Salariu: {Salariu}\n";
        }
    }
}
