// Generated by Fuzzlyn on 2018-07-02 06:09:54
// Seed: 3914528108658731552
// Reduced from 1.5 KiB to 0.3 KiB
// Debug: Outputs 65535
// Release: Outputs 4294967295
struct S0
{
    public short F5;
    public S0(short f5): this()
    {
        F5 = f5;
    }
}

public class Program
{
    static S0 s_1 = new S0(-2);
    public static void Main()
    {
        var vr1 = (char)(1U ^ s_1.F5);
        long vr2 = vr1;
        System.Console.WriteLine(vr2);
    }
}