// Generated by Fuzzlyn on 2018-06-27 17:48:40
// Seed: 16436438412301926183
// Reduced from 35.1 KiB to 0.2 KiB
// Debug: Outputs 210
// Release: Outputs 65490
public class Program
{
    static sbyte s_1 = -46;
    public static void Main()
    {
        byte vr16 = (byte)(s_1 / 1U);
        ushort vr13 = vr16;
        System.Console.WriteLine(vr13);
    }
}