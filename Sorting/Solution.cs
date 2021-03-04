using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        
        int numSwaps = 0;
        for (int i = 0; i < n; i++)
        {
            int numSwapsRound = 0;
            
            for (int j = 0; j < n - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    numSwapsRound++;
                }
            }
            
            if (numSwapsRound == 0)
            {
                break;
            }
            else
            {
                numSwaps += numSwapsRound;
            }
        }
        
        Console.WriteLine("Array is sorted in {0} swaps.\nFirst Element: {1}\nLast Element: {2}", numSwaps, a[0], a[n - 1]);
    }
}
