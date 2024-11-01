using System;

class Program
{
    static void Main()
    {
        // Khai báo và khởi tạo mảng với 5 phần tử
        int[] arr = new int[5];

        // Nhập các phần tử vào mảng
        Console.WriteLine("Nhập 5 phần tử vào mảng:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Phần tử {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // In các phần tử trong mảng ra màn hình
        Console.WriteLine("Các phần tử trong mảng là:");
        foreach (int element in arr)
        {
            Console.WriteLine(element);
        }
    }
}
