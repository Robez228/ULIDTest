using NUlid;
using NUlid.Rng;

namespace ULIDTest;

internal static class NulidTest
{



    public static void PrintMonotonicUlid(int n = 1)
    {
        if (n < 1)
        {
            return;
        }

        var rng = new MonotonicUlidRng();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(NUlid.Ulid.NewUlid(rng));
        }
    }

    public static void PrintUlid(int n = 1)
    {
        if (n < 1)
        {
            return;
        }

        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(NUlid.Ulid.NewUlid());
        }
    }
}
