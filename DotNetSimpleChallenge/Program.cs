﻿using DotNetSimpleChallenge.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal pricePerHour = 0;

Console.WriteLine("Welcome to the parking system!\n" +
                  "Enter the initial price:");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Now enter the price per hour:");
pricePerHour = Convert.ToDecimal(Console.ReadLine());

Parking parking = new Parking(initialPrice, pricePerHour);

string option = string.Empty;
bool showMenu = true;

// Loop for the menu
while (showMenu)
{
  Console.Clear();
  Console.WriteLine("Enter your option:");
  Console.WriteLine("1 - Register vehicle");
  Console.WriteLine("2 - Remove vehicle");
  Console.WriteLine("3 - List vehicles");
  Console.WriteLine("4 - Exit");

  switch (Console.ReadLine())
  {
    case "1":
      parking.AddVehicle();
      break;

    case "2":
      parking.RemoveVehicle();
      break;

    case "3":
      parking.ListVehicles();
      break;

    case "4":
      showMenu = false;
      break;

    default:
      Console.WriteLine("Invalid option");
      break;
  }

  Console.WriteLine("Press any key to continue");
  Console.ReadLine();
}

Console.WriteLine("The program has ended");
