using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopUi
{
    class Person
    {
        private string firstname;
        private string middleName;
        private string lastName;
        private int point;

        //public Person(string firstName, string lastName)
        //{
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //}

        //public Person(string firstName,string middleName,string lastName)
        //{
        //    this.firstName = firstName;
        //    this.MiddleName = middleName;
        //    this.lastName = lastName; 
        //}
        public string FirstName { set; get; }
        public string MiddleName { set; get; }
        public string LastName { set; get; }

        public Person()
        {
            this.point = 10;
        }
        public Person(string firstName,string lastName):this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(string firstName,string middleName,string lastName):this(firstName,lastName)
        {        
            this.MiddleName = middleName;           
        }
        public string GetFullName()
        {
            string fullName = FirstName + " " + MiddleName + " " + LastName+ " ";
            return fullName;
        }
    }    
}
