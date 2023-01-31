// See https://aka.ms/new-console-template for more information


string kurs1 = "Yazılım yetiştirme";
string kurs2 = "Programlama";
string kurs3 = "Java";

Console.WriteLine(kurs1);
Console.WriteLine(kurs2);
Console.WriteLine(kurs3);

// array - dizi

string[] kurslar = new string[] { "Yazılım yetiştirme","Programlama","Java","Python" };





for (int i = 0; i <kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}


foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("Sayfa Sonu - footer");