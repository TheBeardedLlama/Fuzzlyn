// Generated by Fuzzlyn on 2018-07-04 15:18:24
// Seed: 1081363175670098524
// Reduced from 50.7 KiB to 0.3 KiB
// Debug: Outputs 48605
// Release: Outputs 4294950365
struct S0
{
    public ulong F2;
    public short F3;
    public S0(short f3): this()
    {
        F3 = f3;
    }
}

public class Program
{
    static S0 s_2 = new S0(-16931);
    public static void Main()
    {
        ulong vr5 = (char)(s_2.F3 ^ 0U);
        s_2.F2 = vr5;
        System.Console.WriteLine(s_2.F2);
    }
}