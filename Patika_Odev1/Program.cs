
Console.WriteLine("Hello, World!");
{
    // 1 
    Console.WriteLine("Pozitif bir sayı giriniz");
    int n = 0;
    n = Convert.ToInt32(Console.ReadLine());    
    
    int[] pozitifsayi = new int[n];

    Console.WriteLine($"{n} adet pozitif sayı giriniz.");

    for(int i = 1; i<=n; i++)
    {
        Console.WriteLine($"{i}. sayıyı giriniz.");
        pozitifsayi[i-1]= Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Yazdığınız çift sayılar şunlardır :");

    foreach(int i2 in pozitifsayi)
    {
        if(i2 % 2 == 0)
        {
            Console.Write($"{i2} - ");
        }
    }

}

{
    // 2
    Console.WriteLine("Sizden 2 adet pozitif sayı girmenizi istiyoruz.");
    Console.WriteLine("1. Sayıyı giriniz");
    int n = 0, m = 0;
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("2. Sayıyı giriniz");
    m = Convert.ToInt32(Console.ReadLine());

    int[] pozitifsayi = new int[n];
    Console.WriteLine($"{n} adet sayı girmenizi istiyoruz");

    for(int i = 1; i<=n; i++)
    {
        Console.WriteLine($"{i}. sayıyı giriniz");
        pozitifsayi[i-1] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine($"Girdiğiniz sayılardan {m}'e bölünenler şunlardır: ");

    foreach(int i2 in pozitifsayi)
    {
        if(i2 % m == 0)
        {
            Console.Write($" - {i2}");
        }
    }

}

{
    // 3
    Console.WriteLine("Bir pozitif sayı giriniz.");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{n} adet kelime giriniz");
    string[] kelime = new string[n];

    for(int i = 1; i<=n; i++)
    {
        Console.WriteLine($"{i}. kelimeyi giriniz.");
        kelime[i-1] = Console.ReadLine().ToString();
    }

    Console.WriteLine("Girdiğiniz kelimlerin sondan başa sıralaması şu şekildedir: ");
    Array.Reverse(kelime); //dizinin elemanlarını sondan başa şeklinde ters çevirir.
    foreach (string i2 in kelime)
    {
        Console.Write($"{i2} ");
    }

}


{
    // 4
    Console.WriteLine("Bir cümle giriniz.");
    string cümle = Console.ReadLine().ToString();
    int adetbosluk = 0, adetharf = 0;

    for(int i = 0; i<cümle.Length; i++)
    {
        adetharf++;
        if(cümle[i] == ' ')
        {
            adetbosluk++;
            adetharf--;
        }
    }

    Console.WriteLine($"Girdiğiniz cümlede  kelime sayısı {adetbosluk + 1} ");
    Console.WriteLine($"Girdiğiniz cümlede harf sayısı {adetharf } ");

}
