// Generated by Fuzzlyn v1.1 on 2018-08-29 10:43:23
// Seed: 982272474434747552
// Reduced from 290.5 KiB to 1.0 KiB in 00:11:09
// Debug: Outputs -54906
// Release: Outputs -696702586
public class Program
{
    static sbyte s_20 = -1;
    static sbyte[] s_25 = new sbyte[]{0};
    static uint s_50;
    static short[] s_57;
    static int s_72;
    static bool[] s_89 = new bool[]{true};
    public static void Main()
    {
        M30(0);
    }

    static void M30(short arg1)
    {
        ulong var15 = default(ulong);
        arg1 = (short)(s_25[0] ^ s_20++);
        var vr5 = arg1 * 54906;
        System.Console.WriteLine(vr5);
        try
        {
            s_25[0] = 0;
        }
        finally
        {
            if (s_89[0])
            {
                System.Console.WriteLine(s_50);
            }
            else
            {
                byte var14 = (byte)(M86() / s_72--);
                arg1 = s_57[0];
                System.Console.WriteLine(var14);
                System.Console.WriteLine(var15);
            }
        }

        System.Console.WriteLine(arg1);
    }

    static int M86()
    {
        return default(int);
    }
}