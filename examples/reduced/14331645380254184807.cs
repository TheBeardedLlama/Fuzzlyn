// Generated by Fuzzlyn v1.1 on 2018-08-05 18:28:34
// Seed: 14331645380254184807
// Reduced from 206.1 KiB to 0.3 KiB
// Debug: Outputs 4294965321
// Release: Outputs 63561
struct S0
{
    public uint F4;
    public S0(uint f4): this()
    {
        F4 = f4;
    }
}

public class Program
{
    static uint s_1;
    public static void Main()
    {
        ushort[] vr41 = new ushort[]{63561};
        s_1 = (uint)(short)vr41[0];
        S0 vr44 = new S0(s_1);
        System.Console.WriteLine(vr44.F4);
    }
}
