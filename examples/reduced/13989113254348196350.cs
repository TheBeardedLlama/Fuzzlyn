// Generated by Fuzzlyn v1.1 on 2018-08-11 06:58:10
// Seed: 13989113254348196350
// Reduced from 5.8 KiB to 0.6 KiB
// Debug: Outputs 45
// Release: Outputs 32813
public class Program
{
    static byte[] s_3 = new byte[]{0};
    public static void Main()
    {
        M1(0);
    }

    static byte M1(sbyte arg1)
    {
        var vr8 = s_3[0];
        byte vr36 = s_3[0]--;
        var vr33 = s_3[0];
        var vr34 = s_3[0];
        var vr28 = (byte)(M2(0, 0, 0) + (arg1-- % M2(M2(0, M2(M2(0, 0, M2(M2(M2(M2(M2(M2((ushort)(-45 * arg1), 0, 0), 0, 0), 0, vr36), 0, 0), 0, vr8), 0, 0)), 0, vr33), 0), 0, vr34)));
        byte vr39 = vr28;
        return s_3[0];
    }

    static byte M2(ushort arg0, long arg1, byte arg3)
    {
        System.Console.WriteLine(arg0);
        return arg3;
    }
}