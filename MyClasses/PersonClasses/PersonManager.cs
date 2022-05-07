using System.Collections.Generic;

namespace MyClasses.PersonClasses
{
    public class PersonManager
    {
        public Person CreatePerson(string first,
                                   string last,
                                   bool isSupervisor)
        {
            Person ret = null;

            if (!string.IsNullOrEmpty(first))
            {
                if (isSupervisor)
                {
                    ret = new Supervisor();
                }
                else
                {
                    ret = new Employee();
                }

                // Assign Variables
                ret.FirstName = first;
                ret.LastName = last;
            }

            return ret;
        }

        // This Method simulates retrieving a list of Person object
        // A Collection of Person objects
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            people.Add(new Person() { FirstName = "Paul", LastName = "Rudd" });
            people.Add(new Person() { FirstName = "John", LastName = "Wick" });
            people.Add(new Person() { FirstName = "Bruce", LastName = "Lee" });

            return people;
        }

        // This Method Simulates retrieving a list of Supervisors
        // A collection of Supervisor objects
        public List<Person> GetSupervisors()
        {
            List<Person> people = new List<Person>();

            people.Add(CreatePerson("Paul", "Rudd", true));
            people.Add(CreatePerson("Michael", "Krasowski", true));

            return people;
        }

        // This Method Simulates retrieving a list of Employees
        // A collection of Employees objects
        public List<Person> GetEmployees()
        {
            List<Person> people = new List<Person>();

            people.Add(CreatePerson("Steve", "Nystrom", true));
            people.Add(CreatePerson("John", "Kuhn", true));
            people.Add(CreatePerson("Jim", "Ruhl", true));

            return people;
        }

        // This Method Simulates retrieving a list of Supervisor And Employees
        // A collection of Supervisor And Employees objects
        public List<Person> GetSupervisorAndEmployees()
        {
            List<Person> people = new List<Person>();

            people.AddRange(GetEmployees());
            people.AddRange(GetSupervisors());

            return people;
        }

    }
}
