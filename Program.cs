class Program
{
    static void Main(String[] args)
    {
        // creating bank account object
        BankAccount myAcc = new BankAccount("ACC145", 10000);

        // displyaing account number
        Console.WriteLine("Account Number:" + myAcc.AccountNumber);
        Console.WriteLine("Initial Balance:" + myAcc.Balance);


        // deposit money
        myAcc.Deposit(5000);

        // withdrawing money
        myAcc.Withdraw(3000);

        // printing the remaining balance
        Console.WriteLine("Final Balance:" + myAcc.Balance);

    }
}