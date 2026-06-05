class Program
{
    static void Main(string[] args)
    {
        //accesisng Employee class
        Employee emp=new Employee();
        Console.WriteLine("Employee Class");
        emp.EmployeeId = 1;
        emp.EmployeeName = "Revanth";
        emp.EmpLocation = "Hyderabad";
        Console.WriteLine(emp.EmployeeId);
        Console.WriteLine(emp.EmployeeName);
        Console.WriteLine(emp.EmpLocation);
        Console.WriteLine();

        //accessing the Manager class
        Manager m=new Manager();
        Console.WriteLine("Manager class");
        m.EmployeeId = 2;
        m.EmployeeName = "Bandaru";
        m.EmpLocation = "Nkl";
        m.DeptName = "CSE";

        Console.WriteLine(m.EmployeeId);
        Console.WriteLine(m.EmployeeName);
        Console.WriteLine(m.EmpLocation);
        Console.WriteLine(m.GetSalesOfYear());
        Console.WriteLine();



        //accessing the SalesMan class
        SalesMan s = new SalesMan();
        Console.WriteLine("SalesMan class");
        s.EmployeeId = 3;
        s.EmployeeName = "Test";
        s.EmpLocation = "Banglore";
        s.SalesRegion = "Banglore";
        Console.WriteLine(s.EmployeeId);
        Console.WriteLine(s.EmployeeName);
        Console.WriteLine(s.EmpLocation);
        Console.WriteLine(s.GetSalesOfMonth());








    }
}