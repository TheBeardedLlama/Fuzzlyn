// Generated by Fuzzlyn on 2018-07-19 00:25:07
// Seed: 13017450630580228646
// Reduced from 15.6 KiB to 0.2 KiB
// Debug: Outputs 6
// Release: Outputs 0
public class Program
{
    static sbyte s_5 = -39;
    public static void Main()
    {
        ushort vr1 = (ushort)((char)(s_5 ^ -9223372036854775807L) % 10);
        System.Console.WriteLine(vr1);
    }
}