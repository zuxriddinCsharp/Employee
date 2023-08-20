using System.Data;

namespace Employee
{
    class Person 
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age{ get; private set; }
        public int MaxAge { get; private set; }

        public Person(int id, string name, int age, int maxAge)
        {
            Id = id;
            Name = name;
            Age = age;
            MaxAge = maxAge;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id} Name: {Name} Age: {Age} Max age {MaxAge}");
        }
        public static Person GetOlderPerson(Person person, Person person1)
        {
            return person.Age > person1.Age ? person : person1;
        }
        public static int CountFemalePerson(Person[] persons)
        {
            int count = 0;
            foreach (Person person in persons)
            {
                if (person.Name.ToLower().StartsWith("femaly"))
                    count++;
            }
            return count;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(1, "Adam", 30, 80);
            Person person1 = new Person(2, "Andrew", 25, 75);
            Person person2 = new Person(3, "Femaly Agata", 20, 70);

            person.DisplayInfo();
            person1.DisplayInfo();
            person2.DisplayInfo();

            Console.WriteLine();

            Person OlderPerson= Person.GetOlderPerson(person,person1);
            OlderPerson.DisplayInfo();

            Console.WriteLine();

            Person[] persons = { person, person1,person2};
            int CountFemaly =Person.CountFemalePerson(persons);
            Console.WriteLine($"Number of female persons: {CountFemaly}");
        }
    }
}