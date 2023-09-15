using ConsoleApp_HomeWork9.Domain;
namespace ConsoleApp_HomeWork9.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine[] magazins = 
            { 
                new Magazine("Vogue", "Fashion", 50, new DateTime(2023, 10, 10)),
                new Magazine("Forbes", "Business", 40, new DateTime(2022, 10, 10)),
                new Magazine("National Geographic", "Science", 30, new DateTime(2021, 10, 10)),
                new Magazine("Gardeners' World", "Garden", 20, new DateTime(2021, 10, 10)),
                new Magazine("Fishing World", "Fishing", 10, new DateTime(2011, 10, 10)),
                new Magazine("Hunting World", "Hunting", 5, new DateTime(2010, 10, 10)),
                new Magazine("Auto World", "Auto", 1, new DateTime(2020, 10, 10)),
            };

            bool all = magazins.All(magazin => magazin.NumberOfPages > 30);
            Console.WriteLine($"Are all magazines more than 30 pages long: {all}");

            bool all2 = magazins.All(magazin => magazin.Genre == "Fashion" || magazin.Genre == "Business" || magazin.Genre == "Sport");
            Console.WriteLine($"Are all magazines in the genre «Fashion», «Business» or «Sport»: {all2}");

            bool any = magazins.Any(magazin => magazin.Genre == "Garden");
            Console.WriteLine($"Is there at least one magazine in the «Garden» genre: {any}");

            bool any2 = magazins.Any(magazin => magazin.Genre == "Fishing");
            Console.WriteLine($"Is there at least one magazine in the «Fishing» genre: {any2}");

            bool hasHunting = magazins.Any(journal => journal.Genre.Equals("Hunting", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Is there at least one journal about 'Hunting' (case-insensitive)? " + hasHunting);

            Magazine firstOrDefault = magazins.FirstOrDefault(magazin => magazin.DateOfPublication.Year == 2022);
            Console.WriteLine($"First magazine with a release year of 2022: {firstOrDefault}");

            Magazine lastOrDefault = magazins.LastOrDefault(magazin => magazin.Name.StartsWith("Auto"));
            Console.WriteLine($"Last magazine whose name starts with the word «Auto»: {lastOrDefault}");
        }
    }
}