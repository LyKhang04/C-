using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Nhập số lượng phần tử trong mảng
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());

        // Khai báo và khởi tạo mảng
        int[] arr = new int[n];

        // Nhập các phần tử vào mảng
        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Phần tử {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Sử dụng Dictionary để đếm số lần xuất hiện của từng phần tử
        Dictionary<int, int> frequency = new Dictionary<int, int>();

        foreach (int element in arr)
        {
            if (frequency.ContainsKey(element))
            {
                // Nếu phần tử đã tồn tại, tăng số lần xuất hiện
                frequency[element]++;
            }
            else
            {
                // Nếu phần tử chưa tồn tại, thêm phần tử với số lần xuất hiện là 1
                frequency[element] = 1;
            }
        }

        // In kết quả
        Console.WriteLine("Số lần xuất hiện của từng phần tử trong mảng:");
        foreach (var item in frequency)
        {
            Console.WriteLine($"Phần tử {item.Key} xuất hiện {item.Value} lần.");
        }
    }
}
