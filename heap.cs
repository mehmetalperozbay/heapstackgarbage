using System;


class a
   
{
    static void Main(string[] args)
    {
        Console.Write("yasinizi giriniz :  "); 

        intdogrula yas = new intdogrula(int.Parse(Console.ReadLine()));
         
        hesaplama(yas);

        yas = null;
        
        
    }

    static void hesaplama(intdogrula gelendeger)
    {
        if (gelendeger.deger >= 18)
        {
            Console.WriteLine(gelendeger.deger + " Yaşınız İle Ehliyet Alabilirsiniz.");

        }else 
            {

            Console.WriteLine("Yaşınız 18'den kücük oldugu icin ehliyet alamazsınız.");

            }

        GC.Collect();
        GC.WaitForPendingFinalizers();

    }
}

class intdogrula
{
    public int deger;

    public intdogrula(int value)
    {
        deger = value;
    }
    ~intdogrula()
    {
        
    }
}