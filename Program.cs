using System;

public class Program
{

    public static void Main(string[]args)
    {
        //Write1ThroughN_While(7);
        //Write1ThroughN_For(3);
        //WriteNThrough1_While(9);
        //WriteNThrough1_For(8);
        //WriteEvensThrough100();
        //FindSum(10);
        OutputRightTriangle(0);
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
        int i = 1;
        while(i <= 100)
        {
            i++;
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void FindSum(int n)
    {
        
    }

    public static void OutputRightTriangle(int height) 
    {
        if(height > 0)
        {
            for (int row = 1; row <= height; row++) //row starts at 1, while row is less than or equal to the height it goes over another asterisk
            {
                for (int col = 1; col<= row; col++) //same as above but the other direction
                {
                    Console.Write("*"); //writes another * w/o starting new line
                }

                Console.WriteLine(); //starts another line after previous row is done
            }
        }
        else if(height == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            for (int row = 1; row >= height; row--)
            {
                for (int col = 1; col >= height; col--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}