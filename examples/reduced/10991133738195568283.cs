// Generated by Fuzzlyn on 2018-07-01 04:06:25
// Seed: 10991133738195568283
// Reduced from 134.8 KiB to 0.4 KiB
// Debug: Outputs 65510
// Release: Outputs 4294967270
class C0
{
    public sbyte F1;
    public ushort F5;
    public C0(sbyte f1)
    {
        F1 = f1;
    }
}

public class Program
{
    static C0 s_27 = new C0(0);
    static C0[] s_31 = new C0[]{new C0(-26)};
    public static void Main()
    {
        ulong vr10 = (ushort)((byte)(0U & (sbyte)s_27.F5) | s_31[0].F1);
        System.Console.WriteLine(vr10);
    }
}