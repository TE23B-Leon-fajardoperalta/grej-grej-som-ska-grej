Console.WriteLine("Your wake.");
// grejer<int>[guldmynt,]
    float energi = 0;
    float energimax = 5;
    float guldmynt = 0;
    float guldmax = 20;
    float jobb = 1;

static bool jaslashnej()
{

    bool kolla = false;

    int suh = 0;
    while (kolla == false && suh < 1 || suh > 2)
    {

        string svar = Console.ReadLine();
        kolla = int.TryParse(svar, out suh);
        Console.WriteLine("skriv igen");
        if (suh == 1)
        {
            return true;
        }
        if (suh == 2)
        {
            return false;
        }

    }
    return false;
}
static void stats(float energi, float guldmynt, float jobb)
{

    Console.WriteLine($"Energi: {energi}");
    Console.WriteLine($"Guld: {guldmynt}");
    Console.WriteLine($"Kraft: {jobb}");
}

bool hopp = jaslashnej();
