// Generated by Fuzzlyn on 2018-07-01 09:58:30
// Seed: 11114075102583437244
// Reduced from 51.3 KiB to 0.2 KiB
// Debug: Outputs 65534
// Release: Outputs -2
public class Program
{
    static int s_1;
    static short s_6 = -2;
    public static void Main()
    {
        s_1 = (char)(0U | s_6);
        System.Console.WriteLine(s_1);
    }
}