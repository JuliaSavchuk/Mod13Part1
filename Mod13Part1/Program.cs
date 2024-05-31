namespace Mod13Part1
{
    class Program
    {
        static void Main(string[] args)
        {

            var employee1 = new Employee("Lionel Messi", "Manager", "234567890", "lionel.messi@example.com", 1000);
            var employee2 = new Employee("Cristiano Ronaldo", "Developer", "235678901", "cristiano.ronaldo@example.com", 900);
            var employee3 = new Employee("Diego Maradona", "Manager", "231234567", "diego.maradona@example.com", 1100);
            var employee4 = new Employee("Lionel Richie", "Designer", "239876543", "lionel.richie@example.com", 850);

            List<Firma> firms = new List<Firma>
        {
            new Firma("TechFood", new DateTime(2019, 1, 1), "IT", "John White", 150, "London"),
            new Firma("MarketingHub", new DateTime(2018, 5, 23), "Marketing", "Alice Smith", 80, "New York"),
            new Firma("Foodies", new DateTime(2021, 11, 15), "Food", "Bob White", 50, "London"),
            new Firma("InnovateIT", new DateTime(2017, 9, 30), "IT", "Emma Brown", 200, "London"),
            new Firma("MarketLeaders", new DateTime(2020, 4, 18), "Marketing", "Oliver Black", 120, "Manchester")
        };

            firms[0].Employees.Add(employee1);
            firms[0].Employees.Add(employee2);
            firms[1].Employees.Add(employee3);
            firms[2].Employees.Add(employee4);


            Console.WriteLine("\n-----Task 1-----\n");
            Task1.Tass1(firms);

            Console.WriteLine("\n\n-----Task 2-----\n");
            Task2.Tass2(firms);

            Console.WriteLine("\n\n-----Task 3-----\n");
            Task3.Tass3(firms);
        }
    }
}
