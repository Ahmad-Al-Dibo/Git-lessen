namespace Playlist;

public static class PlaylistLader
{
    // Leest alle .txt-bestanden in de map. Lege regels en regels die met # beginnen worden overgeslagen.
    public static List<Nummer> LaadUitMap(string map)
    {
        var nummers = new List<Nummer>();

        foreach (var bestand in Directory.GetFiles(map, "*.txt").Order())
        {
            foreach (var regel in File.ReadLines(bestand))
            {
                if (string.IsNullOrWhiteSpace(regel) || regel.TrimStart().StartsWith('#'))
                    continue;

                if (Nummer.TryParse(regel, out var nummer))
                    nummers.Add(nummer!);
                else
                    Console.WriteLine($"Let op: regel overgeslagen in {Path.GetFileName(bestand)}: '{regel}'");
            }
        }

        return nummers;
    }
}
