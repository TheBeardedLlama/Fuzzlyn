// Generated by Fuzzlyn on 2018-06-22 02:55:02
// Seed: 4848827380832149073
// Reduced from 50.9 KiB to 0.3 KiB
// Debug: Outputs 174
// Release: Outputs -82
struct S0
{
    public int F1;
}

public class Program
{
    static sbyte[] s_4;
    public static void Main()
    {
        S0 vr21;
        s_4 = new sbyte[]{-90};
        vr21.F1 = (byte)(10L | s_4[0]);
        System.Console.WriteLine(vr21.F1);
    }
}