// Generated by Fuzzlyn on 2018-07-10 07:04:01
// Seed: 17021876708768795531
// Reduced from 191.9 KiB to 0.7 KiB
// Debug: Outputs 32768
// Release: Outputs 4294934528
class C0
{
    public short F1;
    public long F3;
    public C0(short f1)
    {
        F1 = f1;
    }
}

class C1
{
    public C0 F1;
    public C0 F4;
    public C1(C0 f1, C0 f4)
    {
        F1 = f1;
        F4 = f4;
    }
}

public class Program
{
    static C1 s_6 = new C1(new C0(0), new C0(32766));
    static C0 s_21 = new C0(0);
    public static void Main()
    {
        short vr42 = s_6.F4.F1++;
        s_6 = new C1(s_6.F4, s_6.F4);
        short vr58 = s_6.F4.F1++;
        ushort vr63 = M47();
        uint vr66 = vr63;
        System.Console.WriteLine(vr66);
    }

    static ushort M47()
    {
        return (ushort)(s_6.F1.F1 ^ s_21.F3);
    }
}