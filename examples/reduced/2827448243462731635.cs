// Generated by Fuzzlyn on 2018-06-22 13:58:59
// Seed: 2827448243462731635
// Reduced from 27.5 KiB to 0.3 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    public static void Main()
    {
        M3(2147483646);
    }

    static sbyte M3(int arg0)
    {
        var vr20 = arg0++;
        var vr19 = arg0++;
        var vr10 = (arg0 % (-2 | 1)) & 0;
        System.Console.WriteLine(vr10);
        return 0;
    }
}