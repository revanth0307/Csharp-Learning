class Program
{
    static void Main(string[] args)
    {
        Employee.OrganizationName = "Navtech";

        string choice = "yes";

        while (choice.ToLower() == "yes")
        {
            Employee emp = new Employee();
            System.Console.WriteLine("    Enter Employee Details   ");

            System.Console.Write("Enter Employee ID        : ");
            emp.EmpID = int.Parse(System.Console.ReadLine());

            System.Console.Write("Enter Employee Name      : ");
            emp.EmpName = System.Console.ReadLine();

            System.Console.Write("Enter Salary Per Hour    : ");
            emp.SalaryPerHour = double.Parse(System.Console.ReadLine());

            System.Console.Write("Enter No of Working Hours: ");
            emp.NoOfWorkingHours = double.Parse(System.Console.ReadLine());

            emp.NetSalary = emp.SalaryPerHour * emp.NoOfWorkingHours;

            System.Console.WriteLine();
            System.Console.WriteLine("  Employee Details    ");
            System.Console.WriteLine("Organization Name  : " + Employee.OrganizationName);
            System.Console.WriteLine("Department Name    : " + emp.DepartmentName);
            System.Console.WriteLine("Type of Employee   : " + Employee.TypeOfEmployee);

            System.Console.WriteLine("Employee ID        : " + emp.EmpID);
            System.Console.WriteLine("Employee Name      : " + emp.EmpName);
            System.Console.WriteLine("Salary Per Hour    : " + emp.SalaryPerHour);
            System.Console.WriteLine("No of Working Hours: " + emp.NoOfWorkingHours);
            System.Console.WriteLine("Net Salary         : " + emp.NetSalary);

            System.Console.Write("\n Do you want to continue? (yes/no): ");
            choice = System.Console.ReadLine();
            System.Console.WriteLine();
        }

        System.Console.WriteLine("Thank you! Exiting...");
    }
}