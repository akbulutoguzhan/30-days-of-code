using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        IDictionary<string, int> phoneBook = new Dictionary<string, int>();
        int n = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < n; i++)
        {
            string[] split = Console.ReadLine().Split(' ');
            phoneBook.Add(split[0], Convert.ToInt32(split[1]));
        }
        
        string name;
        while((name = Console.ReadLine()) != null)
        {
            if(phoneBook.ContainsKey(name)) Console.WriteLine(name + "=" + phoneBook[name]);

            else Console.WriteLine("Not found");
        }
    }
}
