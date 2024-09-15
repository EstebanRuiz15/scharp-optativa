using System.Data.Common;
using System.Reflection.Metadata.Ecma335;

namespace HelloWorld
{
    class Program
    {

        static void Main()
        {
            String nameInput;
            String BirthdayInput;
            DateOnly date = new DateOnly();
            Console.WriteLine("hello, welcome to the age calculator");
            Console.WriteLine("write your name ");
            nameInput = Console.ReadLine();
            Console.WriteLine($"nice to meet you {nameInput}");
            bool ValidBirthday;
            do
            {
                Console.WriteLine("write you birthday in the format MM/dd/yyyy");
                BirthdayInput = Console.ReadLine();
                ValidBirthday = DateOnly.TryParse(BirthdayInput, out date);
                if(!ValidBirthday) Console.WriteLine($"the birthday {BirthdayInput} is invalid");
            } while (!ValidBirthday);

            var Person = new Person
            {
                Name = nameInput,
                Birthday = date,
                Age = DateTime.Now.Year - date.Year
            };
            Console.WriteLine($"your name is: {Person.Name}");
            Console.WriteLine($"your birthday: {Person.Birthday}");
            Console.WriteLine($"your age is: {Person.Age}");
            Console.ReadLine();
        }
    }

    public class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }
}