using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            Console.WriteLine(Convert.ToInt32(sonuc));

            Metot ornek = new Metot();
            ornek.EkranaYazdir(sonuc.ToString());

            int sonuc2 = ornek.ArttirTopla(ref a, ref b);
            ornek.EkranaYazdir(sonuc2.ToString());
            ornek.EkranaYazdir(Convert.ToString(a+b));

        }

        static int Topla(int x, int y)
        {
            return x + y;
        }
    }

    class Metot
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirTopla(ref int x,ref int y)
        {
            x++;
            y++;
            return x + y; 
        }
    }
}
