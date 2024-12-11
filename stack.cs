using System;

// Stack ile yapýlan ehliyet projesi

class ana
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ehliyet Alma Ekraný");

        Console.Write("Adýnýzý Giriniz\nSecim :  ");

        string adinput = Console.ReadLine();

        Console.Write("Yaþýnýzý Giriniz\nSeçim :  ");

        string yasinput = Console.ReadLine();

        Console.WriteLine("Adýnýz : " + adinput + " Yaþýnýz :  " + yasinput);
        int yas;
        if (int.TryParse(yasinput, out yas))
        {
            if (yas >= 18)
            {
                Console.WriteLine("Sayýn " + adinput + " Ehliyet Alabilirsiniz.");

            }
            else
            {
                Console.WriteLine("Ehliyet Alamazsýnýz");
            }
        }
        else
        {
            Console.WriteLine("Yaþýnýz bir int olmalýdýr. Tekrar deneyiniz.");
        }

        GC.Collect();
        GC.WaitForPendingFinalizers();


    }
}
