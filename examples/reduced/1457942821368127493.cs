// Generated by Fuzzlyn on 2018-07-08 23:38:17
// Seed: 1457942821368127493
// Reduced from 66.4 KiB to 0.4 KiB
// Debug: Outputs 175
// Release: Outputs -81
struct S1
{
    public sbyte F5;
}

public class Program
{
    static S1[] s_2 = new S1[]{new S1()};
    static sbyte s_6 = -81;
    static S1[] s_19;
    public static void Main()
    {
        s_19 = s_2;
        s_2[0].F5 = s_6;
        var vr70 = (byte)(0L ^ s_19[0].F5);
        int vr73 = vr70;
        System.Console.WriteLine(vr73);
    }
}