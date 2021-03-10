using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int testCase = Int32.Parse(Console.ReadLine());
        int[] numbers = new int[testCase];
        
        for (int i = 0; i < testCase; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        
        foreach(int i in numbers)
        {
            if (isPrime(i))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
    
    static bool isPrime(int i)
    {
        if (i == 1)
        {
            return false;
        }
        else if (i % 2 == 0 && i != 2)
        {
            return false;
        }
        else
        {
            for (int j = 3; j <= Math.Sqrt(i); j += 2)
            {
                if (i % j == 0)
                {
                    return false;
                }
            }
        }
        
        return true;
    }
}
