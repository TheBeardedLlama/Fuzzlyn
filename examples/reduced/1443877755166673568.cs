// Generated by Fuzzlyn on 2018-06-20 17:16:50
// Seed: 1443877755166673568
// Reduced from 89.2 KiB to 0.3 KiB
// Debug: Outputs 65526
// Release: Outputs 4294967286
struct S0
{
    public short F5;
    public long F6;
    public S0(short f5): this()
    {
        F5 = f5;
    }
}

public class Program
{
    static S0 s_7;
    public static void Main()
    {
        s_7 = new S0(-10);
        char vr9 = (char)(s_7.F5 ^ 0U);
        s_7.F6 = vr9;
        System.Console.WriteLine(s_7.F6);
    }
}