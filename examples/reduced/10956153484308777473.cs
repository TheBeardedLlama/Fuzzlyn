// Generated by Fuzzlyn on 2018-06-24 06:03:12
// Seed: 10956153484308777473
// Reduced from 96.2 KiB to 0.2 KiB
// Debug: Outputs 32768
// Release: Outputs 4294934528
public class Program
{
    static short[] s_4 = new short[]{-32767};
    public static void Main()
    {
        var vr11 = (char)(1L ^ s_4[0]);
        long vr16 = vr11;
        System.Console.WriteLine(vr16);
    }
}