public class StartUp
{
    public static void Main()
    {
        List<Person> people = new List<Person>();

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] personInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = personInfo[0];
            string id = personInfo[1];
            int age = int.Parse(personInfo[2]);

            Person person = new Person(name, id, age);
            bool personExists = false;

            foreach (Person currentPerson in people)
            {
                if (currentPerson.ID == person.ID)
                {
                    currentPerson.Name = person.Name;
                    currentPerson.Age = person.Age;
                    personExists = true;
                }
            }

            if (!personExists)
            {
                people.Add(person);
            }
        }

        PrintPeopleByAge(people);
    }

    static void PrintPeopleByAge(List<Person> people)
    {
        foreach (var person in people.OrderBy(x => x.Age))
        {
            Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
        }
    }
}

public class Person
{
    public Person(string name, string id, int age)
    {
        Name = name;
        ID = id;
        Age = age;
    }

    public string Name { get; set; }
    public string ID { get; set; }

    public int Age { get; set; }
}