namespace IskolaAdminisztraciosRendszer_Doga;

internal class Diak
{
    //diák attribútumok
    public static string Nev { get; private set; }
    public static string Osztaly { get; private set; }
    public static int Azonosito { get; private set; }

    public Diak(string nev, string osztaly, int azonosito)
    {
        Nev = nev;
        Osztaly = osztaly;
        Azonosito = azonosito;
    }

    public string TeljesNevKiiras()
    {
        return $"A diák neve és osztálya:{Nev}, {Osztaly}";
    }

}