// Generated by Fuzzlyn on 2018-07-13 12:20:19
// Seed: 1641031819405175167
// Reduced from 10.7 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public ulong F0;
}

class C1
{
    public sbyte F1;
    public C0 F5;
    public C1(C0 f5)
    {
        F5 = f5;
    }
}

public class Program
{
    static C1[, ] s_1 = new C1[, ]{{new C1(new C0())}};
    public static void Main()
    {
        byte vr0 = (byte)((0 & (char)s_1[0, 0].F5.F0) ^ s_1[0, 0].F1);
        System.Console.WriteLine(vr0);
    }
}