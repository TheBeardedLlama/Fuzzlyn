// Generated by Fuzzlyn v1.1 on 2018-08-31 05:51:08
// Seed: 4117817152236046141
// Reduced from 76.4 KiB to 0.2 KiB
// Debug: Outputs 194
// Release: Outputs -62
public class Program
{
    static byte s_12 = 62;
    public static void Main()
    {
        short vr30 = -1;
        byte vr32 = (byte)(s_12 * vr30);
        int vr35 = vr32;
        System.Console.WriteLine(vr35);
    }
}