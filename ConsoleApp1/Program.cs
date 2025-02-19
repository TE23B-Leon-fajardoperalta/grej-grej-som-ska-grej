static void stats(float energi, float guldmynt, float jobb)
{

    Console.WriteLine($"Energi: {energi}");
    Console.WriteLine($"Guld: {guldmynt}");
    Console.WriteLine($"Kraft: {jobb}");
}


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
static void shopper()
{
    List<string> potential = ["eld", "vind", "vatten", "jord"];
    List<string> potentialen = [];

    int wow = Random.Shared.Next(4);

    potentialen.Add(potential[wow]);
    potential.RemoveAt(wow);


    for (int i = 0; i < potentialen.Count; i++)
    {
        Console.WriteLine(potentialen[i]);
    }
}






















Console.WriteLine("Your wake.");
Console.WriteLine("Actions Listed below");

float energi = 0;
float energimax = 5;
float guldmynt = 0;
float guldmax = 20;
float jobb = 1;
float kraft = 1;

List<string> hund = ["1 Workmax", "2 Restmax", "3 Shopmax"];
List<int> hundint = [1, 2, 3];


for (int i = 0; i < hund.Count; i++)
{
    Console.WriteLine(hund[i]);
}

int ut = 0;


while (ut == 0)
{
    string las = Console.ReadLine();
    ut = 0;
    int.TryParse(las, out ut);
    if (ut == 1)
    {
        if (energi <= 0)
        {
            Console.WriteLine("((LIMIT!!!))");
        }
        else if (guldmynt >= guldmax)
        {
            guldmynt = guldmax;
        }
        else
        {
            energi = energi - kraft;
            guldmynt = guldmynt + kraft;
        }

        stats(energi, guldmynt, jobb);
    }
    if (ut == 2)
    {
        if (energi >= energimax)
        {
            energi = energimax;
            Console.WriteLine("((LIMIT!!!))");
        }
        else if (energi < -1)
        {
            energi = 0;
        }
        else
        {
            energi = energi + kraft;
        }

        stats(energi, guldmynt, jobb);
    }
    if (ut == 3)
    {
        if (guldmynt != guldmax)
        {
            Console.WriteLine("((LIMIT!!!))");

        }
        else
        {

            shopper();
            guldmynt = 0;
            kraft = kraft * 2;
        }
    }
    ut = 0;
}

Console.ReadLine();