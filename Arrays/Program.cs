string[] students = new string[3] { "Kaan", "Berkay", "Engin" };
students = new string[4] { "", "", "", "" };
string[] students2 = { "Berkay", "Kaan", "Engin" };
//students2[3] = "BerkayV2";

//foreach (var student in students2)
//{
//    Console.WriteLine(student);
//}

string[,] regions = new string[5, 3]
{
    {"İstanbul","İzmit","Balıkesir" },
    {"Ankara","Konya","Kırıkkale" },
    {"Antalya","Adana","Mersin" },
    {"Rize","Trabzon","Samsun" },
    {"İzmir","Muğla","Manisa" }
};

// GetUpperBound -> çok boyutlu dizilerde ilgili boyutlara ulaşmayı sağlayan metottur.
for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i, j]);
    }
    Console.WriteLine("****");
}

Console.ReadLine();