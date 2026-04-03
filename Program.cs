

Console.WriteLine($"Input Song");
Console.WriteLine("------------------");
Console.Write("Title: ");
string? judul = Console.ReadLine();

Console.Write("Play Count: ");
int playCount = 0;
try
{
    playCount = int.Parse(Console.ReadLine());
} catch (FormatException)
{
    Console.WriteLine("Invalid input for play count.");
} catch (OverflowException)
{
    Console.WriteLine("Play count is too large.");
}

Console.WriteLine("------------------");

Console.WriteLine();

var song = new SayaMusicTrack(judul ?? "Unknown Title");
song.IncreasePlayCount(playCount);

Console.WriteLine("Printed Song");
Console.WriteLine("------------------");
song.PrintTrackDetails();
    