using System;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementaion of Lambda expression");
            Console.WriteLine("Creating Person Data Management System");
            DataManagement management = new DataManagement();
            management.CreateList();
            Console.WriteLine("1.RetriveTop2PersonAgeLessThan60");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    management.RetriveTop2PersonAgeLessThan60();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                        break; ;

            }
            Console.Read();
        }
    }
}
