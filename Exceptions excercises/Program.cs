//    Shembull i try catch me exceptions
//    Console.WriteLine("Vendosni nje nr per tu ber parse");
//    string s = Console.ReadLine();
//    try
//    {
//        int value = Int32.Parse(s);
//        if (value > 0) 
//        { 
//        Console.WriteLine("Number parsed"); 
//        }
//        else
//        {
//        throw new Exception("Invalid input");
//        }
//    }
//    catch (OverflowException)
//    {
//        Console.WriteLine("Number too big");
//    }
//    catch (FormatException e)
//    {
//    //Console.WriteLine("Invalid integer number");
//    Console.WriteLine(e.Message);
//}
//    catch (Exception)  ///exception e do t thot- 
//    {
//        Console.WriteLine("Number cannot be parsed");
//    }





//Ex me bank acc
using Exceptions_excercises;

BankAccount LLogaria1 = new BankAccount()
{
    AccountHolder = "Klienti 1",
};

Console.WriteLine("Enter 1 to deposit or 2 to withdraw");
string s = Console.ReadLine();

try
{
    int input = int.Parse(s);
    if (input == 1 || input == 2)
    {

    }
    else
    {
        throw new Exception("Invalid input");
    }


    LLogaria1.GetBankAccountInfo();
    Console.WriteLine("Enter Amount");
    string s1 = Console.ReadLine();
    int amount = int.Parse(s1);

    if (input == 1)
    {
        LLogaria1.Deposit(amount);
    }
    else if (input == 2) 
    {
        LLogaria1.Withdraw(amount);
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    LLogaria1.GetBankAccountInfo();
}
