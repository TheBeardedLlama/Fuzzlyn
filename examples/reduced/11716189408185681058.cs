// Generated by Fuzzlyn on 2018-06-29 20:20:35
// Seed: 11716189408185681058
// Reduced from 17.6 KiB to 0.2 KiB
// Debug: Outputs 65520
// Release: Outputs -16
public class Program
{
    static sbyte[] s_3 = new sbyte[]{-16};
    public static void Main()
    {
        char vr4 = (char)(int)(0 ^ (long)s_3[0]);
        System.Console.WriteLine((int)vr4);
    }
}