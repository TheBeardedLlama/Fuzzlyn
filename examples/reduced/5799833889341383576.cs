// Generated by Fuzzlyn on 2018-07-06 18:53:25
// Seed: 5799833889341383576
// Reduced from 1.8 KiB to 0.3 KiB
// Debug: Outputs 18446744073709551584
// Release: Outputs 4320
public class Program
{
    static short[] s_1 = new short[]{0};
    static ulong s_2;
    public static void Main()
    {
        s_1[0] = 4320;
        s_1[0] = s_1[0];
        s_2 = (ulong)(sbyte)s_1[0];
        System.Console.WriteLine(s_2);
    }
}
