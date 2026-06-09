namespace LibraryModels
{
    public class CD : IPrintable,ILoanable
    {
        private string _artist;
        private string _title;
        private int _numberOfTracks;
        private int _loanPeriod;
        private string _borrower;

        public string Artist
        {
            set {  _artist = value; }
            get { return _artist; }
        }
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }

        public int NumberOfTracks
        {
            set { _numberOfTracks = value; }
            get { return _numberOfTracks; }
        }
        public int LoanPeriod
        {
            set { _loanPeriod = value; }
            get { return _loanPeriod; }
        }
        public string Borrower
        {
            set { _borrower = value; }
            get { return _borrower; }
        }

        public CD(string artist, string title, int numberOfTracks)
        {
            _artist = artist;
            _title = title;
            _numberOfTracks = numberOfTracks;
            _loanPeriod = 14;

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
            Console.WriteLine("---In the CD file----");
            Console.WriteLine($"Title is : {_title}");
            Console.WriteLine($"Artist is : {_artist}");
            Console.WriteLine($"Number of tracks are: {_numberOfTracks}");
            Console.WriteLine($"Loan Period is {_loanPeriod}");
            Console.WriteLine($"borrower name is:{_borrower}");
            Console.WriteLine("---End of CD file----");
            Console.WriteLine();    
        }
    }
}
