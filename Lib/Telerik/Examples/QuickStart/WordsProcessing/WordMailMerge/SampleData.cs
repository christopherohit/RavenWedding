using System;
using System.Collections.Generic;
using System.Text;

namespace Telerik.Examples.WinControls.WordsProcessing.WordMailMerge
{ 
    public class Person
    {
        private readonly string firstName;
        private readonly string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public static IEnumerable<Person> Persons
        {
            get
            {
                return new Person[] {
                    new Person("Andrew", "Fuller"),
                    new Person("Nancy", "Davolio"),
                    new Person("Janet", "Leverling"),
                    new Person("Margaret", "Peacock"),
                    new Person("Robert", "King"),
                    new Person("Horst", "Kloss"),
                };
            }
        }
    }
}
