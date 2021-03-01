using System;			
public class Program
{
	public static void Main()
	{
		int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        Console.WriteLine(result);
	}
	
	public static int hourglassSum(int[][] arr) {
        int maxSum = int.MinValue;
        int rows = arr.Length - 2;
        for(int j = 0; j < rows; j++){
            int columns = arr[j].Length - 2;
            
            for(int k = 0; k < columns; k++){
                int sum = arr[j][k] + arr[j][k+1] + arr[j][k+2]
                                    + arr[j+1][k+1]
                    + arr[j+2][k] + arr[j+2][k+1] + arr[j+2][k+2];
                
                if(maxSum < sum){
                    maxSum = sum;
                }
            }
        }
        return maxSum;
    }
}