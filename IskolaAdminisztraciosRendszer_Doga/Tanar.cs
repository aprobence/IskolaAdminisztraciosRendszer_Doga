namespace IskolaAdminisztraciosRendszer_Doga;

internal class Tanar
{
    public string Nev { get; set; }
    public List<Tantargy> Tantargyak { get; set; }
    public int TanarID { get; set; }

    public Tanar(string nev, List<Tantargy> tantargyak, int tanarid)
    {
        Nev = nev;
        Tantargyak = tantargyak;
        TanarID = tanarid;
    }
    public override string ToString()
    {
        return Nev;
    }

    public void HozzaadTantargy(Tantargy tantargy)
    {
        Tantargyak.Add(tantargy);
    }

    
    public string OktatottTantargyak()
    {
        if (Tantargyak == null || Tantargyak.Count == 0)
        {
            return $"{Nev} nem oktat tantárgyakat.";
        }

        return $"{Nev} által oktatott tantárgyak: " + string.Join(", ", Tantargyak.Select(t => t.Nev));
    }
}