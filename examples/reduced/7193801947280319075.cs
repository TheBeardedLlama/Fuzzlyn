// Generated by Fuzzlyn on 2018-07-14 22:37:57
// Seed: 7193801947280319075
// Reduced from 187.6 KiB to 0.2 KiB
// Debug: Outputs 65409
// Release: Outputs -127
public class Program
{
    static sbyte s_4;
    public static void Main()
    {
        s_4 = -128;
        char vr39 = (char)(s_4 | 1U);
        System.Console.WriteLine((int)vr39);
    }
}