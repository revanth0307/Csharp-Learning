using System.Runtime.CompilerServices;

class DebitCard
{
    private string pin;
    public string Pin{
        set
        {
            if ((value.Length == 4 || value.Length == 6)&&value.All(char.IsDigit))
            {
                pin= value;
            }
            else
            {
                System.Console.WriteLine("Pin is invalid");
            }
        }
        get{
                return pin;
            }
    }
}

class Program
{
    static void Main(string[] args)
    {
        DebitCard card = new DebitCard();
        System.Console.WriteLine("Enter pin: ");
        string userPin = System.Console.ReadLine();
        card.Pin= userPin;
        System.Console.WriteLine("stored pin is: "+card.Pin);
    }
}