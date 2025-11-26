// derived class - motorcycle
public class Motorcycle : Vehicle
{
    public string? Type { get; set; }


    public override void DisplyaInfo()
    {
        base.DisplyaInfo();
        {
            base.DisplyaInfo();
            Console.WriteLine($"Type: {Type}");
        }
    }
}