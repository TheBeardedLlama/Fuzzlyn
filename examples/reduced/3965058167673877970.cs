// Generated by Fuzzlyn on 2018-06-30 15:52:27
// Seed: 3965058167673877970
// Reduced from 96.4 KiB to 0.2 KiB
// Debug: Outputs 65408
// Release: Outputs 4294967168
public class Program
{
    static short[, ] s_3 = new short[, ]{{0}};
    static sbyte s_4 = -128;
    public static void Main()
    {
        ulong vr8 = (ushort)(s_3[0, 0] | s_4);
        System.Console.WriteLine(vr8);
    }
}