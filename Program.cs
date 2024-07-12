namespace Format_alphanumeric_data_for_presentation_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";
            string result = string.Format("{0} {1}!", first, second);
            Console.WriteLine(result);
        }
    }
}
