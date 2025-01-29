Console.WriteLine("Your wake.");

float energi = 0;
float energimax = 5;
float guldmynt = 0;
float guldmax = 20;
float jobb = 1;
// grejer<int>[guldmynt,]

static bool jaslashnej()
{
    bool kolla = false;
    int suh = 0;
    while (kolla == false && suh < 1 || suh > 2)
    {
        string svar = Console.ReadLine();
        kolla = int.TryParse(svar, out suh);

        if (suh == 1)
        {
            return true;
        }
        if (suh == 2)
        {
            return false;
        }
        Console.ReadLine();

    }
    return false;
}

bool gordet = jaslashnej();

while (gordet == true && energi <= jobb)
{
    guldmynt = guldmynt + 2;
    if (guldmynt <= guldmax)
    {
        guldmynt == guldmax; 
    }
    Console.WriteLine(guldmynt);
}