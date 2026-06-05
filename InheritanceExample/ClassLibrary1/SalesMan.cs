public class SalesMan : Employee
{
    //fields
    private string _salesRegion;

    //props
    public string SalesRegion
    {
        set
        {
            _salesRegion = value;
        }
        get
        {
            return _salesRegion;
        }
    }

    public long GetSalesOfMonth()
    {
        return 100;
    }
}