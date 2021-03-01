using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

    public Difference(int[] arr)
    {
        elements = arr;
    }
    
    public void computeDifference()
    {
        int max = elements.Max();
        int min = elements.Min();
        maximumDifference = max - min;
    }

}

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}