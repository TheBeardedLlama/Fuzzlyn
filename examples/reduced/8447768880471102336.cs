// Generated by Fuzzlyn on 2018-06-30 23:22:09
// Seed: 8447768880471102336
// Reduced from 29.6 KiB to 0.4 KiB
// Debug: Prints 0 line(s)
// Release: Prints 1 line(s)
struct S0
{
    public long F0;
}

public class Program
{
    static long[] s_1 = new long[]{0};
    public static void Main()
    {
        s_1[0] = 9223372036854775806L;
        bool vr5 = (char)(sbyte)s_1[0] <= (long)65534;
        if (vr5)
        {
        }
        else
        {
            S0[] vr8 = new S0[]{new S0()};
            System.Console.WriteLine(vr8[0].F0);
        }
    }
}