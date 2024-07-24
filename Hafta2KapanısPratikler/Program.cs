
//1
Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");



//2
string metin = "Merhaba dünya";
int sayi = 1881;
Console.WriteLine(metin + " " + sayi);



//3
Random rnd = new Random();
int rastgeleSayi = rnd.Next();
Console.WriteLine("Rastgele sayi: " + rastgeleSayi);



//4
Random rnd = new Random();
int rastgeleSayi = rnd.Next();
Console.WriteLine("Sayının 3'e bölümünden kalan: " + (rastgeleSayi % 3));


//5
Console.WriteLine("Yaşınızı giriniz: ");
int yas = Convert.ToInt32(Console.ReadLine());
if (yas < 18)
{
    Console.WriteLine("-");
}
else if (yas >= 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("yanlış giriş yaptınız");
}


//6
int i = 1;
while (i < 11)
{
    Console.WriteLine(i + " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.\"");
    i++;
}


//7
Console.WriteLine("1. metni giriniz:");
string metin1 = Console.ReadLine();
Console.WriteLine("2. metni giriniz:");
string metin2 = Console.ReadLine();

string metin3 = metin1;
metin1 = metin2;
metin2 = metin3;
Console.WriteLine(metin1 + " " + metin2);

//8
BenDegerDondurmem();
static void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}

//9
Console.WriteLine("1.sayi: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2.sayi: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(toplam(sayi1, sayi2));
static int toplam(int x, int y)
{
    return x + y;
}

//10

Console.WriteLine("True/False değerlerinden birisini giriniz: ");
bool girilenDeger = Convert.ToBoolean(Console.ReadLine());
string sonuc = StringIfade(girilenDeger);
Console.WriteLine("Girilen deger: " + girilenDeger + " " + sonuc);

static string StringIfade(bool deger)
{
    if (deger == true)
    {
        return "Doğru";
    }
    else { return "Yanlış"; }
}


//11

Console.WriteLine("1. Yaş girin: ");
int yas1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. Yaş girin: ");
int yas2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3. Yaş girin: ");
int yas3 = Convert.ToInt32(Console.ReadLine());

static int EnYasliBul(int x, int y, int z)
{
    if ((x > y) && (x > z))
    {
        int enYasli = x;
        return enYasli;
    }
    else if ((y > x) && (y > z))
    {
        int enYasli = y;
        return enYasli;

    }
    else
    {
        int enYasli = z;
        return enYasli;
    }
}

Console.WriteLine("En yaşlı kişinin yaşı:" + EnYasliBul(yas1, yas2, yas3));


//12


static int EnBuyukBul()
{
    int enBuyuk = int.MinValue;
    string girdi;
    Console.WriteLine("Sayıları girin (Çıkmak için exit yazın):");
    while (true)
    {
        girdi = Console.ReadLine();
        if (girdi.ToLower() == "exit")
        {
            break;
        }
        if (int.TryParse(girdi, out int sayi))
        {
            if (sayi > enBuyuk)
            {
                enBuyuk = sayi;
            }

        }
        else
        {
            Console.WriteLine("geçersiz giriş bir sayi girin veya çıkmak için exit yazın");
        }
    }
    return enBuyuk;
}
int enBuyukSayiBul = EnBuyukBul();
Console.WriteLine(enBuyukSayiBul);

//13

Console.WriteLine("1.İsim: ");
string isim1 = Console.ReadLine();
Console.WriteLine("2.İsim");
string isim2 = Console.ReadLine();
yerDegistir(isim1, isim2);

static void yerDegistir(string isim1, string isim2)
{
    string isim3 = isim1;
    isim1 = isim2;
    isim2 = isim3;
    Console.WriteLine(isim1 + " " + isim2);
}

//14

Console.WriteLine("Sayıyı giriniz, sayi çiftse true tekse false yazdırılacaktır:");

int sayi = int.Parse(Console.ReadLine());
Console.WriteLine(TekCift(sayi));
static bool TekCift(int sayi)
{
    if (sayi % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//15

Console.WriteLine("Hızınızı giriniz: ");
int hız = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Zamanı giriniz giriniz: ");
int zaman = Convert.ToInt32(Console.ReadLine());
KmHesapla(hız, zaman);
static void KmHesapla(int hız, int zaman)
{
    int km = hız * zaman;
    Console.WriteLine($"Gidilen hız: {hız}, Gidilen zaman: {zaman}, Toplam gidilen mesafe {km} km");
}

//16
Console.WriteLine("Dairenin yarıçapını giriniz: ");
double yaricap = Convert.ToDouble(Console.ReadLine());
DaireAlanHesapla(yaricap);
static void DaireAlanHesapla(double yaricap)
{
    double pi = 3.14;

    double daireAlan = pi * (yaricap * yaricap);
    Console.WriteLine($"Dairenin yarıçapı {yaricap}, dairenin alanı ise {daireAlan}");
}

//17

lower("Zaman bir GeRi SayIm");
upper("Zaman bir GeRi SayIm");
static void lower(string text)
{
    text = text.ToLower();
    Console.WriteLine(text);
}
static void upper(string text) { text = text.ToUpper(); Console.WriteLine(text); }


//18

string text = "    Selamlar   ";
text = text.Trim();
Console.WriteLine(text);