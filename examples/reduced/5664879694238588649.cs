// Generated by Fuzzlyn on 2018-07-13 17:46:54
// Seed: 5664879694238588649
// Reduced from 5.1 KiB to 0.3 KiB
// Debug: Outputs 65408
// Release: Outputs -128
public class Program
{
    static sbyte s_3;
    public static void Main()
    {
        char vr1 = (char)((0 & M1()) | s_3);
        System.Console.WriteLine((int)vr1);
    }

    static long M1()
    {
        s_3 = 127;
        sbyte vr2 = s_3++;
        return s_3;
    }
}