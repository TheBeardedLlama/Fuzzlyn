// Generated by Fuzzlyn on 2018-07-01 02:07:43
// Seed: 4445805065367346152
// Reduced from 55.0 KiB to 0.3 KiB
// Debug: Outputs 65535
// Release: Outputs -1
struct S1
{
    public int F4;
}

public class Program
{
    static sbyte s_2 = -1;
    public static void Main()
    {
        S1 vr19;
        char vr20 = M17();
        vr19.F4 = vr20;
        System.Console.WriteLine(vr19.F4);
    }

    static char M17()
    {
        return (char)(s_2 | s_2);
    }
}