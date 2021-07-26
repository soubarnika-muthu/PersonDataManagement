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
            Console.WriteLine("1.RetriveTop2PersonAgeLessThan60\n2.RetrivePersonAgeBetween13And18\n3.AverageAgeOfList\n4.SpecificDataRetrival");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    management.RetriveTop2PersonAgeLessThan60();
                    break;
                case 2:
                    management.RetrivePersonAgeBetween13And18();
                    break;
                case 3:
                    management.AverageAge();
                    break;
                case 4:
                    Console.WriteLine("Enter name to search:");
                    string name = Console.ReadLine();
                    bool result=management.SpecificDataRetrival(name);
                    if(result==true)
                    {
                        Console.WriteLine("Name is present in list");
                    }
                    else
                    {
                        Console.WriteLine("Name is not  present in list");
                    }
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
