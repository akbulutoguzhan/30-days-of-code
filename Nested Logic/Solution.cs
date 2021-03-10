using System;
class Solution
{
    static void Main(String[] args)
    {
        string[] inputReturn = Console.ReadLine().Split(' ');
        string[] inputExpected = Console.ReadLine().Split(' ');
        
        int[] returnDate = new int[3];
        int[] expectedDate = new int[3];
        
        for (int i = 0; i < 3; i++)
        {
            returnDate[i] = int.Parse(inputReturn[i]);
            expectedDate[i] = int.Parse(inputExpected[i]);
            
        }

        int fine = 0;

        if (returnDate[2] > expectedDate[2])
        {
            fine = 10000;
        }
        else if (returnDate[2] == expectedDate[2])
        {
            if (returnDate[1] > expectedDate[1])
            {
                fine = (returnDate[1] - expectedDate[1]) * 500;
            }
            else if (returnDate[1] == expectedDate[1] && returnDate[0] > expectedDate[0])
            {
                fine = (returnDate[0] - expectedDate[0]) * 15;
            }
        }

        Console.WriteLine(fine);
    }
}
