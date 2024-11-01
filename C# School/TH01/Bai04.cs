using System;

class Program
{
    static void Main()
    {
        // Nhập số lượng phần tử ban đầu của mảng
        Console.Write("Nhập số lượng phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());

        // Khai báo và khởi tạo mảng với n phần tử
        int[] arr = new int[n];

        // Nhập các phần tử cho mảng
        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phần tử {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Nhập phần tử cần chèn thêm
        Console.Write("Nhập phần tử cần chèn thêm: ");
        int newElement = int.Parse(Console.ReadLine());

        // Tạo mảng mới có kích thước lớn hơn mảng ban đầu 1 phần tử
        int[] newArr = new int[n + 1];

        // Sao chép các phần tử từ mảng cũ sang mảng mới
        for (int i = 0; i < n; i++)
        {
            newArr[i] = arr[i];
        }

        // Thêm phần tử mới vào cuối mảng
        newArr[n] = newElement;

        // In các phần tử của mảng sau khi đã chèn thêm
        Console.WriteLine("Mảng sau khi chèn thêm phần tử:");
        foreach (int element in newArr)
        {
            Console.Write(element + " ");
        }
    }
}
