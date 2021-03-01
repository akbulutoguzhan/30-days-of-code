using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] strings = new string[n];
        
        for(int i = 0; i < n; i++) strings[i] = Console.ReadLine();
        
        for(int i = 0; i < n; i++)
        {
            for(int e = 0; e < strings[i].Length; e += 2) Console.Write(strings[i][e]);
            
            Console.Write(" ");
            
            for(int o = 1; o < strings[i].Length; o += 2) Console.Write(strings[i][o]);
            
            Console.WriteLine();
                
        }
    }
}
