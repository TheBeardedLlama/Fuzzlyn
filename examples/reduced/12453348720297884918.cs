// Generated by Fuzzlyn on 2018-07-18 01:04:56
// Seed: 12453348720297884918
// Reduced from 328.1 KiB to 0.3 KiB
// Debug: Outputs 18446744073709551615
// Release: Outputs 255
public class Program
{
    static short s_1;
    static ulong[] s_5 = new ulong[]{0};
    static byte[] s_12 = new byte[]{0};
    public static void Main()
    {
        s_12[0] = 255;
        s_5[0] = (ulong)(sbyte)s_12[0]--;
        var vr37 = (ulong)s_1;
        vr37 = s_5[0];
        System.Console.WriteLine(vr37);
    }
}