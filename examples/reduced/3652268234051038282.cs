// Generated by Fuzzlyn on 2018-07-28 16:22:53
// Seed: 3652268234051038282
// Reduced from 75.8 KiB to 0.2 KiB
// Debug: Outputs 65430
// Release: Outputs 4294967190
public class Program
{
    static char s_2;
    static sbyte s_6 = -106;
    public static void Main()
    {
        int vr8 = s_6 ^ s_2;
        ulong vr9 = (ushort)vr8;
        System.Console.WriteLine(vr9);
    }
}