// Generated by Fuzzlyn on 2018-07-20 00:09:57
// Seed: 17918643215037083662
// Reduced from 342.6 KiB to 0.3 KiB
// Debug: Outputs 65408
// Release: Outputs 4294967168
public class Program
{
    static sbyte s_3 = -128;
    public static void Main()
    {
        var vr31 = M63();
        uint vr32 = vr31;
        System.Console.WriteLine(vr32);
    }

    static ushort M63()
    {
        return (ushort)(0 ^ s_3);
    }
}