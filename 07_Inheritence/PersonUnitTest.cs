using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_Inheritence
{
    [TestClass]
    public class PersonUnitTest
    {
        [TestMethod]
        public void PersonTesting()
        {
            Person person = new Person("John", "Doe");
            Customer customer = new Customer();
            customer.SetFirstName("Johnny");
            customer.SetLastName("Appleseed");
            customer.IsSubscribedToEmails = true;

            Employee employee = new Employee("Jane", "Doe", "1234567890", "employee@work.com", 473, new DateTime(2000, 12, 12));

            List<Person> persons = new List<Person>();

            persons.Add(person);
            persons.Add(customer);
            persons.Add(employee);

            foreach(Person peep in persons)
            {
                if(peep.GetType() == typeof(Customer))
                {
                    Console.WriteLine(((Customer)peep).IsSubscribedToEmails);
                }
                else if(peep.GetType() == typeof(Employee))
                {
                    Console.WriteLine(((Employee)peep).EmployeeId);
                }
            }

            HourlyEmployee stan = new HourlyEmployee("Stan", "Stanson", "3173173117", "Stan@Stancore", 782, new DateTime(2004, 3, 6), 19.43m, 10);
            persons.Add(stan);
        }
    }
}
