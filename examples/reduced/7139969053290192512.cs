// Generated by Fuzzlyn on 2018-06-29 06:00:39
// Seed: 7139969053290192512
// Reduced from 103.3 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public short F2;
    public long F4;
}

public class Program
{
    static S0[, ] s_1 = new S0[, ]{{new S0()}};
    public static void Main()
    {
        sbyte vr0 = (sbyte)('^' / ((0 & s_1[0, 0].F4) | 1));
        s_1[0, 0].F2 = s_1[0, 0].F2;
    }
}
