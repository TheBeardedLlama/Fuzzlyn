// Generated by Fuzzlyn on 2018-07-22 08:33:51
// Seed: 12029940486040733329
// Reduced from 154.9 KiB to 0.3 KiB
// Debug: Outputs 4294967199
// Release: Outputs 159
public class Program
{
    static byte[] s_20 = new byte[]{97};
    public static void Main()
    {
        uint vr71 = default(uint);
        var vr72 = vr71--;
        var vr73 = s_20[0] * vr71;
        long vr74 = vr73;
        System.Console.WriteLine(vr74);
    }
}