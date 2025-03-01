using System;
using System.Collections.Generic;

namespace IskolaAdminisztraciosRendszer_Doga
{
    class Program
    {
        static void Main(string[] args)
        {
            Tantargy matematika = new Tantargy("Matematika", 4);
            Tantargy fizika = new Tantargy("Fizika", 3);
            Tantargy magyar = new Tantargy("Magyar", 5);

            Tanar tanarKovacs = new Tanar("Kovács János", new List<Tantargy> { matematika, fizika }, 1);
            Tanar tanarNagy = new Tanar("Nagy Éva", new List<Tantargy> { magyar }, 2);
            
            //Tanár tantárgyaihoz hozzáadása
            tanarKovacs.HozzaadTantargy(magyar);

            Diak diak1 = new Diak("Kiss Péter", "10.A", 101);
            Diak diak2 = new Diak("Nagy Anna", "10.A", 102);
            Diak diak3 = new Diak("Szabó Gábor", "10.A", 103);
            Diak diak4 = new Diak("Kovács Péter", "10.A", 104);
            Diak diak5 = new Diak("Kiss Anna", "10.A", 105);
            Diak diak6 = new Diak("Nagy Gábor", "10.A", 106);
            Diak diak7 = new Diak("Szabó Anna", "10.A", 107);
            Diak diak8 = new Diak("Kovács Gábor", "10.A", 108);
            Diak diak9 = new Diak("Kiss Gábor", "10.A", 109);
            Diak diak10 = new Diak("Nagy Péter", "10.A", 110);

            Osztaly osztaly10A = new Osztaly("10.A",
                new List<Diak> { diak1, diak2, diak3, diak4, diak5, diak6, diak7, diak8, diak9, diak10 }, tanarKovacs);

            osztaly10A.HozzaadDiak(diak1);
            osztaly10A.HozzaadDiak(diak2);
            osztaly10A.HozzaadDiak(diak3);
            osztaly10A.HozzaadDiak(diak4);
            osztaly10A.HozzaadDiak(diak5);
            osztaly10A.HozzaadDiak(diak6);
            osztaly10A.HozzaadDiak(diak7);
            osztaly10A.HozzaadDiak(diak8);
            osztaly10A.HozzaadDiak(diak9);
            osztaly10A.HozzaadDiak(diak10);
            Console.WriteLine("");

            Ertekeles ertekeles1 = new Ertekeles(diak1, matematika, 5);
            Ertekeles ertekeles2 = new Ertekeles(diak2, fizika, 4);
            Ertekeles ertekeles3 = new Ertekeles(diak3, magyar, 3);
            Ertekeles ertekeles4 = new Ertekeles(diak4, matematika, 5);
            Ertekeles ertekeles5 = new Ertekeles(diak5, fizika, 4);
            Ertekeles ertekeles6 = new Ertekeles(diak6, magyar, 3);
            Ertekeles ertekeles7 = new Ertekeles(diak7, matematika, 5);
            Ertekeles ertekeles8 = new Ertekeles(diak8, fizika, 4);
            Ertekeles ertekeles9 = new Ertekeles(diak9, magyar, 3);
            Ertekeles ertekeles10 = new Ertekeles(diak10, matematika, 5);

            Console.WriteLine(ertekeles1.JegyKiiras());
            Console.WriteLine(ertekeles2.JegyKiiras());
            Console.WriteLine(ertekeles3.JegyKiiras());
            Console.WriteLine(ertekeles4.JegyKiiras());
            Console.WriteLine(ertekeles5.JegyKiiras());
            Console.WriteLine(ertekeles6.JegyKiiras());
            Console.WriteLine(ertekeles7.JegyKiiras());
            Console.WriteLine(ertekeles8.JegyKiiras());
            Console.WriteLine(ertekeles9.JegyKiiras());
            Console.WriteLine(ertekeles10.JegyKiiras());
            Console.WriteLine("");

            osztaly10A.OsszesDiakListazasa();
            Console.WriteLine("");
            
            Console.WriteLine(tanarKovacs.OktatottTantargyak());
            Console.WriteLine(tanarNagy.OktatottTantargyak());
            Console.WriteLine("");

            Console.WriteLine(osztaly10A.OsztalyfonokKiirasa());
        }
    }
}