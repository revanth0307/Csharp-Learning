public class Manager : Employee
{
    //fileds
    private string _deptName;

    //prop
    public string DeptName
    {
        set
        {
           _deptName = value;
        }
        get
        {
            return _deptName;
        }
    }

    //manager class method is accesed from only this class
    public long GetSalesOfYear()
    {
        return 10000;
    }
}