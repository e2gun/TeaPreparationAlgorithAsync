using System.Diagnostics;
using TeaPreparationAlgorith;

TeaPreparationAsync teaPreparation = new();

do
{
    var stopwatch = new Stopwatch();
    stopwatch.Start();

    var cayGroup = await teaPreparation.CayiPosettenCikar().ContinueWith(async _ =>
    {
        await teaPreparation.CayiUstDemligeKoy();
        await teaPreparation.AltDemligeSuDoldur();

    });

    var ocakGroup = await teaPreparation.OcagiYak().ContinueWith(async _=>
    {
        await teaPreparation.DemliktekiSuyuKaynat();
        await teaPreparation.IsinanSuyuUstDemligeKoyupCayiDemle();
    });

    await Task.WhenAll(cayGroup, ocakGroup);

    await teaPreparation.AltDemligeTekrarSuKoyVeKisikAtesteBekle();

    Console.WriteLine(String.Format("Bitiş Süresi : {0:N}", stopwatch.Elapsed.TotalSeconds));

    stopwatch.Stop();

    Console.WriteLine("Tekrar Demlemek İstermisin (E/H)");
} while (Console.ReadKey().Key == ConsoleKey.E);

