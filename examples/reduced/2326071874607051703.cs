// Generated by Fuzzlyn on 2018-07-09 10:19:55
// Seed: 2326071874607051703
// Reduced from 171.5 KiB to 0.5 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public long F4;
    public byte F5;
}

class C0
{
    public S0 F2;
    public S0 F3;
}

public class Program
{
    static S0[, ] s_1;
    static C0[, ] s_14 = new C0[, ]{{new C0()}};
    public static void Main()
    {
        var vr6 = (ulong)(s_14[0, 0].F3.F5 & 0);
        var vr7 = s_14[0, 0].F2.F4;
        M23(vr6);
    }

    static C0 M23(ulong arg0)
    {
        s_1 = new S0[, ]{{new S0()}};
        return s_14[0, 0];
    }
}
