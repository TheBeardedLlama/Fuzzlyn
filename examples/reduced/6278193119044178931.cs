// Generated by Fuzzlyn on 2018-06-29 21:25:02
// Seed: 6278193119044178931
// Reduced from 87.9 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public char F0;
}

public class Program
{
    static short[, ] s_2 = new short[, ]{{0}};
    public static void Main()
    {
        var vr19 = new S0();
        var vr20 = (ushort)(s_2[0, 0] & 0);
        var vr21 = s_2[0, 0];
        M14(vr19, vr20);
    }

    static bool M14(S0 arg0, uint arg2)
    {
        System.Console.WriteLine((int)arg0.F0);
        return true;
    }
}