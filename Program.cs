using System;

public class Program
{

    public static void Main(string[]args)
    {
        Write1ThroughN_While(3);
        Write1ThroughN_For(34);
        WriteNThrough1_While(5);
        WriteNThrough1_For(9);
        WriteEvensThrough100();
        FindSum(10);
        FindSumOfEvenNumbers(4);
        FindSumOfOddNumbers(5);
        OutputRightTriangle(-10); //Bathe in my glory.... it works...
    }

    public static void Write1ThroughN_While(int n)
    {
        int i = 1;
        if (i > 0)
        {
        while (i <= n)
        {
            Console.WriteLine(i);
            i++;
        }
        }
        else
        {
            OutOfRangeMessage(n);
        }

    }

    public static void Write1ThroughN_For(int n)
    {
        if(n > 0)
        {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
        }
        else
        {
            OutOfRangeMessage(n);
        }
    }

    public static void WriteNThrough1_While(int n)
    {
        int i = 1;
        if (n > 0)
        {
        while (i<=n)
        {
            Console.WriteLine(n);
            n--;
        }
        }
        else
        {
            OutOfRangeMessage(n);
        }
    }

    public static void WriteNThrough1_For(int n)
    {
        if (n > 0)
        {
        for (int i = 1; i <= n; n--)
        {
            Console.WriteLine(n);
        }
        }
        else
        {
            OutOfRangeMessage(n);
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
        if (n == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
        int sum = 0;

        for(int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
        }
    }

    public static void FindSumOfEvenNumbers(int n)
    {
        if (n == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                else
                {
                    sum = sum + i;
                }
                Console.WriteLine(sum);
            }
        }
    }

    public static void FindSumOfOddNumbers(int n)
    {
        if (n == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    sum = sum + i;
                }
                Console.WriteLine(sum);
            }
        }
    }

    public static void OutputRightTriangle(int parameter_base) //Thank god for stack overflow :,,i
    {
        if(parameter_base > 0)
        {
            for (int row = 1; row <= parameter_base; row++) //row starts at 1, while row is less than or equal to the height it goes over another asterisk
            {
                for (int col = 1; col<= row; col++) //same as above but the other direction
                {
                    Console.Write("*"); //writes another * w/o starting new line
                }

                Console.WriteLine(); //starts another line after previous row is done
            }
        }
        else if(parameter_base == 0)
        {
            Console.WriteLine("0 is put of range.");
        }
        else //it's so over
        {
            for(int row = Math.Abs(parameter_base); row >= 1; row--) //YYYEWEEEAAAAAA I JUST HAD TO MAKE IT POSITIVE WE'RE SO BACK!!!!!
            {
                for(int col = 1; col <= row; col++) 
                {
                    Console.Write("*");
                }
            Console.WriteLine();
            }
        }
        
    }

    public static void OutOfRangeMessage(int n) //checked :thumbs-up:
    {
        Console.WriteLine($"{n} is out of range.");
    }
}
