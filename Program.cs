int dinaPengar = 100;

while (dinaPengar > 0)
{
    Console.WriteLine($"du har {dinaPengar} kvar");
}


Console.WriteLine("Vad vill du köpa?");
Console.WriteLine("1. Ett ps4 (20 kr)");
Console.WriteLine("2. Ett nintendo switch (15 kr)");
Console.WriteLine("3. Ett X-box (20 kr)");

string DetDuKöpt = "";

while (DetDuKöpt != "1" && DetDuKöpt != "2" && DetDuKöpt !="3")
{
    DetDuKöpt = Console.ReadLine();
}


