// Generated by Fuzzlyn on 2018-07-14 21:33:32
// Seed: 4521850436762931428
// Reduced from 6.2 KiB to 0.7 KiB
// Debug: Outputs 0
// Release: Outputs 44032
public class Program
{
    static sbyte s_1;
    public static void Main()
    {
        var vr60 = s_1--;
        var vr31 = new short[]{0};
        M3(0, 0, 0, 0, vr31, false, s_1);
    }

    static ushort M3(short arg0, int arg1, long arg2, long arg3, short[] arg4, bool arg5, sbyte arg6)
    {
        ulong var0 = (ulong)arg6++;
        System.Console.WriteLine(arg0);
        System.Console.WriteLine(arg4[0]);
        var vr16 = (ushort)(arg6 * 'T');
        var vr10 = M4(0, vr16) * arg1;
        var vr11 = arg2 % s_1;
        System.Console.WriteLine(vr10);
        return (ushort)arg3;
    }

    static long M4(long arg0, ushort arg1)
    {
        System.Console.WriteLine(arg1);
        return arg0;
    }
}