// Generated by Fuzzlyn on 2018-07-10 05:23:13
// Seed: 1052225563944291572
// Reduced from 69.1 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static short[, ] s_4 = new short[, ]{{0}};
    public static void Main()
    {
        M16();
    }

    static byte M16()
    {
        return (byte)((0 & s_4[0, 0]) + s_4[0, 0]);
    }
}