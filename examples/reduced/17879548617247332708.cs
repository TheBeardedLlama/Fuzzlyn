// Generated by Fuzzlyn on 2018-07-01 03:27:03
// Seed: 17879548617247332708
// Reduced from 139.4 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static sbyte[, ] s_1 = new sbyte[, ]{{0}};
    public static void Main()
    {
        ulong vr12 = 0 & (uint)s_1[0, 0];
        s_1[0, 0] = s_1[0, 0];
        System.Console.WriteLine(vr12);
    }
}