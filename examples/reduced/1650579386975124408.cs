// Generated by Fuzzlyn on 2018-06-22 22:01:49
// Seed: 1650579386975124408
// Reduced from 306.0 KiB to 0.3 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static int[] s_85 = new int[]{0};
    public static void Main()
    {
        sbyte[, ][, ] vr166 = new sbyte[, ][, ]{{new sbyte[, ]{{-1}}}};
        char vr167 = (char)(vr166[0, 0][0, 0] ^ s_85[0]);
        System.Console.WriteLine((int)vr167);
    }
}