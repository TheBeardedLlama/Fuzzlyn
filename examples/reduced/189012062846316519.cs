// Generated by Fuzzlyn on 2018-07-02 04:32:52
// Seed: 189012062846316519
// Reduced from 65.5 KiB to 0.3 KiB
// Debug: Outputs 62861
// Release: Outputs -2675
struct S0
{
    public short F0;
    public S0(short f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_4 = new S0(-2676);
    public static void Main()
    {
        char vr4 = (char)(1U | s_4.F0);
        System.Console.WriteLine((int)vr4);
    }
}