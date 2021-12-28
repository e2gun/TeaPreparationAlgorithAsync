namespace TeaPreparationAlgorith
{
    public class TeaPreparationAsync
    {
        public async Task CayiPosettenCikar()
        {
            await Task.Delay(1000);
            Console.WriteLine("Çayı poşetten çıkar.");
        }
        public async Task CayiUstDemligeKoy()
        {
            await Task.Delay(500);
            Console.WriteLine("Çayı üst demliğe koy.");
        }
        public async Task AltDemligeSuDoldur()
        {
            await Task.Delay(1500);
            Console.WriteLine("Alt demliğe su doldur.");
        }
        public async Task OcagiYak()
        {
            await Task.Delay(500);
            Console.WriteLine("Ocağı yak.");
        }
        public async Task DemliktekiSuyuKaynat()
        {
            await Task.Delay(2000);
            Console.WriteLine("Demlikteki suyu kaynat.");
        }
        public async Task IsinanSuyuUstDemligeKoyupCayiDemle()
        {
            await Task.Delay(1500);
            Console.WriteLine("Isınan suyu üst demliğe koyup çayı demle.");
        }
        public async Task AltDemligeTekrarSuKoyVeKisikAtesteBekle()
        {
            await Task.Delay(2000);
            Console.WriteLine("Alt demliğe tekrar su koy ve kısık ateşte bekle.");
        }
    }
}
