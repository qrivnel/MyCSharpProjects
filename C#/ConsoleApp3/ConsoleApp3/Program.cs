using System;

class Personel
{
    public string ad;
    public string soyad;
    public int sicilNo;
    public double maas;

    public Personel(string ad, string soyad, int sicilNo, double maas)
    {
        this.ad = ad;
        this.soyad = soyad;
        this.sicilNo = sicilNo;
        this.maas = maas;
    }
}

class Node
{
    public Personel veri;
    public Node sonraki;

    public Node(Personel veri)
    {
        this.veri = veri;
        this.sonraki = null;
    }
}

class BagliListe
{
    private Node baslangic;

    public BagliListe()
    {
        this.baslangic = null;
    }

    public void ElemanEkle(Personel veri)
    {
        Node yeni = new Node(veri);

        if (baslangic == null)
        {
            baslangic = yeni;
        }
        else
        {
            Node sonraki = baslangic;
            while (sonraki.sonraki != null)
            {
                sonraki = sonraki.sonraki;
            }
            sonraki.sonraki = yeni;
        }
    }

    public void ElemanYazdir()
    {
        Node gecici = baslangic;
        while (gecici != null)
        {
            Console.WriteLine(gecici.veri.ad + " " + gecici.veri.soyad + " " + gecici.veri.sicilNo + " " + gecici.veri.maas);
            gecici = gecici.sonraki;
        }
    }

    public Node ElemanAra(int sicilNo)
    {
        Node gecici = baslangic;
        while (gecici != null)
        {
            if (gecici.veri.sicilNo == sicilNo)
            {
                return gecici;
            }
            gecici = gecici.sonraki;
        }
        return null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BagliListe liste = new BagliListe();

        Personel personel1 = new Personel("Ali", "Yılmaz", 1001, 3000.0);
        Personel personel2 = new Personel("Ayşe", "Demir", 1002, 3500.0);
        Personel personel3 = new Personel("Mehmet", "Kara", 1003, 4000.0);

        liste.ElemanEkle(personel1);
        liste.ElemanEkle(personel2);
        liste.ElemanEkle(personel3);

        Console.WriteLine("Personeller:");
        liste.ElemanYazdir();

        Console.WriteLine();

        int arananSicilNo = 1002;
        Node bulunanNode = liste.ElemanAra(arananSicilNo);
        if (bulunanNode != null)
        {
            Console.WriteLine(arananSicilNo + " sicil numaralı personel bulundu:");
            Console.WriteLine(bulunanNode.veri.ad + " " + bulunanNode.veri.soyad + " " + bulunanNode.veri.sicilNo + " " + bulunanNode.veri.maas);
        }
        else
        {
            Console.WriteLine(arananSicilNo + " sicil numaralı personel bulunamadı.");
        }
        Console.ReadKey();
    }
}
