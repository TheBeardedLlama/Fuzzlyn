// Generated by Fuzzlyn on 2018-06-19 16:53:00
// Seed: 14688316516646180822
// Reduced from 384.5 KiB to 0.2 KiB
// Debug: Outputs 65509
// Release: Outputs -27
public class Program
{
    static sbyte s_1 = -27;
    public static void Main()
    {
        byte vr11 = default(byte);
        int vr12 = (char)(vr11 ^ s_1);
        System.Console.WriteLine(vr12);
    }
}
