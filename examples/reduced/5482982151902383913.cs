// Generated by Fuzzlyn on 2018-06-26 15:41:44
// Seed: 5482982151902383913
// Reduced from 4.2 KiB to 0.3 KiB
// Debug: Outputs 39
// Release: Outputs 61
public class Program
{
    static ushort s_1;
    static byte s_2;
    public static void Main()
    {
        s_1 = 41340;
        s_2 = (byte)(2031045242385565701UL % (char)(s_1 | 1));
        s_2 = (byte)(2031045242385565701UL % (char)((sbyte)((uint)(s_2 & 0UL) | s_2) | 1));
        System.Console.WriteLine(s_2);
    }
}