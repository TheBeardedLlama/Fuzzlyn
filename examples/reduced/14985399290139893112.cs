// Generated by Fuzzlyn on 2018-07-08 18:15:53
// Seed: 14985399290139893112
// Reduced from 90.4 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public ulong F6;
}

struct S1
{
    public S0 F7;
}

class C0
{
    public S1 F0;
    public S1 F5;
}

public class Program
{
    static C0[, ] s_22 = new C0[, ]{{new C0()}};
    public static void Main()
    {
        ulong vr4 = 0 & s_22[0, 0].F0.F7.F6;
        var vr5 = s_22[0, 0].F5.F7.F6;
        System.Console.WriteLine(vr4);
    }
}