// Generated by Fuzzlyn on 2018-08-02 02:43:20
// Seed: 10314448082834117397
// Reduced from 108.6 KiB to 0.3 KiB
// Debug: Outputs 65472
// Release: Outputs 4294967232
public class Program
{
    static sbyte[][] s_3 = new sbyte[][]{new sbyte[]{-64}};
    public static void Main()
    {
        byte vr21 = 0;
        char vr22 = (char)(s_3[0][0] ^ vr21);
        long vr25 = vr22;
        System.Console.WriteLine(vr25);
    }
}
