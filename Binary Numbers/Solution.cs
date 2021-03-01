using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    static void Main(string[] args) {

        int n = Convert.ToInt32(Console.ReadLine());
        string binary = Convert.ToString(n, 2);
        
        List<Int32> list = new List<Int32>();
        
        int count = 0;
        foreach(char c in binary)
        {
            if(count > 0 && c == '0')
            {
                list.Add(count);
                count = 0;
            }
            
            else if(c == '1') count++;
        }
        
        list.Add(count);
        
        Console.WriteLine(list.Max());
    }
}
