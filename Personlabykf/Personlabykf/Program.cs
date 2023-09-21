using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personlabykf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Ian", "Brooks", 30, "Red", true);
            Person person2 = new Person(2, "Gina", "James", 18, "Green", false);
            Person person3 = new Person(3, "Mike", "Briscoe", 45, "Blue", true);
            Person person4 = new Person(4, "Mary", "Beeals", 28, "Yellow", true);

            string ginasInfo = person2.DisplayPersonInfo();
            Console.WriteLine(ginasInfo);

            string mikesInfo = person3.ToString();
            Console.WriteLine(mikesInfo);

            person1.ChangeFavoriteColor();

            string ianInfo = person1.DisplayPersonInfo();
            Console.WriteLine(ianInfo);

            // Display Mary's age in 10 years
            int marysAgeTenYears = person4.GetAgeInTenYears();
            Console.WriteLine("Mary Beals's age in 10 years: " + marysAgeTenYears);

            // Create Relation instances (linking Person instances together)
            Relation relation1 = new Relation("Sister", person2, "Sister", person4);
            Relation relation2 = new Relation("Brother", person1, "Brother", person3);

            // Display first relation
            Console.WriteLine(relation1.ToString());
            Console.WriteLine(relation2.ToString());

            // Create and populate list of people
            List<Person> people = new List<Person>();

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            // Determine average age
            int sum = 0;

            // Get sum of everyone's age
            foreach (Person person in people)
            {
                sum += person.Age;
            }

            // Divide sum by number of people.
            // One operand for / operator must be double for result to be double.
            double average = sum / (double)people.Count;

            // Display average age
            Console.WriteLine("Average age: " + average + "\n");


            // Find the youngest and oldest persons
            Person youngestPerson = null;
            Person oldestPerson = null;

            foreach (Person person in people)
            {
                if (youngestPerson == null || person.Age < youngestPerson.Age)
                {
                    youngestPerson = person;
                }

                if (oldestPerson == null || person.Age > oldestPerson.Age)
                {
                    oldestPerson = person;
                }
            }

            // Display the youngest and oldest persons
            if (youngestPerson != null)
            {
                Console.WriteLine("Youngest Person:");
                Console.WriteLine(youngestPerson.FirstName + "\n");
            }

            if (oldestPerson != null)
            {
                Console.WriteLine("Oldest Person:");
                Console.WriteLine(oldestPerson.FirstName + "\n");
            }

            // Find and display people whose first names start with "M"
            Console.WriteLine("People whose first names start with 'M':");
            foreach (Person person in people)
            {
                if (person.FirstName.StartsWith("M", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(person.FirstName + " " + person.LastName + "\n");
                }
            }

            // Find and display the person who likes the color "Blue"
            Console.WriteLine("Person who likes the color 'Blue':");
            foreach (Person person in people)
            {
                if (string.Equals(person.FavoriteColor, "Blue", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(person.FirstName + "\n");
                }
            }

        }
    }
}