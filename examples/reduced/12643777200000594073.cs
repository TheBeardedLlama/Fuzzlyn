// Generated by Fuzzlyn on 2018-07-24 03:35:39
// Seed: 12643777200000594073
// Reduced from 151.9 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs 4294967295
public class Program
{
    static sbyte s_11;
    public static void Main()
    {
        var vr45 = s_11--;
        var vr46 = (ushort)(1U | s_11);
        long vr47 = vr46;
        System.Console.WriteLine(vr47);
    }
}