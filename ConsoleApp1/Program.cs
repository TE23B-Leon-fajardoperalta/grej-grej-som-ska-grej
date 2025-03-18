static void stats(float energi, float guldmynt, float jobb)
{

    Console.WriteLine($"Energi: {energi}");
    Console.WriteLine($"Guld: {guldmynt}");
    Console.WriteLine($"Kraft: {jobb}");
}


static bool JaSlashNej()
{

    bool kolla = false;

    int suh = 0;
    Console.WriteLine("ja(1) eller nej(2)");
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

    }
    return false;
}
static string Shopper()
{
    List<string> potential = ["((Eld))", "((Vind))", "((Vatten))", "((Jord))"];
    List<string> potentialen = [];
// FIXA

    int wow = Random.Shared.Next(4);

    return potential[wow];


    potentialen.Add(potential[wow]);

    for (int i = 0; i < potentialen.Count; i++)
    {
        return potentialen[i];
    }
    return "wow";
}






















Console.WriteLine("Your wake.");
Console.WriteLine("Actions Listed below");
Console.WriteLine("get 20 gold & Shopmax");

float energi = 0;
float energimax = 5;
float guldmynt = 0;
float guldmax = 20;
float jobb = 1;
float kraft = 5;

List<string> hund = ["1 Workmax", "2 Restmax", "3 Shopmax"];
List<string> krukalist = [];
List<string> krukaköpt = [];

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
        else if (energi - kraft < 0)
        {
            energi = 0;
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
            Console.WriteLine("Elements:");
            for (int i = 0; i < krukaköpt.Count; i++)
            {
                Console.WriteLine(krukaköpt[i]);
            }
        }


        else
        {
            krukalist.Add(Shopper());

            for (int i = 0; i < krukalist.Count; i++)
            {
                Console.WriteLine(krukalist[i] + " Element"+ "."+ i);
            }

            guldmynt = 0;
            kraft = kraft * 2;


            int utomhus = 0;
            bool mhm = false;

            while (mhm != true || utomhus! < 0 && utomhus! > krukaköpt.Count)
            {

                Console.WriteLine("Which element");
                string inomhus = Console.ReadLine();
                mhm = int.TryParse(inomhus, out utomhus);

                if (utomhus > krukalist.Count-1)
                {
                    mhm = false;
                    Console.WriteLine("try igen");
                }
                else
                {
                    if (JaSlashNej() == true)
                    {
                        krukaköpt.Add(krukalist[utomhus]);
                        krukalist.RemoveAt(utomhus);
                        Console.WriteLine("U got " + krukaköpt.Last());
                        mhm = true;
                    }
                    else
                    {
                        Console.WriteLine("U left your element");
                    }
                }
            }

        }
    }

    ut = 0;
}

Console.ReadLine();