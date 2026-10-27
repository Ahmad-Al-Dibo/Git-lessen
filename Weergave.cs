namespace Playlist;

public static class Weergave
{
    // 3:20
    public static string Duur(TimeSpan duur) =>
        $"{(int)duur.TotalMinutes}:{duur.Seconds:00}";
}
