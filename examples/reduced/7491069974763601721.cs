// Generated by Fuzzlyn on 2018-06-18 21:44:37
// Seed: 7491069974763601721
// Reduced from 77.6 KiB to 0.3 KiB
// Debug: Outputs False
// Release: Outputs True
struct S0
{
    public sbyte F2;
}

struct S2
{
    public S0 F6;
    public bool F8;
}

public class Program
{
    static S2 s_5;
    public static void Main()
    {
        s_5.F6 = M12();
        System.Console.WriteLine(s_5.F8);
    }

    static S0 M12()
    {
        return new S0();
    }
}
