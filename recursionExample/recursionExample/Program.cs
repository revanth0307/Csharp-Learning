class RecursionExample
{
    public double Factorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }
}
class program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a number: ");
        int n=int.Parse(System.Console.ReadLine());
        RecursionExample re = new RecursionExample();

        double fact = re.Factorial(n);
        System.Console.WriteLine("factorial of : "+n+" is: "+fact);


    }
}