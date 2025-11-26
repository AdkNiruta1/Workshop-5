// derived class - motorcycle
public class Motorcycle : Vehicle
{
    public String Type {get; set;}

    public override void DisplyaInfo()
    {
        base.DisplyaInfo();
        {
            base.DisplyaInfo();
            Console.WriteLine($"Type: {Type}");
        }
    }
}