// Generated by Fuzzlyn on 2018-07-08 12:01:31
// Seed: 1321321857865887999
// Reduced from 64.8 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static sbyte[, ] s_2 = new sbyte[, ]{{0}};
    public static void Main()
    {
        char vr22 = (char)(s_2[0, 0] & 0);
        s_2[0, 0] = s_2[0, 0];
        System.Console.WriteLine((int)vr22);
    }
}