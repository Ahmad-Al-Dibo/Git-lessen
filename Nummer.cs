using System.Globalization;

namespace Playlist;

public record Nummer(string Titel, string Artiest, TimeSpan Duur)
{
    // Eén nummer per regel: Titel;Artiest;m:ss
    public static bool TryParse(string regel, out Nummer? nummer)
    {
        nummer = null;
        var delen = regel.Split(';');
        if (delen.Length != 3)
            return false;

        if (!TimeSpan.TryParseExact(delen[2].Trim(), @"m\:ss", CultureInfo.InvariantCulture, out var duur))
            return false;

        nummer = new Nummer(delen[0].Trim(), delen[1].Trim(), duur);
        return true;
    }
}
