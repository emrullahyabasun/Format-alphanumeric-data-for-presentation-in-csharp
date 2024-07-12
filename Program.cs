using System.Xml.Linq;

namespace Format_alphanumeric_data_for_presentation_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string first = "Hello";
            //string second = "World";
            //Console.WriteLine("{1} {0}!", first, second);
            //Console.WriteLine("{0} {0} {0}!", first, second);

            ////What is string interpolation ?
            ////String interpolation is a technique that simplifies composite formatting.
            ////Instead of using a numbered token and including the literal value or variable name in a list of arguments to String.Format() or Console.WriteLine(), you can just use the variable name inside of the curly braces.

            string first = "Hello";
            string second = "World";
            Console.WriteLine($"{first} {second}!");
            Console.WriteLine($"{second} {first}!");
            Console.WriteLine($"{first} {first} {first}!");
        }
    }
}
