// Generated by Fuzzlyn v1.1 on 2018-08-29 10:25:03
// Seed: 659091446240913000
// Reduced from 264.8 KiB to 0.5 KiB in 00:06:16
// Debug: Outputs -37386
// Release: Outputs -1844875786
public class Program
{
    static int s_24;
    static short s_29 = -1;
    static short s_35;
    static ushort s_37;
    public static void Main()
    {
        M78(ref s_37, s_35);
        System.Console.WriteLine(s_24);
    }

    static void M78(ref ushort arg1, short arg2)
    {
        try
        {
            s_37 *= arg1;
        }
        finally
        {
            arg2 &= 1;
            arg2 = s_29;
            s_24 = 37386 * arg2;
        }
    }
}
