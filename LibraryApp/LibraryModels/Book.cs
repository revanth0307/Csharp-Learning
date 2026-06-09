namespace LibraryModels
{
    public class Book : ILoanable, IPrintable
    {
        private string _author;
        private string _title;
        private string _isbn;
        private int _loanPeriod;
        private string _borrower;

        public string Author
        {
            set
            {
                _author = value;

            }
            get
            {
                return _author;
            }
        }

        public string Title
        {
            set
            {
                _title= value;
            }
            get
            {
                return _title;
            }
        }

        public string ISBN
        {
            set
            {
                _isbn= value;
            }
            get
            {
                return _isbn;
            }
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
        public Book(string author,string title,string isbn)
        {
            _author= author;
            _isbn = isbn;
            _title= title;
            _loanPeriod = 21;

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
            Console.WriteLine("---In the Book file----");
            Console.WriteLine($"Title is : {_title}");
            Console.WriteLine($"author is: {_author}");
            Console.WriteLine($"ISBN is: {_isbn}");
            Console.WriteLine($"Loan Period is {_loanPeriod}");
            Console.WriteLine($"borrower name is:{_borrower}");
            Console.WriteLine("---End of Book file----");
            Console.WriteLine();



        }
    }
}
