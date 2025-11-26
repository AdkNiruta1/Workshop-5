// Task 5
//Derived class smartphone

class Smartphone: ElectronicDevice
{
    public Smartphone(String brand, double price): base(brand, price){}

    public void EnableCamera()
    {
        Console.WriteLine("Smartphone camera is enabled!");

    }

    public override void ShowInfo()
    {
        
       Console.WriteLine($"Smartphone Brand: {Brand}, Price: Rs. {Price}");

    }
}