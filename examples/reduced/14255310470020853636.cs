// Generated by Fuzzlyn on 2018-06-30 08:00:29
// Seed: 14255310470020853636
// Reduced from 82.1 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static char[, ] s_13 = new char[, ]{{'='}};
    public static void Main()
    {
        bool vr2 = ((0 / ((s_13[0, 0] & 0) | 1)) ^ s_13[0, 0]) <= 0;
    }
}