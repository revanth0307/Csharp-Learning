
namespace LibraryModels
{
    public class DVD : ILoanable, IPrintable
    {
        private string _director;
        private string _title;
        private int _lengthInMinutes;
        private int _loanPeriod;
        private string _borrower;

        public string Director
        {
            set
            {
                _director = value;
            }
            get { return _director; }
        }

        public string Title
        {
            set
            {
                _title = value;
            }
            get
            {
                return _title;
            }
        }
        public int LengthInMinutes
        {
            set
            {
                _lengthInMinutes = value;
            }
            get { return _lengthInMinutes; }
        }
        public int LoanPeriod
        {
            set
            {
                _loanPeriod = value;
            }
            get
            {
                return _loanPeriod;
            }
        }
        public string Borrower
        {
            set
            {
                _borrower = value;
            }
            get
            {
                return _borrower;
            }
        }
        public DVD(string director, string title, int lengthInMinutes)
        {
            _director = director;
            _title = title;
            _lengthInMinutes = lengthInMinutes;
            _loanPeriod = 7;
        }
        public void Borrow(string borrowerName)
        {
            _borrower = borrowerName;
        }
        public void Return()
        {
            _borrower = null;
        }
        public void Print()
        {
            Console.WriteLine("---In the DVD file----");
            Console.WriteLine($"Title is : {_title}");
            Console.WriteLine($"director is: {_director}");
            Console.WriteLine($"Length in Minutes is: {_lengthInMinutes}");
            Console.WriteLine($"Loan Period is {_loanPeriod}");
            Console.WriteLine($"borrower name is:{_borrower}");
            Console.WriteLine("---End of DVD file----");
            Console.WriteLine();
        }
    }
}
