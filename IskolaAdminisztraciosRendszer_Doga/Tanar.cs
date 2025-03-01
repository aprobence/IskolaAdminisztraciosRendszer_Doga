namespace IskolaAdminisztraciosRendszer_Doga;

internal class Tanar
{
    public string Nev { get; set; }
    public List<Tantargy> Tantargy { get; set; }
    public int TanarID { get; set; }

    public Tanar(string nev, List<Tantargy> tantargy, int tanarid)
    {
        Nev = nev;
        Tantargy = new List<Tantargy>();
        TanarID = tanarid;
    }
    public override string ToString()
    {
        return Nev;
    }

    public void HozzaadTantargy(Tantargy tantargy)
    {
        Tantargy.Add(tantargy);
    }

    public string OktatottTantargyak()
    {
        string tantargyak = "";
        foreach (var item in Tantargy)
        {
            item.TantargyAdatok();
        }
        return tantargyak;
    }
}