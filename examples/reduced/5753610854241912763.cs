// Generated by Fuzzlyn on 2018-07-03 04:19:22
// Seed: 5753610854241912763
// Reduced from 126.5 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs 4294967295
public class Program
{
    static sbyte s_1;
    public static void Main()
    {
        var vr27 = s_1--;
        ushort vr33 = 1;
        long vr34 = (ushort)(vr33 | s_1);
        System.Console.WriteLine(vr34);
    }
}
