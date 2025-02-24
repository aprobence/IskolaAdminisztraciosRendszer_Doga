namespace IskolaAdminisztraciosRendszer_Doga;

internal class Tantargy
{
    public string Nev { get; set; }
    public int KontaktOrak { get; set; }

    public Tantargy(string nev, int kontaktorak)
    {
        Nev = nev;
        KontaktOrak = kontaktorak;
    }

    public string TantargyAdatok()
    {
        return $"Tantárgy neve, heti óraszáma: {Nev} {KontaktOrak}";
    }
}