// Generated by Fuzzlyn on 2018-06-21 13:56:29
// Seed: 6675704835564838476
// Reduced from 26.3 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static sbyte s_1 = -1;
    public static void Main()
    {
        char vr8 = M7();
        System.Console.WriteLine((int)vr8);
    }

    static char M7()
    {
        return (char)(0 ^ s_1);
    }
}