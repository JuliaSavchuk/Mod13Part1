namespace Mod13Part1
{
    internal class Task2
    {
        public static void Tass2(List<Firma> firms)
        {
            var allFirms = firms.Select(firm => firm);

            var foodFirms = firms.Where(firm => firm.Name.Contains("Food"));

            var marketingFirms = firms.Where(firm => firm.BusinessProfile == "Marketing");

            var marketingOrItFirms = firms.Where(firm => firm.BusinessProfile == "Marketing" || firm.BusinessProfile == "IT");

            var firmsWithMoreThan100Employees = firms.Where(firm => firm.EmployeesCount > 100);

            var firmsWithEmployeesInRange = firms.Where(firm => firm.EmployeesCount >= 100 && firm.EmployeesCount <= 300);

            var firmsInLondon = firms.Where(firm => firm.Address == "London");

            var firmsWithDirectorWhite = firms.Where(firm => firm.DirectorFullName.Split(' ').Last() == "White");

            var firmsFoundedMoreThan2YearsAgo = firms.Where(firm => (DateTime.Now - firm.FoundationDate).TotalDays > 730);

            var firmsFounded123DaysAgo = firms.Where(firm => (DateTime.Now - firm.FoundationDate).TotalDays == 123);

            var firmsWithDirectorBlackAndWhiteInName = firms.Where(firm => firm.DirectorFullName.Split(' ').Last() == "Black" && firm.Name.Contains("White"));

            Console.WriteLine("Всі фірми:");
            foreach (var firm in allFirms)
            {
                Console.WriteLine(firm.Name);
            }

            Console.WriteLine("\nФірми, які мають у назві слово «Food»:");
            foreach (var firm in foodFirms)
            {
                Console.WriteLine(firm.Name);
            }

            Console.WriteLine("\nФірми, які працюють у галузі маркетингу:");
            foreach (var firm in marketingFirms)
            {
                Console.WriteLine(firm.Name);
            }

            Console.WriteLine("\nФірми, які працюють у галузі маркетингу або IT:");
            foreach (var firm in marketingOrItFirms)
            {
                Console.WriteLine(firm.Name);
            }

            Console.WriteLine("\nФірми з кількістю працівників більшою, ніж 100:");
            foreach (var firm in firmsWithMoreThan100Employees)
            {
                Console.WriteLine(firm.Name);
            }

            Console.WriteLine("\nФірми з кількістю працівників у діапазоні від 100 до 300:");
            foreach (var firm in firmsWithEmployeesInRange)
            {
                Console.WriteLine(firm.Name);
            }

            Console.WriteLine("\nФірми, які знаходяться в Лондоні:");
            foreach (var firm in firmsInLondon)
            {
                Console.WriteLine(firm.Name);
            }

            Console.WriteLine("\nФірми, в яких прізвище директора White:");
            foreach (var firm in firmsWithDirectorWhite)
            {
                Console.WriteLine(firm.Name);
            }

            Console.WriteLine("\nФірми, які засновані більше двох років тому:");
            foreach (var firm in firmsFoundedMoreThan2YearsAgo)
            {
                Console.WriteLine(firm.Name);
            }

            Console.WriteLine("\nФірми з дня заснування яких минуло 123 дні:");
            foreach (var firm in firmsFounded123DaysAgo)
            {
                Console.WriteLine(firm.Name);
            }

            Console.WriteLine("\nФірми, в яких прізвище директора Black і мають у назві фірми слово «White»:");
            foreach (var firm in firmsWithDirectorBlackAndWhiteInName)
            {
                Console.WriteLine(firm.Name);
            }
        }
    }
}
