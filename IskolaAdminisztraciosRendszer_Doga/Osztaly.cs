namespace IskolaAdminisztraciosRendszer_Doga;

internal class Osztaly
{
    public string Nev { get; set; }
    public List<Diak> Diakok { get; set; }
    public Tanar Osztalyfonok { get; set; }

    public Osztaly(string nev, List<Diak> diakok, Tanar osztalyfonok)
    {
        Nev = nev;
        Diakok = diakok;
        Osztalyfonok = osztalyfonok;
    }

    public void HozzaadDiak(Diak diak)
    {
        if (Diakok.Count < 25)
        {
            Diakok.Add(diak);
        }
        else
        {
            Console.WriteLine("Nem lehet több diákot hozzáadni az osztályhoz");
        }
    }

    public void OsszesDiakListazasa()
    {
        foreach (var diak in Diakok)
        {
            Console.WriteLine(diak.TeljesNevKiiras());
        }
    }

    public string OsztalyfonokKiirasa()
    {
        return $"Az osztályfőnök neve: {Osztalyfonok}\nAz osztályfőnök tantárgyai: {Osztalyfonok.OktatottTantargyak()}";
    }
}