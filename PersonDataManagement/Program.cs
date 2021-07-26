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
            Console.Read();
        }
    }
}
