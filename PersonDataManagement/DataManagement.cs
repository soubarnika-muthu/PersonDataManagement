using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    class DataManagement
    {
        List<PersonData> personList = new List<PersonData>();
        //creating the list of person with name age address and id 
        public void CreateList()
        {
            personList.Add(new PersonData(1, "sou", "madurai", 15));
            personList.Add(new PersonData(2, "gem", "chennai", 29));
            personList.Add(new PersonData(6, "venkat", "trichy", 20));
            personList.Add(new PersonData(9, "shanthi", "madurai", 38));
            personList.Add(new PersonData(5, "mani", "chennai", 72));
            personList.Add(new PersonData(4, "muthu", "madurai", 28));
            personList.Add(new PersonData(7, "simar", "chennai", 64));
            DisplayList(personList);
        }
        public void RetriveTop2PersonAgeLessThan60()
        {
            //retrive the top two person detail from the list whose age is less tha 10;
            List<PersonData> list = personList.FindAll(person => person.age < 60).OrderBy(x => x.age).Take(2).ToList();
            Console.WriteLine("\nRetriving the top 2 person from list whose age less than 60 ");
            DisplayList(list);
        }
        //method to display the list
        public void DisplayList(List<PersonData> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine("SSN:{0}  Name:{1}  Address:{2}  Age:{3}", i.SSN, i.name, i.address, i.age);
            }
        }
    }
}
