// Generated by Fuzzlyn on 2018-07-28 17:38:18
// Seed: 4522634467158448054
// Reduced from 7.2 KiB to 0.2 KiB
// Debug: Outputs 17
// Release: Outputs 16
public class Program
{
    public static void Main()
    {
        byte[] vr0 = new byte[]{182};
        vr0[0] = (byte)((vr0[0] / (10U | 1)) | 1);
        System.Console.WriteLine(vr0[0]);
    }
}