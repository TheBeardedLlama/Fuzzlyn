// Generated by Fuzzlyn on 2018-07-14 08:28:46
// Seed: 15856481657510624859
// Reduced from 276.5 KiB to 0.5 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S2
{
    public uint F1;
    public int F3;
}

public class Program
{
    static S2[, ] s_11 = new S2[, ]{{new S2()}};
    static byte s_12;
    static ushort[] s_14 = new ushort[]{0};
    public static void Main()
    {
        var vr72 = s_14[0];
        var vr73 = (int)(s_11[0, 0].F1 & 0);
        var vr74 = s_11[0, 0].F3;
        s_12 = (byte)M26(vr72, vr73);
    }

    static ushort M26(ushort arg2, int arg4)
    {
        var vr53 = new char[]{'~', '9', 'u', 't', '?', ',', ')'};
        return arg2;
    }
}
