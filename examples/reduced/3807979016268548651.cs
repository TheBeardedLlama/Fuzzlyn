// Generated by Fuzzlyn on 2018-06-29 02:11:29
// Seed: 3807979016268548651
// Reduced from 8.3 KiB to 0.3 KiB
// Debug: Outputs 156
// Release: Outputs 65436
public class Program
{
    static sbyte s_1;
    static ushort s_3;
    public static void Main()
    {
        int vr3 = -1088414820;
        ushort vr4 = (ushort)vr3;
        s_1 = (sbyte)vr4;
        s_3 = (byte)(0L ^ s_1);
        System.Console.WriteLine(s_3);
    }
}