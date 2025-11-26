// Task 5

using System;
using System.Collections.Generic;

class ElectronicsStore
{
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine(device.Brand + " added.");
    }

    public void RemoveDevice(ElectronicDevice device)
    {
        devices.Remove(device);
        Console.WriteLine(device.Brand + " removed.");
    }

    public void ShowAllDeviceDetails()
    {
        Console.WriteLine("\n--- All Device Details ---");

        foreach (var device in devices)
        {
            // polymorphism
            device.ShowInfo(); 

            // Downcasting for child specific methods
            if (device is Laptop laptop)
            {
                laptop.TurnOnBattery();
            }
            else if (device is Smartphone phone)
            {
                phone.EnableCamera();
            }

            Console.WriteLine();
        }
    }
}
