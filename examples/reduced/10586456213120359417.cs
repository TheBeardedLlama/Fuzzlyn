// Generated by Fuzzlyn on 2018-06-26 04:23:04
// Seed: 10586456213120359417
// Reduced from 14.1 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public ulong F2;
    public char F3;
}

struct S1
{
    public S0 F0;
    public S0 F5;
}

public class Program
{
    public static void Main()
    {
        var vr5 = new S1[][, ]{new S1[, ]{{new S1()}}};
        long vr7 = 0 & vr5[0][0, 0].F0.F3;
        vr5[0][0, 0].F5.F2 = vr5[0][0, 0].F5.F2;
        System.Console.WriteLine(vr7);
    }
}