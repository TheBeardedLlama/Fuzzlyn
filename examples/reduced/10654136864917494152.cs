// Generated by Fuzzlyn on 2018-06-23 09:23:47
// Seed: 10654136864917494152
// Reduced from 4.0 KiB to 0.2 KiB
// Debug: Outputs 65509
// Release: Outputs -27
public class Program
{
    public static void Main()
    {
        sbyte[, ][] vr2 = new sbyte[, ][]{{new sbyte[]{-27}}};
        char vr3 = (char)(vr2[0, 0][0] & vr2[0, 0][0]);
        System.Console.WriteLine((int)vr3);
    }
}
