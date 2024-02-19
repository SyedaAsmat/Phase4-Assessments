// See https://aka.ms/new-console-template for more information
using PlayerConApp;

Console.WriteLine("*** Welcome to ICC ***");
Console.WriteLine("All Players");
PlayerManangement pm = new PlayerManangement();
pm.GetData();

Console.WriteLine("\n*** Search Player By Id ***");
Console.Write("Enter player id: ");
int id = int.Parse(Console.ReadLine());
pm.GetById(id);
