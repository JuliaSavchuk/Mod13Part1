namespace Mod13Part1
{
    internal class Task3
    {
        public static void Tass3(List<Firma> firms)
        {
            var employeesOfFirm = firms.Where(firm => firm.Name == "TechFood").SelectMany(firm => firm.Employees);

            decimal salaryThreshold = 900;
            var employeesWithHighSalary = firms.Where(firm => firm.Name == "TechFood").SelectMany(firm => firm.Employees).Where(emp => emp.Salary > salaryThreshold);

            var managers = firms.SelectMany(firm => firm.Employees).Where(emp => emp.Position == "Manager");

            var employeesWithPhoneStartingWith23 = firms.SelectMany(firm => firm.Employees).Where(emp => emp.ContactPhone.StartsWith("23"));

            var employeesWithEmailStartingWithDi = firms.SelectMany(firm => firm.Employees).Where(emp => emp.Email.StartsWith("di"));

            var employeesNamedLionel = firms.SelectMany(firm => firm.Employees).Where(emp => emp.FullName.StartsWith("Lionel"));

            Console.WriteLine("Працівники фірми 'TechFood':");
            foreach (var emp in employeesOfFirm)
            {
                Console.WriteLine(emp.FullName);
            }

            Console.WriteLine("\nПрацівники фірми 'TechFood' з зарплатою більше 900:");
            foreach (var emp in employeesWithHighSalary)
            {
                Console.WriteLine(emp.FullName);
            }

            Console.WriteLine("\nМенеджери всіх фірм:");
            foreach (var emp in managers)
            {
                Console.WriteLine(emp.FullName);
            }

            Console.WriteLine("\nПрацівники з телефоном, що починається на '23':");
            foreach (var emp in employeesWithPhoneStartingWith23)
            {
                Console.WriteLine(emp.FullName);
            }

            Console.WriteLine("\nПрацівники з email, що починається на 'di':");
            foreach (var emp in employeesWithEmailStartingWithDi)
            {
                Console.WriteLine(emp.FullName);
            }

            Console.WriteLine("\nПрацівники з ім'ям Lionel:");
            foreach (var emp in employeesNamedLionel)
            {
                Console.WriteLine(emp.FullName);
            }
        }
    }
}
