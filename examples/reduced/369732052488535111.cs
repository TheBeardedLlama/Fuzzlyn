// Generated by Fuzzlyn on 2018-06-18 13:17:01
// Seed: 369732052488535111
// Reduced from 59.8 KiB to 0.3 KiB
// Debug: Outputs 65408
// Release: Outputs 4294967168
class C0
{
    public byte F1;
    public sbyte F5;
    public C0(sbyte f5)
    {
        F5 = f5;
    }
}

public class Program
{
    public static void Main()
    {
        var vr52 = new C0[, ]{{new C0(-128)}};
        ulong vr54 = (ushort)(vr52[0, 0].F5 ^ vr52[0, 0].F1);
        System.Console.WriteLine(vr54);
    }
}