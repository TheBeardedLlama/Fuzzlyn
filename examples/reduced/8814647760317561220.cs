// Generated by Fuzzlyn on 2018-07-26 02:12:59
// Seed: 8814647760317561220
// Reduced from 290.4 KiB to 0.5 KiB
// Debug: Outputs 0
// Release: Outputs -6250942109691281305
class C0
{
    public long F0;
    public C0(long f0)
    {
        F0 = f0;
    }
}

public class Program
{
    static C0[, ] s_16 = new C0[, ]{{new C0(0)}};
    static int s_24 = 2147483647;
    static sbyte s_25 = -66;
    static C0 s_61 = new C0(-6250942109691281305L);
    public static void Main()
    {
        bool vr14 = (ushort)(1U | s_25) > (uint)s_24;
        if (vr14)
        {
            s_16[0, 0].F0 = s_61.F0;
        }
        else
        {
        }

        System.Console.WriteLine(s_16[0, 0].F0);
    }
}