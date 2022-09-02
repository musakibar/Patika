using System.Collections;


Console.WriteLine("Cümle Giriniz.");
string sentence = Console.ReadLine().ToLower();

List<char> sesliHarfler = new List<char>();

List<char> vowels = new List<char>() {'a','e','i','o','u' };

for (int i = 0; i < sentence.Length; i++)
{
    if (vowels.Contains(sentence[i]))
    {
        sesliHarfler.Add(sentence[i]);
    }
}

foreach (var item in sesliHarfler)
{
    Console.WriteLine(item);
}
