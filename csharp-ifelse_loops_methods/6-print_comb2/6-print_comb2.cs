using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 99; i++)
        {
            int n = i % 10;
            int m = i / 10;

            if (n != m && m < n)
                {
                    if (i != 89)
                        Console.Write("{0:D2}, ", i);
                    else
                        Console.WriteLine("{0:D2}", i);
                }
        }
    }
}