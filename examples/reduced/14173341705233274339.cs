// Generated by Fuzzlyn on 2018-07-25 10:33:09
// Seed: 14173341705233274339
// Reduced from 175.6 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static sbyte[, ] s_29 = new sbyte[, ]{{-127}};
    public static void Main()
    {
        char vr9 = (char)(126 | s_29[0, 0]);
        System.Console.WriteLine((int)vr9);
    }
}