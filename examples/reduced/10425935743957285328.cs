// Generated by Fuzzlyn on 2018-07-02 14:01:30
// Seed: 10425935743957285328
// Reduced from 3.8 KiB to 0.4 KiB
// Debug: Outputs 32768
// Release: Outputs -32768
struct S0
{
    public short F1;
    public sbyte F6;
    public S0(short f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    public static void Main()
    {
        var vr10 = new S0(0);
        var vr11 = new S0(-32767);
        M2(vr10, vr11);
    }

    static sbyte M2(S0 arg0, S0 arg1)
    {
        char var0 = (char)(arg1.F1 ^ 1U);
        System.Console.WriteLine((int)var0);
        return arg0.F6;
    }
}