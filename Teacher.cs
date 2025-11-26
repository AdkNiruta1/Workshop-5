// Task 3 part 2


public class Teacher
{
    public String Name {get; set;}

    public virtual void Teaching()
    {
        Console.WriteLine("EnglishTeacher teaches  English subject.");

    }

    public void SalaryInfo()
    {
        Console.WriteLine("The Teacher salary is fixed as per government rules.");
    }
}