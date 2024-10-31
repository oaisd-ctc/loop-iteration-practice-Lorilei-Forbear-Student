using System;

public class Program
{

    public static void Main(string[]args)
    {
        //Write1ThroughN_While(7);
        //Write1ThroughN_For(3);
        //WriteNThrough1_While(9);
        //WriteNThrough1_For(8);
    }

    public static void Write1ThroughN_While(int n)
    {
        int i = 1;
        while (i <= n)
        {
            Console.WriteLine(i);
            i++;
        }
    }

    public static void Write1ThroughN_For(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void WriteNThrough1_While(int n)
    {
        int i = 1;
        while (i<=n)
        {
            Console.WriteLine(n);
            n--;
        }
    }

    public static void WriteNThrough1_For(int n)
    {
        for (int i = 1; i <= n; n--)
        {
            Console.WriteLine(n);
        }
    }

    public static void WriteEvensThrough100()
    {
        
    }
}