using System;

namespace ClaseCabinet
{
    public class Pacient
    {
        private const char separator = ';';
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string NumarTelefon { get; set; }
        public int Varsta { get; set; }
        public TipExercitiu Ex { get; set; }
        public TratamentMedicamentos Tratament { get; set; }

        public Pacient(string nume = "", string prenume = "", string numarTelefon = "", int varsta = 0, TipExercitiu Ex = TipExercitiu.Niciunul,
                TratamentMedicamentos Tratament = TratamentMedicamentos.Niciunul)
        {
            Nume = nume;
            Prenume = prenume;
            NumarTelefon = numarTelefon;
            Varsta = varsta;
            this.Ex = Ex;
            this.Tratament = Tratament;
        }

        public Pacient(string LinieFisier)
        {
            string[] DetaliiFisier = LinieFisier.Split(separator);
            Nume = DetaliiFisier[0];
            Prenume = DetaliiFisier[1];
            NumarTelefon = DetaliiFisier[2];
            Varsta = Int32.Parse(DetaliiFisier[3]);
            Ex = (TipExercitiu)Enum.Parse(typeof(TipExercitiu), DetaliiFisier[4]);
            Tratament = (TratamentMedicamentos)Enum.Parse(typeof(TratamentMedicamentos), DetaliiFisier[5]);
        }

        public string PacientToString()
        {
            return $"{Nume}{separator}{Prenume}{separator}{NumarTelefon}{separator}{Varsta}{separator}" +
                $"{Ex}{separator}{Tratament}{separator}";
        }

        public string InfoPacient()
        {
            return $"Nume: {Nume}\n" +
                $"Prenume: {Prenume}\n" +
                $"NumarTelefon: {NumarTelefon}\n" +
                $"Varsta: {Varsta}\n" +
                $"Ex: {Ex}\n" +
                $"Tratament: {Tratament}\n";
        }
    }
}
