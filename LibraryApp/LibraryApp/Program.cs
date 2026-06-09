using LibraryModels;

class Program
{
    static void Main(string[] args)
    {
        Book myBook = new Book("Rabindranath Tagore", "Motivated", "Test");
        DVD myDvd = new DVD("SSR", "Varanasi", 180);
        CD myCd = new CD("DSP","OST", 5);

        myBook.Borrow("Revanth");
        myBook.Print();
        myBook.Return();


        myDvd.Borrow("Revanth");
        myDvd.Print();
        myDvd.Return();


        myCd.Borrow("Revanth");
        myCd.Print();
        myCd.Return(); 
        
    }
}