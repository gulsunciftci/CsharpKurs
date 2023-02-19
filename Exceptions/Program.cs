using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);


            }


            //method
            HandleException(() =>
            {

                Find();

            });

        }

        public static void HandleException(Action action) //parametresiz method bloğu
        {
            try
            {
                action.Invoke();
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception);

            }
            
        }




        private static void Find()
       {
            List<string> students = new List<string> { "engin", "derin", "salih" };
            if (!students.Contains("ahmet"))
            {
                throw new RecordNotFoundException ( "Record Not Found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }
       private static void ExceptionIntro() {
                string[] student = new string[3] { "engin", "derin", "salih" };
                //student[3] = "ahmet"; //hata verir

                try
                {
                    student[3] = "ahmet"; //hata verir
                }
                catch (IndexOutOfRangeException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                catch (DivideByZeroException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); //hata alınca gelecek mesaj, genelde böyle kullanmak yerine loglanır

                }
            }
        }
    }

