// Task 1

public class BankAccount
{
    private String accountNumber;
    private double balance;

    public String AccountNumber
    {
        get {return accountNumber;}
    }
    public double Balance
    {
        get {return balance;}
        private set
        {
            if (value >0)
            {
                balance = value;
            }
            else
            {
                Console.WriteLine("Balance must be greater than 0.");
            }
        }
    }

    // constructor
    public BankAccount(String accNumber, double initialBalance)
    {
        accountNumber = accNumber;
        Balance = initialBalance;
    }

    // method of deposit
    public void Deposit(double amount)
    {
        if (amount <=0)
        {
            Console.WriteLine("Deposit amount must be greater than 0.");

        }
        else
        {
            balance += amount;
            Console.WriteLine($"Successfully deposited {amount}. New balance:{balance}");
        }
    }

    // withdraw method
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be greater than 0.");

        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient balance!");

        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Successfully wwithdraw {amount}. Remaining balance: {balance}");
        }
    }

    
}