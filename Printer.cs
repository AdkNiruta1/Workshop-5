// Task 3 method overloading

using System;

public class Printer
{
    // printing the String
    public void Print(String message)
    {
        Console.WriteLine("Message:" + message);

    }

    // printing integer

    public void Print(int number)
    {
        Console.WriteLine("Number:" + number);
    }

    // printing String multiple times

    public void Print(String message, int count)
    {
        for (int i = 0; i< count; i++)
        {
            Console.WriteLine(message);
        }
    }


}

