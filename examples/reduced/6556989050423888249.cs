// Generated by Fuzzlyn on 2018-07-03 19:47:50
// Seed: 6556989050423888249
// Reduced from 21.1 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ulong s_1;
    static byte[, ] s_3 = new byte[, ]{{59}};
    public static void Main()
    {
        s_1 %= (uint)((0 & s_3[0, 0]) ^ s_3[0, 0]);
    }
}