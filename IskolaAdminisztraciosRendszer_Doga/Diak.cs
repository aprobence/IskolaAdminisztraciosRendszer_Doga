namespace IskolaAdminisztraciosRendszer_Doga;

internal class Diak
{
    //diák attribútumok
    public string Nev { get; set; }
    public string Osztaly { get; set; }
    public int Azonosito { get; set; }

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