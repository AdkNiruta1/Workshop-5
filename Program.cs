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

        // Task 2 inheritance

        // creating the car objects
        Car myCar = new Car();
        myCar.Brand = "Nexon";
        myCar.Speed = 120;
        myCar.Seats = 5;

        // creating the motorcycle object

        Motorcycle myBike = new Motorcycle();
        myBike.Brand = "Yamaha";
        myBike.Speed = 200;
        myBike.Type = "Sports";

        Console.WriteLine("\n===Motorcycle info ===");
        myBike.Start();
        myBike.DisplyaInfo();
        myBike.Stop();

// Task 3 Polymorphism
Console.WriteLine("=== Printer Methods ===");
Printer p = new Printer();

p.Print("Hello Niru!");
p.Print(1234);
p.Print("Repeated Message", 3);

// part 2 of polymorphism
Console.WriteLine("\n=== Teacher Classes ===");

// Nepali teacher
NepaliTeacher nt = new NepaliTeacher();
nt.Name = "Monika";
Console.WriteLine("Nepali Teacher Name:" + nt.Name);
nt.Teaching();
nt.SalaryInfo();

// English teacher

EnglishTeacher et = new EnglishTeacher();
et.Name = "Naxal";
Console.WriteLine("\nEnglish Teacher Name:" + et.Name);
et.Teaching();
et.SalaryInfo();





        

    }
}