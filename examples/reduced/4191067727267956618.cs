// Generated by Fuzzlyn on 2018-07-31 17:18:53
// Seed: 4191067727267956618
// Reduced from 166.4 KiB to 0.2 KiB
// Debug: Outputs 65474
// Release: Outputs 4294967234
public class Program
{
    static sbyte[, ] s_5 = new sbyte[, ]{{-62}};
    public static void Main()
    {
        var vr21 = (ushort)(s_5[0, 0] & s_5[0, 0]);
        uint vr24 = vr21;
        System.Console.WriteLine(vr24);
    }
}