using SDKC2;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Beverage>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var beverage = new Beverage();
   
    Console.WriteLine("Creating a beverage...");

    Console.Write("What is the name of the beverage? ");
    Beverage.Name = Console.ReadLine();

    Console.Write("Is the beverage coffee? ");
    Beverage.Coffee = Console.ReadLine();

    Console.Write("Briefly describe the beverage ");
    Beverage.Description = Console.ReadLine();

    Console.Write("What does the beverage cost?");
    Beverage.Price = decimal.Parse(Console.ReadLine());

    Console.Write("How many beverages are you adding? ");
    Beverage.Quantity = int.Parse(Console.ReadLine());

    Console.WriteLine("Added a beverage");
    
    recordList.Add(item: Beverage);

    }
public override string ToString();

// Print out the list of records using Console.WriteLine()