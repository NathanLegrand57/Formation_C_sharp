using System;

class Program
{
    public static void Main(string[] args)
    {/* 
        int[] arr = { 1, 2, 5 };
        Console.WriteLine(arr[2]);

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] += 1;
            Console.WriteLine(arr[i]);
        } */

        int[][] arr = new int[2][];

        arr[0] = new int[]{1,2,3};
        arr[1] = new int[]{4,5,6,7,};

        /* foreach (var subarray in arr)
        {
            foreach (var item in subarray)
            {
                Console.WriteLine(item);
            }
        } */
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.WriteLine(arr[i][j]);
            }
        }
    }
}