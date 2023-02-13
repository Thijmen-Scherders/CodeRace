Console.WriteLine("Welkom op het start punt");
Console.WriteLine("In de tempel hiervoor je ligt een diamant die je kan stelen.");
Console.WriteLine("Jij en je beste vriend hebben besloten de diamant te stelen en te verkopen");
Console.WriteLine("Gaat het jou lukken om jezelf en je vriend te helpen?");
Console.WriteLine("Maak je keuze ga je links of rechts");


// Prompt the user for a choice
Console.Write("> ");
string routeChoice = Console.ReadLine();

// Ask player which room they want to go to
if (routeChoice == "links")
{
    Console.WriteLine("Jij en je vriend besluiten om links te gaan");
    Console.WriteLine("Na een tijdje lopen kom je in een kamer met een raadsel");
    Console.WriteLine("Durf jij hem optelossen ja of nee?");

    // Prompt the user for a choice
    Console.Write("> ");
    string leftChoice = Console.ReadLine();

    if (leftChoice == "ja")
    {
        Console.WriteLine("Het raadsel luid als volgt");
        Console.WriteLine("Je ziet het niet maar is het altijd");
        Console.WriteLine("Kies uit flamingo of vleermuis");
    }
    else if (leftChoice == "nee")
    {
        Console.WriteLine("De deuren sluiten en je valt in een gat");
        Console.WriteLine("Je overleeft het net maar kan niet meer bewegen");
        Console.WriteLine("Na een tijdje overlijd je aan je verwondingen");
    }
    else
    {
        Console.WriteLine("Invalid choice. Please answer ja or no.");
    }
    }
    else if (routeChoice == "rechts")
    {
    Console.WriteLine("Je komt aan in een kamer met een puzzel");
    Console.WriteLine("Durf jij hem op te lossen");
   

    // Prompt the user for a choice
    Console.Write("> ");
    string rightChoice = Console.ReadLine();

    if (rightChoice == "ja")
    {
        Console.WriteLine("de puzzel gaat als volgt");
        Console.WriteLine("Er zijn twee knoppen op de muur");
        Console.WriteLine("Hoe druk je ze in");
        Console.WriteLine("een voor een of tegelijk");
    }
    else if (rightChoice == "nee")
    {
        Console.WriteLine("Er komt een gat in het dak");
        Console.WriteLine("Daaruit valt een kei recht op");
        Console.WriteLine("Je bent dood");
    }
    Console.Write("> ");
    string RaadselChoice = Console.ReadLine();

    if (RaadselChoice == "vleermuis")
    {
        Console.WriteLine("Je komt uit in de eind kamer");
        Console.WriteLine("De diamant ligt voor je pak je hem?");
    }
    else if (RaadselChoice == "flamingo")
    {
        Console.WriteLine("De deuren sluiten en je valt in een gat");
        Console.WriteLine("Je overleeft het net maar kan niet meer bewegen");
        Console.WriteLine("Na een tijdje overlijd je aan je verwondingen");
    }

    else
    {
        Console.WriteLine("Invalid choice. Please answer yes or no.");
    }
}
else
{
    Console.WriteLine("foute keuze. Please answer links or rechts.");
}
