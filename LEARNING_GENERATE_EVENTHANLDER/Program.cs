using System;

namespace LEARNING_GENERATE_EVENTHANLDER
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Ali",
                LastName = "Azimzadeh",
                PersonId = 100,
            };

            person.InsertPersonToDatabase += Person_InsertPersonToDatabase;

            person.InsertPerson(person: person);

        }

        private static void Person_InsertPersonToDatabase(object sender, EventArgs e)
        {

            Console.WriteLine("The person info has been saved successfully!");
        }

        //private static void Person_InsertPersonToDatabase(object sender, PersonEventArgs e)
        //{
        //    string message =
        //        $"The person who has {e.PersonId} Id has been saved successfully!";

        //    Console.WriteLine(message);
        //}

    }
}
