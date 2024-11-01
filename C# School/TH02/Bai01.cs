using System;

class Program
{
    static void Main()
    {
        // Khai báo mảng 2 chiều 3x3
        int[,] arr = new int[3, 3];

        // Nhập các phần tử cho mảng
        Console.WriteLine("Nhập các phần tử cho mảng 3x3:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Nhập phần tử tại vị trí [{i},{j}]: ");
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // In các phần tử của mảng ra màn hình
        Console.WriteLine("\nCác phần tử trong mảng 3x3 là:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
