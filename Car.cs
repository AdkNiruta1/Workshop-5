// Derived class - car
public class Car : Vehicle
{
    public int Seats {get; set;}

    public override void DisplyaInfo()
    {
        base.DisplyaInfo();
        Console.WriteLine($"Seats: {Seats}");
        

    }
}