using System;

class Program
{
    static void Main()
    {
        // Khai báo và khởi tạo hai mảng có cùng kích thước
        int[] arr1 = new int[5];
        int[] arr2 = new int[5];

        // Nhập các phần tử cho mảng arr1
        Console.WriteLine("Nhập các phần tử cho mảng thứ nhất:");
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write($"Phần tử {i + 1} của mảng thứ nhất: ");
            arr1[i] = int.Parse(Console.ReadLine());
        }

        // Nhập các phần tử cho mảng arr2
        Console.WriteLine("Nhập các phần tử cho mảng thứ hai:");
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write($"Phần tử {i + 1} của mảng thứ hai: ");
            arr2[i] = int.Parse(Console.ReadLine());
        }

        // Khai báo mảng trộn có kích thước bằng tổng kích thước của arr1 và arr2
        int[] mergedArray = new int[arr1.Length + arr2.Length];

        // Sao chép các phần tử của arr1 và arr2 vào mergedArray
        arr1.CopyTo(mergedArray, 0); // Sao chép arr1 vào vị trí bắt đầu của mergedArray
        arr2.CopyTo(mergedArray, arr1.Length); // Sao chép arr2 vào vị trí tiếp theo sau arr1

        // Sắp xếp mảng trộn theo thứ tự tăng dần
        Array.Sort(mergedArray);

        // In các phần tử của mảng đã sắp xếp
        Console.WriteLine("Mảng trộn sau khi sắp xếp theo thứ tự tăng dần:");
        foreach (int element in mergedArray)
        {
            Console.WriteLine(element);
        }
    }
}
