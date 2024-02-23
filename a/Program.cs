// See https://aka.ms/new-console-template for more information
using Busines.Concrete;
using Entities.Concrete;
using System;


SelamVer(isim: " Umut");
SelamVer(isim: " Ahmet");
SelamVer(isim: " Engin");
SelamVer();

int sonuc = Topla();

//Diziler /Arrays

//string ogrenci1 = "Engin";
//string ogrenci2 = "umut";
//string ogrenci3 = "Ahmet";
//Console.WriteLine(ogrenci1);
//Console.WriteLine(ogrenci2);
//Console.WriteLine(ogrenci3);

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "umut";
ogrenciler[2] = "Ahmet";

ogrenciler = new string[4];
ogrenciler[3] = "Berkay";
for (int i = 0; i < ogrenciler.Length; i++)
{
Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

    //örnek
    //int sayi1 = 10;
    //int sayi2 = 20;
    //sayi2 = sayi1;
    //sayi1 = 30;
    //Console.WriteLine(sayi2);

Person person1 = new Person();
person1.Firstname = "UMUT";
person1.Lastname = "KATAN";
person1.DateOfBirthDay = 2002;
person1.NationalIdenity = 66628327752;

//Person person2 = new Person();
//person2.firstname = "Murat";


foreach (string sehir in sehirler1)
{
Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
yeniSehirler1.Add("Adana1");
foreach (var sehir in yeniSehirler1)
{
Console.WriteLine(sehir);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();


static void SelamVer(string isim = "isimsiz")
{
Console.WriteLine("Merhaba" + isim);
}

static int Topla(int sayi1 = 5, int sayi2 = 10)
{
int sonuc = sayi1 + sayi2;
Console.WriteLine("Toplam : " + sonuc.ToString());
return sonuc;
}

        
    

    public class Vatandaş
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long tcNo { get; set; }


}