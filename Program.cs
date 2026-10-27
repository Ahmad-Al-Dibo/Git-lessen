using Playlist;

Console.WriteLine("Welkom bij Playlist, de playlist van de klas");
Console.WriteLine();

var mapMetNummers = Path.Combine(AppContext.BaseDirectory, "data", "nummers");
var nummers = PlaylistLader.LaadUitMap(mapMetNummers);

foreach (var nummer in nummers)
{
    Console.WriteLine($"{nummer.Titel} - {nummer.Artiest} ({Weergave.Duur(nummer.Duur)})");
}

Console.WriteLine();

var totaal = TimeSpan.FromSeconds(nummers.Sum(n => n.Duur.TotalSeconds));
Console.WriteLine($"Totale duur: {Weergave.Duur(totaal)}");
