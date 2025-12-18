using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace DroneRace;

class Program
{
    static async Task DeliverPackageAsync(string DroneModel, string destination, int travelTimeSeconds)
    {
        Console.WriteLine($"[{DroneModel}] Initializing delivery to {destination}");
        //simulate travel time 
        await Task.Delay(travelTimeSeconds*1000);
        Console.WriteLine($"[{DroneModel}] Completed delivery to: {destination}");
    }
    static async Task Main(string[] args)
    {
        Console.WriteLine("Drone delivery simulation started, good luck Amazon.\n");
        var deliveries = new List<Task>
        {
            DeliverPackageAsync("Drone1", "Downtown",4),
            DeliverPackageAsync("Drone2", "Airport",15),
            DeliverPackageAsync("Drone3", "Harbor",10),
        };
    await Task.WhenAll(deliveries);
    Console.WriteLine("\n All deliveries completed");
        
        













    }
}
