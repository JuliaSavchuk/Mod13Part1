namespace Mod13Part1
{
    internal class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

        public Employee(string fullName, string position, string contactPhone, string email, decimal salary)
        {
            FullName = fullName;
            Position = position;
            ContactPhone = contactPhone;
            Email = email;
            Salary = salary;
        }
    }
}
