namespace ConsoleApp_HomeWork9.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] surnames = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Wilson", "Walker", "White", "Harris", "Taylor", "Clark", "Lewis", "Wright" };
            Console.WriteLine(string.Join(" , ", surnames));

            bool all = surnames.All(surname => surname.Length > 3);
            Console.WriteLine($"All surnames are more than three characters long: {all}");

            bool all2 = surnames.All(surname => surname.Length > 3 && surname.Length < 10);
            Console.WriteLine($"All surnames are more than three and less than ten characters long: {all2}");

            bool any = surnames.Any(surname => surname.StartsWith("W"));
            Console.WriteLine($"There is at least one surname in the array that starts with the letter «W»: {any}");

            bool any2 = surnames.Any(surname => surname.EndsWith("y"));
            Console.WriteLine($"Is there at least one surname in the array that ends with the letter «Y»: {any2}");

            bool contains = surnames.Contains("Orange");
            Console.WriteLine($"There is a surname Orange in the array: {contains}");

            string firstOrDefault = surnames.FirstOrDefault(surname => surname.Length == 6);
            Console.WriteLine($"First surname with a length of 6: {firstOrDefault}");

            string lastOrDefault = surnames.LastOrDefault(surname => surname.Length < 15);
            Console.WriteLine($"Last surname with a length of less than 15: {lastOrDefault}");
        }
    }
}