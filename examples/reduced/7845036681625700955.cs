// Generated by Fuzzlyn on 2018-06-27 00:27:44
// Seed: 7845036681625700955
// Reduced from 17.8 KiB to 0.2 KiB
// Debug: Outputs 160
// Release: Outputs -96
public class Program
{
    public static void Main()
    {
        var vr27 = new sbyte[]{-95};
        short vr36 = (byte)(1U ^ vr27[0]);
        System.Console.WriteLine(vr36);
    }
}