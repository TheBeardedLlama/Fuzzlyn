// Generated by Fuzzlyn on 2018-07-08 16:35:45
// Seed: 16622990588808048220
// Reduced from 14.0 KiB to 0.3 KiB
// Debug: Outputs 65499
// Release: Outputs 219
public class Program
{
    static byte[] s_1;
    static char[] s_6 = new char[]{'u'};
    public static void Main()
    {
        s_1 = new byte[]{218};
        s_6[0] = (char)(-127 | s_1[0]++);
        System.Console.WriteLine((int)s_6[0]);
    }
}