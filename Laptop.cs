// Task 5
// Derived class Laptop

public class Laptop : ElectronicDevice
{
    public Laptop(string brand, double price) : base(brand, price)
    {
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Laptop Brand: {Brand}");
        Console.WriteLine($"Laptop Price: {Price}");
    }

    public void TurnOnBattery()
    {
        Console.WriteLine("Laptop battery turned on.");
    }
}
