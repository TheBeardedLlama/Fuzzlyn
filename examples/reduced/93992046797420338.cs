// Generated by Fuzzlyn on 2018-07-28 09:27:04
// Seed: 93992046797420338
// Reduced from 119.5 KiB to 0.7 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public bool F2;
}

struct S1
{
    public int F5;
    public short F7;
}

class C0
{
    public long F0;
}

struct S2
{
    public S1 F0;
    public S0 F2;
    public S2(S0 f2): this()
    {
    }
}

class C2
{
    public C2(S2 f1)
    {
    }
}

public class Program
{
    static C0[] s_1 = new C0[]{new C0()};
    static S1[, ] s_4 = new S1[, ]{{new S1()}};
    public static void Main()
    {
        var vr19 = new S2(new S0());
        vr19.F2.F2 = (s_4[0, 0].F5 & 0) == s_1[0].F0;
        var vr27 = vr19.F0.F7;
        M10(vr27);
    }

    static C2 M10(short arg0)
    {
        return new C2(new S2(new S0()));
    }
}