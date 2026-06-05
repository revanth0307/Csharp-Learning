class Bank
{
    static void Main(string[] args)
    {
        string userName = null;
        string password = null;
        System.Console.WriteLine("Bank Prjct");
        System.Console.WriteLine("Enter a username: ");
        userName=System.Console.ReadLine();

        if (userName != "")
        {
            System.Console.WriteLine("Enter Password: ");
            password=System.Console.ReadLine();
        }
        if (userName == "system" && password =="manager")
        {
            int mainMenuChoice = -1;
            do
            {
                System.Console.WriteLine("Main Menu is: ");
                System.Console.WriteLine("1.Customers");
                System.Console.WriteLine("2.Accounts");
                System.Console.WriteLine("3.Fubd Transfers");
                System.Console.WriteLine("4.Statement");
                System.Console.WriteLine("5.Exit");

                System.Console.WriteLine("Enter choise: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1:
                        customerMenu();
                        break;
                    case 2:
                        AccountMenu();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }
            } while (mainMenuChoice != 5);

        }
        else
        {
            System.Console.WriteLine("invalid username or pass");
        }
        System.Console.WriteLine("Thankyou");

    }

    static void customerMenu()
    {
        int customerMenuChoice = -1;
        do
        {
            System.Console.WriteLine("\n:::Customers Menu:");
            System.Console.WriteLine("1.Add customer");
            System.Console.WriteLine("2.Delete customer");
            System.Console.WriteLine("3.Update customer");
            System.Console.WriteLine("4.View customer");
            System.Console.WriteLine("0.Go back to Menu");

            System.Console.WriteLine("Enter choice: ");
            customerMenuChoice=int.Parse(System.Console.ReadLine());

        } while(customerMenuChoice != 0);
    }

    static void AccountMenu()
    {
        int AccountMenuChoice = -1;
        do
        {
            System.Console.WriteLine("\n:::Account Menu:");
            System.Console.WriteLine("1.Add Account");
            System.Console.WriteLine("2.Delete Account");
            System.Console.WriteLine("3.Update Account");
            System.Console.WriteLine("4.View Account");
            System.Console.WriteLine("0.Go back to Menu");

            System.Console.WriteLine("Enter choice: ");
            AccountMenuChoice = int.Parse(System.Console.ReadLine());

        } while (AccountMenuChoice != 0);
    }
}