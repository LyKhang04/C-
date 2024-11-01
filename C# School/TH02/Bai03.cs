using System;

class Program
{
    static void Main()
    {
        // Nhập kích thước của ma trận
        Console.Write("Nhập số hàng của ma trận: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Nhập số cột của ma trận: ");
        int cols = int.Parse(Console.ReadLine());

        // Khai báo ma trận kích thước rows x cols
        int[,] matrix = new int[rows, cols];

        // Nhập các phần tử cho ma trận
        Console.WriteLine("Nhập các phần tử cho ma trận:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Nhập phần tử tại vị trí [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Tính tổng các hàng
        Console.WriteLine("\nTổng của các hàng:");
        for (int i = 0; i < rows; i++)
        {
            int sumRow = 0;
            for (int j = 0; j < cols; j++)
            {
                sumRow += matrix[i, j];
            }
            Console.WriteLine($"Tổng của hàng {i + 1}: {sumRow}");
        }

        // Tính tổng các cột
        Console.WriteLine("\nTổng của các cột:");
        for (int j = 0; j < cols; j++)
        {
            int sumCol = 0;
            for (int i = 0; i < rows; i++)
            {
                sumCol += matrix[i, j];
            }
            Console.WriteLine($"Tổng của cột {j + 1}: {sumCol}");
        }
    }
}
