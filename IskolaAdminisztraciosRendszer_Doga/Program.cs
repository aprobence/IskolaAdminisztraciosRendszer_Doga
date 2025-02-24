namespace IskolaAdminisztraciosRendszer_Doga;

class Program
{
    static void Main(string[] args)
    {
        bool fut = true;
        while (fut=true)
        {
            Console.WriteLine("1. Diák nevének és osztályának kiírása");
            Console.WriteLine("2. Tantárgy hozzáadása a tanár listájához");
            Console.WriteLine("3. A tanár által oktatott tantárgyak kiírása");
            Console.WriteLine("4. A tantárgy neve és heti óraszám megtekintése");
            Console.WriteLine("5. Diák hozzáadása a listához");
            Console.WriteLine("6. Diákok megtekintése");
            Console.WriteLine("7. Az osztályfőnök neve és tantárgya megtekintése");
            Console.WriteLine("8. Jegy kiírása");
            Console.WriteLine("9. Kilépés");
            Console.WriteLine("Válasszon menüpontot: ");
            int valasztas = Convert.ToInt32(Console.ReadLine());

            switch (valasztas)
            {
                case 1:
						Console.Clear();
						Console.WriteLine("Adja meg a diák nevét: ");
						string nev = Console.ReadLine();
						Console.WriteLine("Adja meg a diák osztályát: ");
						string osztaly = Console.ReadLine();
						Console.WriteLine("Adja meg a diák azonosítóját: ");
						int azonosito = Convert.ToInt32(Console.ReadLine());
						Diak diak = new Diak(nev, osztaly, azonosito);
						Console.WriteLine(diak.TeljesNevKiiras());
						break;
					case 2:
						Console.Clear();
						Console.WriteLine("Adja meg a tanár nevét: ");
						string tanarNev = Console.ReadLine();
						Console.WriteLine("Adja meg a tantárgy nevét: ");
						string tantargyNev = Console.ReadLine();
						Tanar tanar = new Tanar(tanarNev);
						Tantargy tantargy = new Tantargy(tantargyNev, 2);
						tanar.HozzaadTantargy(tantargy);
						break;
					case 3:
						Console.Clear();
						Console.WriteLine("Adja meg a tanár nevét: ");
						string tanarNev2 = Console.ReadLine();
						Tanar tanar2 = new Tanar(tanarNev2);
						Console.WriteLine(tanar2.OktatottTantargyak());
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("Adja meg a tantárgy nevét: ");
						string tantargyNev2 = Console.ReadLine();
						Tantargy tantargy2 = new Tantargy(tantargyNev2, 2);
						Console.WriteLine(tantargy2.TantargyAdatok());
						break;
					case 5:
						Console.Clear();
						Console.WriteLine("Adja meg a diák nevét: ");
						string nev2 = Console.ReadLine();
						Console.WriteLine("Adja meg a diák osztályát: ");
						string osztaly2 = Console.ReadLine();
						Console.WriteLine("Adja meg a diák azonosítóját: ");
						int azonosito2 = Convert.ToInt32(Console.ReadLine());
						Diak diak2 = new Diak(nev2, osztaly2, azonosito2);
						Console.WriteLine(diak2.TeljesNevKiiras());
						break;
					case 6:
						Console.Clear();
						Console.WriteLine("Adja meg a diák nevét: ");
						string nev3 = Console.ReadLine();
						Console.WriteLine("Adja meg a diák osztályát: ");
						string osztaly3 = Console.ReadLine();
						Console.WriteLine("Adja meg a diák azonosítóját: ");
						int azonosito3 = Convert.ToInt32(Console.ReadLine());
						Diak diak3 = new Diak(nev3, osztaly3, azonosito3);
						Console.WriteLine(diak3.TeljesNevKiiras());
						break;
					case 7:
						Console.Clear();
						Console.WriteLine("Adja meg az osztály nevét: ");
						string osztalyNev = Console.ReadLine();
						Console.WriteLine("Adja meg az osztályfőnök nevét: ");
						string osztalyfonokNev = Console.ReadLine();
						Tanar osztalyfonok = new Tanar(osztalyfonokNev);
						Osztaly osztaaly = new Osztaly(osztalyNev, osztalyfonok);
						Console.WriteLine(osztaaly.OsztalyfonokKiirasa());
						break;
					case 8:
						Console.Clear();
						Console.WriteLine("Adja meg a diák nevét: ");
						string nev4 = Console.ReadLine();
						Console.WriteLine("Adja meg a diák osztályát: ");
						string osztaly4 = Console.ReadLine();
						Console.WriteLine("Adja meg a diák azonosítóját: ");
						int azonosito4 = Convert.ToInt32(Console.ReadLine());
						Diak diak4 = new Diak(nev4, osztaly4, azonosito4);
						Console.WriteLine(diak4.TeljesNevKiiras());
						break;
					case 9:
						Console.Clear(); 
						Console.WriteLine("Kilépés...");
						fut = false;
						break;
					default:
                        Console.Clear();
                        Console.WriteLine("Rossz számot adtál meg, próbáld újra!");
						valasztas = Convert.ToInt32(Console.ReadLine());
						break;
            }
        }
    }
}