// Generated by Fuzzlyn on 2018-06-26 22:16:10
// Seed: 14906091590795372764
// Reduced from 36.8 KiB to 0.2 KiB
// Debug: Outputs 65526
// Release: Outputs 4294967286
public class Program
{
    static long s_1 = -10L;
    static long s_7;
    public static void Main()
    {
        long vr14 = s_1;
        s_7 = (ushort)(sbyte)vr14;
        System.Console.WriteLine(s_7);
    }
}