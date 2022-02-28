using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Pazar);

            int sicaklik = 32;

            if(sicaklik< (int)HavaDurumu.Normal){
                Console.WriteLine("It is too cold to go outside");
            }else if(sicaklik> (int)HavaDurumu.CokSicak){
                Console.WriteLine("It is too hot outside to go");
            }else if(sicaklik>= (int)HavaDurumu.Normal && sicaklik<= (int)HavaDurumu.CokSicak){
                Console.WriteLine("Let's go outside and have some fun");
            }
        }
    }

    enum Gunler{
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk =5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}
