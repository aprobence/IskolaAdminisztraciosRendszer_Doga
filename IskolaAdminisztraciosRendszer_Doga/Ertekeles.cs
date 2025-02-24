namespace IskolaAdminisztraciosRendszer_Doga;

internal class Ertekeles
{
    public Diak Diak { get; set; }
    public Tantargy Tantargy { get; set; }
    public int Erdemjegy { get; set; }

    public Ertekeles(Diak diak, Tantargy tantargy, int erdemjegy)
    {
        Diak = diak;
        Tantargy = tantargy;
        Erdemjegy = erdemjegy;
    }

    public string JegyKiiras()
    {
        return $"A diák neve: {Diak}\nTantargy: {Tantargy}\nA tanuló érdemjegye: {Erdemjegy}";
    }
}