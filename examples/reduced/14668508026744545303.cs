// Generated by Fuzzlyn v1.1 on 2018-08-23 04:18:34
// Seed: 14668508026744545303
// Reduced from 84.6 KiB to 0.2 KiB
// Debug: Outputs 4294956735
// Release: Outputs 54975
public class Program
{
    public static void Main()
    {
        var vr9 = new short[, ][]{{new short[]{-10561}}};
        ulong vr14 = (uint)(0 | vr9[0, 0][0]);
        System.Console.WriteLine(vr14);
    }
}