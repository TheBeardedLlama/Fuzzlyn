// Generated by Fuzzlyn on 2018-07-18 03:57:04
// Seed: 6560334482457151423
// Reduced from 451.8 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static sbyte s_13;
    static short[, ] s_25 = new short[, ]{{0}};
    public static void Main()
    {
        s_13 = (sbyte)(0 & s_25[0, 0]);
        var vr36 = s_25[0, 0];
    }
}