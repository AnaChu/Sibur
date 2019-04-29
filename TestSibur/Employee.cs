

namespace TestSibur
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Title { get; set; }

        public Employee(string firstName, string lastName, string middleName, string title)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Title = title;
        }

        public override string ToString()
        {
            return ($"{LastName} {FirstName} {MiddleName} {Title}");
        }
    }
}
