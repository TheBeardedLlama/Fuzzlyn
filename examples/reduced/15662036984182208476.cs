// Generated by Fuzzlyn on 2018-07-20 21:27:36
// Seed: 15662036984182208476
// Reduced from 416.6 KiB to 0.7 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public uint F2;
    public char F6;
}

struct S0
{
    public C0 F4;
    public C0 F5;
    public S0(C0 f4, C0 f5): this()
    {
        F4 = f4;
        F5 = f5;
    }
}

struct S1
{
    public S0 F0;
    public S0 F5;
    public S1(S0 f0, S0 f5): this()
    {
        F0 = f0;
        F5 = f5;
    }
}

public class Program
{
    static S1 s_11 = new S1(new S0(new C0(), new C0()), new S0(new C0(), new C0()));
    static S0 s_32;
    static S1[, ] s_43 = new S1[, ]{{new S1(new S0(new C0(), new C0()), new S0(new C0(), new C0()))}};
    public static void Main()
    {
        s_11.F5.F5.F2 = s_43[0, 0].F0.F4.F6 & (uint)0;
        s_32.F4 = s_43[0, 0].F0.F5;
    }
}