// Generated by Fuzzlyn on 2018-06-20 15:52:32
// Seed: 13102734379649455744
// Reduced from 10.9 KiB to 0.4 KiB
// Debug: Outputs 51825
// Release: Outputs -13711
struct S0
{
    public int F0;
    public short F6;
    public S0(short f6): this()
    {
        F6 = f6;
    }
}

public class Program
{
    static S0[] s_2;
    public static void Main()
    {
        s_2 = new S0[]{new S0(-13712)};
        ulong vr5 = (ushort)(s_2[0].F6 | 1L);
        s_2[0].F0 = (int)vr5;
        System.Console.WriteLine(s_2[0].F0);
    }
}