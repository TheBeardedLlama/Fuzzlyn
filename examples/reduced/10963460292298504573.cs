// Generated by Fuzzlyn on 2018-06-29 05:36:02
// Seed: 10963460292298504573
// Reduced from 107.6 KiB to 0.7 KiB
// Debug: Prints 1 line(s)
// Release: Prints 0 line(s)
struct S0
{
    public short F1;
    public ushort F2;
    public S0(short f1): this()
    {
        F1 = f1;
    }
}

struct S1
{
    public S0 F1;
    public S0 F4;
    public S1(S0 f4): this()
    {
        F4 = f4;
    }
}

class C0
{
    public S1 F2;
    public C0(S1 f2)
    {
        F2 = f2;
    }
}

public class Program
{
    public static void Main()
    {
        short[] vr8;
        C0 vr9 = new C0(new S1(new S0(-32107)));
        S1 vr10 = vr9.F2;
        bool vr11 = vr9.F2.F1.F2 < (char)(vr10.F4.F1 ^ 1U);
        if (vr11)
        {
            vr8 = new short[]{0};
            System.Console.WriteLine(vr8[0]);
        }
    }
}