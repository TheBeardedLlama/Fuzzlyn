// Generated by Fuzzlyn v1.1 on 2018-08-27 15:09:02
// Seed: 2751997081093199697
// Reduced from 260.0 KiB to 0.9 KiB in 00:06:38
// Debug: Outputs 0
// Release: Outputs -1
struct S0
{
    public uint F3;
    public ushort F7;
    public S0(uint f3): this()
    {
        F3 = f3;
    }
}

public class Program
{
    static S0 s_2;
    static S0[, ] s_3 = new S0[, ]{{new S0(0)}};
    static sbyte[][][][] s_52 = new sbyte[][][][]{new sbyte[][][]{new sbyte[][]{new sbyte[]{-1}}}};
    public static void Main()
    {
        s_3[0, 0] = new S0(2296746148U);
        var vr5 = s_52[0][0][0][0];
        var vr6 = M16(vr5);
    }

    static ulong[] M16(sbyte arg1)
    {
        arg1 = (sbyte)(-1 ^ s_3[0, 0].F3);
        try
        {
            s_2.F7 = 0;
        }
        finally
        {
            ++arg1;
            sbyte var6 = arg1;
            var6 /= (sbyte)(var6 | 1);
            System.Console.WriteLine(var6);
        }

        ulong[] vr12 = default(ulong[]);
        return vr12;
    }
}
