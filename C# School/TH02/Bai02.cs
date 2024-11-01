using System;

class Program
{
    static void Main()
    {
        // Nhập kích thước của ma trận vuông
        Console.Write("Nhập kích thước của ma trận vuông: ");
        int n = int.Parse(Console.ReadLine());

        // Khai báo ma trận vuông kích thước n x n
        int[,] matrix = new int[n, n];

        // Nhập các phần tử cho ma trận
        Console.WriteLine("Nhập các phần tử cho ma trận:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Nhập phần tử tại vị trí [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Tính tổng các phần tử trên đường chéo chính
        int sumDiagonal = 0;
        for (int i = 0; i < n; i++)
        {
            sumDiagonal += matrix[i, i];  // Các phần tử trên đường chéo chính có chỉ số hàng = chỉ số cột
        }

        // In kết quả tổng của đường chéo chính
        Console.WriteLine($"\nTổng các phần tử trên đường chéo chính của ma trận là: {sumDiagonal}");
    }
}
