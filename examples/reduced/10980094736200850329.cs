// Generated by Fuzzlyn on 2018-07-08 07:40:31
// Seed: 10980094736200850329
// Reduced from 16.5 KiB to 0.2 KiB
// Debug: Outputs 65526
// Release: Outputs -10
public class Program
{
    static int[] s_6 = new int[]{-10};
    public static void Main()
    {
        int vr20 = s_6[0];
        char vr21 = (char)(sbyte)vr20;
        int vr23 = vr21;
        System.Console.WriteLine(vr23);
    }
}