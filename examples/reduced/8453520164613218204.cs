// Generated by Fuzzlyn v1.1 on 2018-08-14 04:26:00
// Seed: 8453520164613218204
// Reduced from 93.5 KiB to 0.8 KiB in 00:02:13
// Debug: Outputs 0
// Release: Outputs -2
public class Program
{
    static sbyte s_1 = -1;
    static sbyte s_20;
    static ushort[] s_27 = new ushort[]{0};
    static short[, ] s_34 = new short[, ]{{0}};
    public static void Main()
    {
        M48(s_1);
    }

    static void M48(sbyte arg0)
    {
        try
        {
            M49();
        }
        finally
        {
            arg0 = (sbyte)s_27[0];
            M50();
            short var1 = s_34[0, 0];
            arg0 /= 127;
            sbyte var2 = arg0++;
            System.Console.WriteLine(var2);
            arg0 = s_20;
            System.Console.WriteLine(var1);
            M49();
        }

        System.Console.WriteLine(arg0);
    }

    static short M49()
    {
        return default(short);
    }

    static long M50()
    {
        return default(long);
    }
}