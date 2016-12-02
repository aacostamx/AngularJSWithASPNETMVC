namespace AngularJSWithASPNETMVC.Models
{
    public class Employee
    {
        public Employee()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Input = string.Empty;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Input { get; set; }
    }
}