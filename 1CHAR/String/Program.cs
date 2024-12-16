using System;

namespace StringApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName = "Momiji";
            String lastName = "Inubashiri";

            var fullname = firstName + " " + lastName;

            Console.WriteLine($"Full name : {fullname}");

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine($"Greetings: {greetings}");

            string[] sarry = { "Hello", "From", "Tutorial", "Point" };
            string message = String.Join(" ", sarry);
            Console.WriteLine($"Message: {message}");

            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format($"Message sent at {waiting:D}, {waiting:d}");
            Console.WriteLine($"Message: {chat}");
            Console.ReadKey();

            int compareResult = string.Compare("test1", "test2");
            Console.WriteLine($"Compare Result: {compareResult}");

            int compareResult2 = string.Compare("test1", "Test1", true);
            Console.WriteLine($"Compare Result: {compareResult2}");

            string con1 = "con1";
            string con2 = "con2";
            string conResult = string.Concat(con1, con2);
            Console.WriteLine($"{conResult}");

            string containResource = "resourceTest";
            string findContain = "Test";
            if (containResource.Contains(findContain))
                Console.WriteLine("Contains!!!");

            string oriString = "this is original string";
            string newString = string.Copy(oriString);
            oriString.ToCharArray()[0] = 'o';
            Console.WriteLine(oriString);
            Console.WriteLine(newString);
        }
    }
}
