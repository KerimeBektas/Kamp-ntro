// See https://aka.ms/new-console-template for more information

using System;

Kurs kurs1 = new Kurs();
kurs1.KursAdı = "c#";
kurs1.Egitmen = "Engin Demiroğ";
kurs1.İzlenmeOrani = 68;


Kurs kurs2 = new Kurs();
kurs2.KursAdı = "Java";
kurs2.Egitmen = "Kerem Varış";
kurs2.İzlenmeOrani = 64;

Kurs kurs3 = new Kurs();
kurs3.KursAdı = "Phyton";
kurs3.Egitmen = "Berkay Bilgin";
kurs3.İzlenmeOrani = 80;



//Console.WriteLine(kurs1.KursAdı + " : " + kurs1.Egitmen);

Kurs[] kurslar= new Kurs[] {kurs1, kurs2, kurs3};

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdı + " : " + kurs.Egitmen);
}

//Console.WriteLine("Hello, World!");



class Kurs
{
    public string KursAdı { get; set; }

    public string Egitmen { get; set; }

    public int İzlenmeOrani { get; set; }

}