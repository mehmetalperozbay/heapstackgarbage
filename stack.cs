using System;

// Stack ile yap�lan ehliyet projesi

class ana
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ehliyet Alma Ekran�");

        Console.Write("Ad�n�z� Giriniz\nSecim :  ");

        string adinput = Console.ReadLine();

        Console.Write("Ya��n�z� Giriniz\nSe�im :  ");

        string yasinput = Console.ReadLine();

        Console.WriteLine("Ad�n�z : " + adinput + " Ya��n�z :  " + yasinput);
        int yas;
        if (int.TryParse(yasinput, out yas))
        {
            if (yas >= 18)
            {
                Console.WriteLine("Say�n " + adinput + " Ehliyet Alabilirsiniz.");

            }
            else
            {
                Console.WriteLine("Ehliyet Alamazs�n�z");
            }
        }
        else
        {
            Console.WriteLine("Ya��n�z bir int olmal�d�r. Tekrar deneyiniz.");
        }

        GC.Collect();
        GC.WaitForPendingFinalizers();


    }
}
