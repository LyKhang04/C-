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

        // Khai báo hai ma trận kích thước rows x cols
        int[,] matrix1 = new int[rows, cols];
        int[,] matrix2 = new int[rows, cols];

        // Nhập các phần tử cho ma trận 1
        Console.WriteLine("Nhập các phần tử cho ma trận 1:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Nhập phần tử tại vị trí [{i},{j}] của ma trận 1: ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Nhập các phần tử cho ma trận 2
        Console.WriteLine("Nhập các phần tử cho ma trận 2:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Nhập phần tử tại vị trí [{i},{j}] của ma trận 2: ");
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // So sánh hai ma trận
        bool areEqual = true;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix1[i, j] != matrix2[i, j])
                {
                    areEqual = false;
                    break; // Dừng lại khi tìm thấy sự khác biệt
                }
            }
            if (!areEqual)
                break;
        }

        // In kết quả so sánh
        if (areEqual)
        {
            Console.WriteLine("\nHai ma trận bằng nhau.");
        }
        else
        {
            Console.WriteLine("\nHai ma trận không bằng nhau.");
        }
    }
}
