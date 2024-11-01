using System;
using System.Collections.Generic;

namespace lapTrinh.NETThucHanh
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }
        public double DiemTB { get; set; }
        public string HocLuc { get; set; }

        // Tính điểm trung bình
        public void TinhDiemTrungBinh()
        {
            DiemTB = (DiemToan + DiemLy + DiemHoa) / 3;
        }

        // Xếp loại học lực
        public void XepLoaiHocLuc()
        {
            if (DiemTB >= 8.0) HocLuc = "Giỏi";
            else if (DiemTB >= 6.5) HocLuc = "Khá";
            else if (DiemTB >= 5.0) HocLuc = "Trung bình";
            else HocLuc = "Yếu";
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}, Sex: {Sex}");
            Console.WriteLine($"Điểm Toán: {DiemToan}, Lý: {DiemLy}, Hóa: {DiemHoa}, TB: {DiemTB:F2}");
            Console.WriteLine($"Học lực: {HocLuc}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            // Thêm một số sinh viên vào danh sách
            students.Add(new Student { ID = 1, Name = "Nguyen Van A", Sex = "Nam", Age = 20, DiemToan = 7.5, DiemLy = 8.0, DiemHoa = 6.5 });
            students.Add(new Student { ID = 2, Name = "Tran Thi B", Sex = "Nữ", Age = 19, DiemToan = 9.0, DiemLy = 8.5, DiemHoa = 9.5 });

            // Tính điểm trung bình và xếp loại học lực cho từng sinh viên
            foreach (var student in students)
            {
                student.TinhDiemTrungBinh();
                student.XepLoaiHocLuc();
                student.DisplayInfo();
            }

            Console.ReadLine();
        }
    }
}
