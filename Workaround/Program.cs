using Business.Conctrete;
using Entities.Concrete;

class program
{


static void Main(string[] args)
{
    SelamVer(isim: "Engin");
    SelamVer(isim: "Alperen");
    SelamVer();
    SelamVer(isim: "Ayşe");
    int sonuc = Topla(1,2);

    // Diziler / Arrays

    string[] ogrenciler = new string[3];
    ogrenciler[0] = "Engin";
    ogrenciler[1] = "Alperen";
    ogrenciler[2] = "Diler";

    ogrenciler = new string[4];
    ogrenciler[3] = "aa";
    for (int i = 0; i < ogrenciler.Length; i++)
    {
        Console.WriteLine(ogrenciler[i]);
    }

    string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
    string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

    sehirler2 = sehirler1;
    sehirler1[0] = "Adana";
    Console.WriteLine(sehirler2[0]);

    Person person1 = new Person();
    person1.FirstName = "Alperen";
    person1.LastName = "Diler";
    person1.DateOfBirthYear = 2000;
    person1.NationalIdentity = 222;



    foreach (string sehir in sehirler1)
    {
        Console.WriteLine(sehir);
    }

    List<string> yeniSehirler1 = new List<string> { "Isparta 1", "İstanbul 1", "İzmir 1" };
    yeniSehirler1.Add(item: "Adana 1");
    foreach (var sehir in yeniSehirler1)
    {
        Console.WriteLine(sehir);
    }

    PttManager pttManager = new PttManager(new ForeignerManager());
    pttManager.GiveMask(person1);

}



static void SelamVer(string isim="isimsiz")
{
    Console.WriteLine("Merhaba" + isim);
}
static int Topla(int sayi1=5, int sayi2=10)
{
    int sonuc = sayi1+sayi2;
    Console.WriteLine("Toplam: " +sonuc.ToString());
    return sonuc;
}
}