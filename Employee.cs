using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Employee
    {
        string FirstName { get; set; }
        int Age { get; set; }
        string Lastname { get; set; }
        int Id { get; set; }
        public void Age_setter(int age)
        {
            this.Age = age;
        }
        public int Age_getter()
        {
            return Age;
        }

        public void firstname_setter(string name)
        {
            this.FirstName = name;
        }
        public string firstname_getter()
        {
            return FirstName;
        }
        public void lastname_setter(string lastname)
        {
            this.Lastname = lastname;
        }
        public string lastname_getter()
        {
            return Lastname;
        }
        public void Id_setter(int id)
        {
            this.Id = id;
        }
        public int Id_getter()
        {
            return Id;
        }


        public Employee() {
          
        }


    }
}
