public class Employee
{
    //fields
    private int _empId;
    private string _empName;
    private string _empLocation;

    //prop's
    public int EmployeeId
    {
        set
        {
            _empId = value;
        }
        get
        {
            return _empId;
        }
    }

    public string EmployeeName
    {
        set
        {
            _empName = value;
        }
        get
        {
            return _empName;
        }
    }

    public string EmpLocation
    {
        set
        {
            _empLocation= value;
        }
        get
        {
            return _empLocation;
        }
    }
}