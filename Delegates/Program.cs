using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate(); //void metodlara delegelik yapıyor
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1,int number2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage; //özel elçi
            myDelegate += customerManager.ShowAlert;
            myDelegate(); //delegeyi çağırdık, fonksiyonu çalıştırmak için bu şart

            Console.WriteLine("**********");

            myDelegate -= customerManager.SendMessage;
            myDelegate();


            Console.WriteLine("**********");

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("Hello");


            Console.WriteLine("**********");


            Matematik matematik = new Matematik(); //instance
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;

            var sonuc = myDelegate3(2, 3); //delegelerde en son verilen delege çalışır

            Console.WriteLine(sonuc);


            //action, metoda karşılık gelir ve voidleri çalıştırır
            
            HandleException(() =>
            {
                //Her seferinde try catch yazmaya engel olur
               

            });


            Console.WriteLine("**********");

            //func metodun actiondan farkı değer dördürmesidir
            Func<int, int, int> add = Topla; //üçüncü parametre dönüş tipidir
            Console.WriteLine(add(3, 4));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);

            };
            Console.WriteLine(getRandomNumber());

            Console.WriteLine("**********");

            Thread.Sleep(2000); //Random aynı sayıyı vermesin diye ekledik
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());


            Console.ReadLine();
        }
      
        static int Topla(int x, int y)
        {
            return x + y;
        }
        

    public static void HandleException(Action action) //parametresiz method bloğu
    {
        //action: kod bloğu çalıştırmayı sağlar
        try
        {
            action.Invoke(); //kod bloğu çalışır
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);

        }

    }
}
    class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
