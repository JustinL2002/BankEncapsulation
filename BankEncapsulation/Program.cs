using BankEncapsulation;
{
    BankAccount ba = new BankAccount();

    Console.WriteLine("How much money do you want to deposit?");

    double depositAmount = double.Parse(Console.ReadLine());

    ba.Deposit(depositAmount);
    double userBalance = ba.GetBalance();

    Console.WriteLine($"Your balance is {userBalance}");
}
