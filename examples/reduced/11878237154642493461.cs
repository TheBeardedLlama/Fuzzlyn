// Generated by Fuzzlyn on 2018-07-03 00:48:41
// Seed: 11878237154642493461
// Reduced from 4.4 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ushort[, ] s_1 = new ushort[, ]{{0}};
    public static void Main()
    {
        bool vr6 = 0 != (0 % ((0 & s_1[0, 0]) | 1));
        s_1[0, 0] = s_1[0, 0];
    }
}