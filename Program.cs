using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void enter_Info()
            {

                Console.WriteLine("Enter id:");
                string IdString = Console.ReadLine();

                Console.WriteLine("Enter firstname:");
                string firstname = Console.ReadLine();

                while (firstname == "" || firstname == "-")
                {
                    Console.WriteLine("firstname cant be null ");
                    firstname = Console.ReadLine();
                }

                Console.WriteLine("Enter lastname:");
                string Lastname = Console.ReadLine();

                Console.WriteLine("Enter age:");
                string ageString = Console.ReadLine();


                while (ageString == "" || ageString == "-")
                {
                    Console.WriteLine("age cant be null ");
                    ageString = Console.ReadLine();
                }

                if (int.TryParse(IdString, out int id))
                {
                    Employee obj = new Employee();
                    obj.Id_setter(id);
                    obj.lastname_setter(Lastname);
                }

                if (int.TryParse(ageString, out int age))
                {
                    Employee obj = new Employee();
                    obj.firstname_setter(firstname);
                    obj.Age_setter(age);
                }
                else
                {
                    Console.WriteLine("Invalid age entered. Please enter a valid integer.");
                }
                Console.WriteLine($"your id is {id} ,ur name is {firstname}, ur lastname is {Lastname}, ur age is {age}");
            }


            enter_Info();
        }
    }
}
