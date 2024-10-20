namespace DotNetSimpleChallenge.Models
{
  public class Parking
  {
    private decimal initialPrice = 0;
    private decimal pricePerHour = 0;
    private List<string> vehicles = new List<string>();

    public Parking(decimal initialPrice, decimal pricePerHour)
    {
      this.initialPrice = initialPrice;
      this.pricePerHour = pricePerHour;
    }

    public void AddVehicle()
    {
      Console.WriteLine("Enter the license plate of the vehicle to park:");
      string? plate = Console.ReadLine();
      if(!String.IsNullOrEmpty(plate)) {
        vehicles.Add(plate);
        Console.WriteLine($"Vehicle {plate} added successfully!");
      }
    }

    public void RemoveVehicle()
    {
      Console.WriteLine("Enter the license plate of the vehicle to remove:");
      string? plate = Console.ReadLine();

      if (vehicles.Any(x => x.ToUpper() == plate?.ToUpper()) && !String.IsNullOrEmpty(plate))
      {
        Console.WriteLine("Enter the number of hours the vehicle was parked:");
        string? hours = Console.ReadLine();
        if(!String.IsNullOrEmpty(hours)) {
          decimal totalValue = initialPrice + pricePerHour * int.Parse(hours);

          vehicles.Remove(plate);
          Console.WriteLine($"The vehicle {plate} was removed and the total price was: R$ {totalValue}");
        }
      }
      else
      {
        Console.WriteLine("Sorry, this vehicle is not parked here. Please check if you entered the license plate correctly.");
      }
    }

    public void ListVehicles()
    {
      if (vehicles.Any())
      {
        Console.WriteLine("The parked vehicles are:");
        foreach (var vehicle in vehicles)
        {
          Console.WriteLine($" - {vehicle}");
        }
      }
      else
      {
        Console.WriteLine("There are no parked vehicles.");
      }
    }
  }
}
