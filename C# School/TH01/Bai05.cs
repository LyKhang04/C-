using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Nhập số lượng phần tử của mảng
        Console.Write("Nhập số lượng phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());

        // Khai báo và khởi tạo mảng
        int[] arr = new int[n];

        // Nhập các phần tử của mảng
        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phần tử {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Khai báo hai danh sách để lưu số chẵn và số lẻ
        List<int> evenList = new List<int>();
        List<int> oddList = new List<int>();

        // Phân loại các phần tử vào danh sách chẵn và lẻ
        foreach (int element in arr)
        {
            if (element % 2 == 0)
                evenList.Add(element); // Thêm vào danh sách chẵn
            else
                oddList.Add(element);  // Thêm vào danh sách lẻ
        }

        // In mảng chẵn
        Console.WriteLine("Các phần tử chẵn:");
        foreach (int even in evenList)
        {
            Console.Write(even + " ");
        }
        Console.WriteLine(); // Xuống dòng

        // In mảng lẻ
        Console.WriteLine("Các phần tử lẻ:");
        foreach (int odd in oddList)
        {
            Console.Write(odd + " ");
        }
        Console.WriteLine();
    }
}
