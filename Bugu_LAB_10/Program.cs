using System;

public class Program
{
    static void Main()
    {
        var garages = new Garage[5];
        for (int i = 0; i < garages.Length; i++)
        {
            garages[i] = new Garage($"Garage {i + 1}", 500);
        }

        var serializer = new MyJsonSerializer();

        LoadData(garages, serializer);

        var updateVehicles = new Vehicle[]
        {
            new Car("Car3", 60, 2.5, 3.5, 4, "Electric", 150),
            new Truck("Truck3", 60, 3.5, 7, 15000, 6, 100),
            new Motorcycle("Motorcycle3", 100, 1.2, 2.7, false, "Touring", 240)
        };

        AddUpdateVehicles(garages, updateVehicles, serializer);

        PrintAllGarages(garages, serializer);
    }

    static void LoadData(Garage[] garages, MyJsonSerializer serializer)
    {
        var dataGarages = serializer.Read("data.json");
        if (dataGarages != null)
        {
            for (int i = 0; i < garages.Length; i++)
            {
                if (i < dataGarages.Length)
                {
                    garages[i] = dataGarages[i];
                }
            }
        }
    }

    static void AddUpdateVehicles(Garage[] garages, Vehicle[] updateVehicles, MyJsonSerializer serializer)
    {
        var rand = new Random();
        foreach (var vehicle in updateVehicles)
        {
            var randomGarageIndex = rand.Next(garages.Length);
            garages[randomGarageIndex].AddVehicle(vehicle);
        }

        serializer.Write(garages, "update_data.json");
    }

    static void PrintAllGarages(Garage[] garages, MyJsonSerializer serializer)
    {
        foreach (var garage in garages)
        {
            Console.WriteLine($"Garage: {garage.Name}");
            Console.WriteLine($"Area: {garage.Area}");
            Console.WriteLine("Vehicles:");

            if (garage.Vehicles.Length > 0)
            {
                foreach (var vehicle in garage.Vehicles)
                {
                    Console.WriteLine(vehicle);
                }
            }
            else
            {
                Console.WriteLine("В этом гараже нет места!");
            }

            Console.WriteLine();
        }
    }
}
