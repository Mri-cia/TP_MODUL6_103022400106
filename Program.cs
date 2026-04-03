

Console.WriteLine($"Input Song");
Console.WriteLine("------------------");
Console.Write("Title: ");
string? judul = Console.ReadLine();

Console.Write("Play Count: ");

if (!int.TryParse(Console.ReadLine(), out int playCount))
{
    Console.WriteLine("Invalid input for play count. Please enter a valid integer.");
}

Console.WriteLine("------------------");

Console.WriteLine();

var song = new SayaMusicTrack(judul ?? "Unknown Title");
song.IncreasePlayCount(playCount);

Console.WriteLine("Printed Song");
Console.WriteLine("------------------");
song.PrintTrackDetails();
    