// Generated by Fuzzlyn on 2018-07-08 19:19:46
// Seed: 2849126716774181228
// Reduced from 24.7 KiB to 0.2 KiB
// Debug: Outputs 65237
// Release: Outputs -299
public class Program
{
    public static void Main()
    {
        short[][] vr1 = new short[][]{new short[]{-299}};
        char vr2 = (char)(vr1[0][0] | 0U);
        System.Console.WriteLine((int)vr2);
    }
}