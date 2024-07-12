using System.Xml.Linq;

namespace Format_alphanumeric_data_for_presentation_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Formatting
            //string first = "Hello";
            //string second = "World";
            //Console.WriteLine("{1} {0}!", first, second);
            //Console.WriteLine("{0} {0} {0}!", first, second); 
            #endregion

            #region String Interpolation
            ////What is string interpolation ?
            ////String interpolation is a technique that simplifies composite formatting.
            ////Instead of using a numbered token and including the literal value or variable name in a list of arguments to String.Format() or Console.WriteLine(), you can just use the variable name inside of the curly braces.

            //string first = "Hello";
            //string second = "World";
            //Console.WriteLine($"{first} {second}!");
            //Console.WriteLine($"{second} {first}!");
            //Console.WriteLine($"{first} {first} {first}!"); 
            #endregion

            #region String Interpolation with Format Specifiers
            decimal price = 123.45m;
            int discount = 50;
            Console.WriteLine($"Price: {price:C} (Save {discount:C})");
            #endregion
        }
    }
}
