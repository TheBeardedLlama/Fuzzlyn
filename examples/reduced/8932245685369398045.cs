// Generated by Fuzzlyn on 2018-06-28 23:07:04
// Seed: 8932245685369398045
// Reduced from 28.4 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static uint[, ] s_4 = new uint[, ]{{0}};
    public static void Main()
    {
        ulong vr16 = 0 & s_4[0, 0];
        s_4[0, 0] -= s_4[0, 0];
        System.Console.WriteLine(vr16);
    }
}