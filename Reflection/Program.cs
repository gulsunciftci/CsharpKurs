using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reflection ile çalışma anında herhangi bir nesne hakkında bilgi toplayabilir ve topladığınız bilgiye göre metodu çalıştırabilirsiniz
            //Reflection nesneler hakkında bilgi almaya yarar

            DortIslem dortIslem = new DortIslem(2,3);
            Console.WriteLine(dortIslem.Topla2());
            Console.WriteLine(dortIslem.Topla(3,4));

            //reflection ihtiyaçlar doğduğunda yapılmalıdır çünkü pahalıdır


            //REFLECTİON: çalışma anında dinamik instance üretiyoruz

            var tip = typeof(DortIslem);
            DortIslem dortIslem1=(DortIslem)Activator.CreateInstance(tip,6,7); //bu satır ve DortIslem dortIslem = new DortIslem(2,3); aynıdır
            Console.WriteLine(dortIslem1.Topla(4,5));
            Console.WriteLine(dortIslem1.Topla2());


            Console.ReadLine();
        }

    }
   public class DortIslem
    {
        int _sayi1;
        int _sayi2;

        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
}
