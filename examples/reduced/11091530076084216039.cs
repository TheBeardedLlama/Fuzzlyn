// Generated by Fuzzlyn on 2018-07-11 16:22:04
// Seed: 11091530076084216039
// Reduced from 28.1 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static bool s_2;
    static byte[, ] s_4 = new byte[, ]{{0}};
    public static void Main()
    {
        uint vr2 = (uint)((0 & s_4[0, 0]) - s_4[0, 0]);
        vr2 = (uint)M11(s_2, vr2);
    }

    static sbyte M11(bool arg0, uint arg1)
    {
        System.Console.WriteLine(arg0);
        return 0;
    }
}
