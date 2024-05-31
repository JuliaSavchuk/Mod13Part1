namespace Mod13Part1
{
    internal class Task1
    {
        public static void Tass1(List<Firma> firms)
        {
            var allFirms = from firm in firms
                           select firm;


            var foodFirms = from firm in firms
                            where firm.Name.Contains("Food")
                            select firm;

            var marketingFirms = from firm in firms
                                 where firm.BusinessProfile == "Marketing"
                                 select firm;


            var marketingOrItFirms = from firm in firms
                                     where firm.BusinessProfile == "Marketing" || firm.BusinessProfile == "IT"
                                     select firm;

            var firmsWithMoreThan100Employees = from firm in firms
                                                where firm.EmployeesCount > 100
                                                select firm;

            var firmsWithEmployeesInRange = from firm in firms
                                            where firm.EmployeesCount >= 100 && firm.EmployeesCount <= 300
                                            select firm;


            var firmsInLondon = from firm in firms
                                where firm.Address == "London"
                                select firm;

            var firmsWithDirectorWhite = from firm in firms
                                         where firm.DirectorFullName.Split(' ').Last() == "White"
                                         select firm;

            var firmsFoundedMoreThan2YearsAgo = from firm in firms
                                                where (DateTime.Now - firm.FoundationDate).TotalDays > 730
                                                select firm;

            var firmsFounded123DaysAgo = from firm in firms
                                         where (DateTime.Now - firm.FoundationDate).TotalDays == 123
                                         select firm;

            var firmsWithDirectorBlackAndWhiteInName = from firm in firms
                                                       where firm.DirectorFullName.Split(' ').Last() == "Black" && firm.Name.Contains("White")
                                                       select firm;

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

