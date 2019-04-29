using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weekend_Task.Classes;

namespace Weekend_Task
{
    class Program
    {


        static void Main(string[] args)
        {

            Employee e = new Employee();

            string input = "";

            do
            {

                do
                {
                    Console.WriteLine("Secim edin: \nI - ishci yaratmaq \nM - mushteri yaratmaq \nP - mehsul yaratmaq \nO - sifarish yaratmaq");
                    input = Console.ReadLine().ToUpper();

                } while (input != "I" && input != "M" && input != "P" && input != "O" && input != "X");

                switch (input)
                {
                    case "I":
                        e.ID = e.GetID();

                        Console.Write("Name: ");
                        e.Name = Console.ReadLine();

                        Console.Write("Surname: ");
                        e.Surname = Console.ReadLine();

                        Console.Write("Birthday: ");
                        e.Birthday = Convert.ToDateTime(Console.ReadLine());

                        Console.Write("Card_ID: ");
                        e.Card_ID = Console.ReadLine();

                        Console.Write("Position: ");
                        e.Position = Console.ReadLine();

                        Console.Write("Salary: ");
                        e.Salary = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"Ishci yaradildi. {e.ID} - {e.Name} {e.Surname}");

                        break;
                    case "M":
                        break;
                    case "P":
                        break;
                    case "O":
                        Order order = new Order();
                        order.OrderEmployee = e;
                        break;
                    default:

                        break;
                }



            } while (input != "X");

          


            Console.ReadLine();
        }
    }
}
