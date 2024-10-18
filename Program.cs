
int dinaPengar = 100;

while (dinaPengar > 0)
    {
        Console.WriteLine($"du har {dinaPengar} kvar");


    Console.WriteLine("Vad vill du köpa?");
    Console.WriteLine("1. Ett ps4 (20 kr)");
    Console.WriteLine("2. Ett nintendo switch (15 kr)");
    Console.WriteLine("3. Ett X-box (20 kr)");

    string DetDuKöpt = "";

    while (DetDuKöpt != "1" && DetDuKöpt != "2" && DetDuKöpt !="3")
    {
        DetDuKöpt = Console.ReadLine();
    }


    int prispergrej = 0;
    
    if (DetDuKöpt == "1"){
        prispergrej = 20;
    }
    else if (DetDuKöpt == "2"){
        prispergrej = 15;
    }
    else if (DetDuKöpt == "3"){
        prispergrej = 20;
    }

    Console.WriteLine("Hur många vill du köpa");
    int HurMycketduvillköpa = 0;

    while (HurMycketduvillköpa == 0){
        string mängden = Console.ReadLine();
        bool success = int.TryParse(mängden,out HurMycketduvillköpa);
        if (success == false){
            Console.WriteLine("en siffra");
        }
    }

    int finalcost = HurMycketduvillköpa * prispergrej;

    if (finalcost <= dinaPengar){
        Console.WriteLine("okej");
        dinaPengar -= finalcost;
    }
    else {
        Console.WriteLine("nej du har inte nog med pengar");
    }
}


Console.WriteLine("Du har inga pengar kvar");
Console.ReadLine();