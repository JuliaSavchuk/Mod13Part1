namespace Mod13Part1
{
    internal class Firma
    {
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string BusinessProfile { get; set; }
        public string DirectorFullName { get; set; }
        public int EmployeesCount { get; set; }
        public string Address { get; set; }
        public List<Employee> Employees { get; set; }

        public Firma(string name, DateTime foundationDate, string businessProfile, string directorFullName, int employeesCount, string address)
        {
            Name = name;
            FoundationDate = foundationDate;
            BusinessProfile = businessProfile;
            DirectorFullName = directorFullName;
            EmployeesCount = employeesCount;
            Address = address;
            Employees = new List<Employee>();
        }
    }
}
