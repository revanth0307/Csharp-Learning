namespace LibraryModels
{
    public interface ILoanable
    {
        int LoanPeriod { get; set; }
        string Borrower {  get; set; }

        void Borrow(string borrowerName);
        void Return();
    }
}
