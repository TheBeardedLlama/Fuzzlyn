// Generated by Fuzzlyn on 2018-07-15 03:25:51
// Seed: 15369435360317159231
// Reduced from 3.2 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
public class Program
{
    static ushort s_1;
    public static void Main()
    {
        var vr1 = new byte[][, ]{new byte[, ]{{0}}};
        M2(0, vr1);
    }

    static ulong M2(ulong arg0, byte[][, ] arg1)
    {
        int var0 = arg1[0][0, 0] & 0;
        arg1[0] = arg1[0];
        char var2 = (char)(s_1 % (var0 | 1));
        return arg0;
    }
}