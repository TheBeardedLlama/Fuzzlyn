// Generated by Fuzzlyn on 2018-07-11 02:05:06
// Seed: 3344383922368790157
// Reduced from 34.4 KiB to 0.2 KiB
// Debug: Outputs 65459
// Release: Outputs 4294967219
public class Program
{
    static sbyte[, ][] s_1 = new sbyte[, ][]{{new sbyte[]{-63}}};
    public static void Main()
    {
        char vr12 = (char)('r' ^ s_1[0, 0][0]);
        ulong vr9 = vr12;
        System.Console.WriteLine(vr9);
    }
}
