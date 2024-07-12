using Microsoft.VisualBasic;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Xml;
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
            //What is string interpolation ?
            //String interpolation is a technique that simplifies composite formatting.
            //Instead of using a numbered token and including the literal value or variable name in a list of arguments to String.Format() or Console.WriteLine(), you can just use the variable name inside of the curly braces.

            //string first = "Hello";
            //string second = "World";
            //Console.WriteLine($"{first} {second}!");
            //Console.WriteLine($"{second} {first}!");
            //Console.WriteLine($"{first} {first} {first}!");
            #endregion

            #region String Interpolation with Format Specifiers
            //decimal price = 123.45m;
            //int discount = 50;
            //Console.WriteLine($"Price: {price:C} (Save {discount:C})");
            //The reason for the previous "€" output is that the string currency formatting feature is dependent on the local computer setting for culture.In this context, the term "culture" refers to the country / region and language of the end user.
            //The culture code is a five character string that computers use to identify the location and language of the end user.The culture code ensures certain information like dates and currency can be presented properly.
            //For example:
            //the culture code of an English speaker in the USA is en - US.
            //the culture code of a French speaker in France is fr - FR.
            //the culture code of a French speaker in Canada is fr - CA.
            //The culture affects the writing system, the calendar that's used, the sort order of strings, and formatting for dates and numbers (like formatting currency).
            #endregion

            #region Formatting numbers
            //decimal measurement = 123456.78912m;
            //Console.WriteLine($"Measurement: {measurement:N} units");

            //By default, the N numeric format specifier displays only two digits after the decimal point.
            //If you want to display more precision, you can do that by adding a number after the specifier.The following code will display four digits after the decimal point using the N4 specifier.Update your code as follows:
            //decimal measurement = 123456.78912m;
            //Console.WriteLine($"Measurement: {measurement:N4} units");

            #endregion

            #region Formatting percentages
            //decimal tax = .36785m;
            //Console.WriteLine($"Tax rate: {tax:P2}");
            #endregion

            #region RECAP
            //You can use composite formatting or string interpolation to format strings.
            //With composite formatting, you use a string template containing one or more replacement tokens in the form { 0}. You also supply a list of arguments that are matched with the replacement tokens based on their order. Composite formatting works when using string.Format() or Console.WriteLine().
            //With string interpolation, you use a string template containing the variable names you want replaced surrounded by curly braces.Use the $ directive before the string template to indicate you want the string to be interpolated.
            //Format currency using a :C specifier.
            //Format numbers using a :N specifier. Control the precision(number of values after the decimal point) using a number after the :N like { myNumber: N3}.
            //Format percentages using the :P format specifier.
            //Formatting currency and numbers depend on the end user's culture, a five character code that includes the user's country/ region and language(per the settings on their computer).
            #endregion
        }
    }
}
