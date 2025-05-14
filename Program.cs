using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseCabinet;
using Administrator;
using System.Configuration;

namespace CabinetPsihologic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pacient> pacienti = new List<Pacient>();
            string fisier = ConfigurationManager.AppSettings["FisierPacienti"];
            AdminFisier admin = new AdminFisier(fisier);
            int optiune;

            do
            {
                Console.Clear();
                Console.WriteLine("--- Meniu Cabinet Psihologic ---");
                Console.WriteLine("1. Adauga pacient");
                Console.WriteLine("2. Afiseaza toti pacientii");
                Console.WriteLine("3. Cauta pacient");
                Console.WriteLine("4. Salvează pacientii în fisier");
                Console.WriteLine("5. Incarca pacientii din fisier");
                Console.WriteLine("6. Iesire");
                Console.Write("Alege o optiune: ");
                optiune = int.Parse(Console.ReadLine());

                switch (optiune)
                {
                    case 1:
                        Console.WriteLine("\nAdăugare pacient");
                        Console.Write("Nume pacient: ");
                        string nume = Console.ReadLine();
                        Console.Write("Prenume pacient: ");
                        string prenume = Console.ReadLine();
                        Console.Write("Numar telefon: ");
                        string telefon = Console.ReadLine();
                        Console.Write("Varsta: ");
                        int varsta = int.Parse(Console.ReadLine());
                        Pacient pacientNou = new Pacient(nume, prenume, telefon, varsta, exercitii.exrespirat, tratament_medicamentos.lorazepam);
                        pacienti.Add(pacientNou);
                        Console.WriteLine("Pacient adaugat cu succes!");
                        break;

                    case 2:
                        Console.WriteLine("\nLista pacientilor:");
                        foreach (var pacient in pacienti)
                        {
                            Console.WriteLine(pacient.InfoPacient());
                        }
                        break;

                    case 3:
                        Console.Write("\nIntroduceti numele pacientului cautat: ");
                        string numeCautat = Console.ReadLine();
                        Console.Write("Introduceti prenumele pacientului cautat: ");
                        string prenumeCautat = Console.ReadLine();

                        Pacient pacientGasit = pacienti.FirstOrDefault(p => p.Nume.Equals(numeCautat, StringComparison.OrdinalIgnoreCase) &&
                                                                         p.Prenume.Equals(prenumeCautat, StringComparison.OrdinalIgnoreCase));

                        if (pacientGasit != null)
                        {
                            Console.WriteLine("\nPacient gasit:\n" + pacientGasit.InfoPacient());
                        }
                        else
                        {
                            Console.WriteLine("Pacientul nu a fost gasit.");
                        }
                        break;

                    case 4:
                        SalvarePacientiFisier(pacienti);
                        Console.WriteLine("Datele pacientilor au fost salvate în fisier.");
                        break;

                    case 5:
                        pacienti = IncarcaPacientiDinFisier(fisier);
                        Console.WriteLine("Pacienții au fost încarcati din fisier.");
                        break;

                    case 6:
                        Console.WriteLine("Iesire din program...");
                        break;

                    default:
                        Console.WriteLine("Optiune invalida! Alege o optiune corecta.");
                        break;
                }

                Console.WriteLine("\nApasa orice tasta pentru a continua...");
                Console.ReadKey();

            } while (optiune != 6);
        }

        static void SalvarePacientiFisier(List<Pacient> pacienti)
        {
            string filePath = "Pacienti.txt";
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var pacient in pacienti)
                {
                    sw.WriteLine(pacient.PacientToString());
                }
            }
        }

        static List<Pacient> IncarcaPacientiDinFisier(string fisier)
        {
            List<Pacient> pacienti = new List<Pacient>();

            try
            {
                string[] linii = File.ReadAllLines(fisier);
                foreach (var linie in linii)
                {
                    Pacient pacientDinFisier = new Pacient(linie);
                    pacienti.Add(pacientDinFisier);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la citirea fisierului: " + ex.Message);
            }

            return pacienti;
        }
    }
}
