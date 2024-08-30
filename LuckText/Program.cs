string name;

Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Cyan;
Console.Clear();

Console.WriteLine("Skriv in ditt namn: ");
name = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Blue;
// Console.WriteLine("Hello " + name + "!");
Console.WriteLine($"Hello {name}!");

Console.ReadLine();