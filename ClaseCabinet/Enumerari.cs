using System;

namespace ClaseCabinet
{
    [Flags]
    public enum TipExercitiu
    {
        Niciunul = 0,
        RespiratieControlata = 1,
        RelaxareProgresiva = 2,
        ImagerieDirijata = 4,
        ExersareAbilitatiSociale = 8
    }

    public enum TratamentMedicamentos
    {
        Niciunul,
        SSRI,  // ex: sertralina, fluoxetina
        Anxiolitic,  // ex: lorazepam, diazepam
        Antidepresiv,
        StabilizatorStare,
    }
}
