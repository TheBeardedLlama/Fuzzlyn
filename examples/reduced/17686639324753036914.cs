// Generated by Fuzzlyn on 2018-07-07 11:39:54
// Seed: 17686639324753036914
// Reduced from 234.8 KiB to 0.3 KiB
// Debug: Outputs 129
// Release: Outputs 4294967169
class C0
{
    public sbyte F4;
    public C0(sbyte f4)
    {
        F4 = f4;
    }
}

public class Program
{
    public static void Main()
    {
        var vr22 = new C0(-127);
        long vr24 = (byte)(0U ^ vr22.F4);
        System.Console.WriteLine(vr24);
    }
}
