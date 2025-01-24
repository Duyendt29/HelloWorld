using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public enum SleepStatus
    {
        Sleep = 1,
        Dream = 2,
        Deep = 3,
        Wakeup = 0
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Sử dụng enum
            SleepStatus status = SleepStatus.Dream;
            Console.WriteLine("Nhập vào trạng thái (0-3): ");
            int num = Convert.ToInt32(Console.ReadLine());
            if ((int)status == 2)
            {
                Console.WriteLine("Toi dang mơ");
            } 
            // Tính diên tích hình tròn
            /*const float pi = 3.14F;
            float r = 6;
            float area = pi * r * r;
            Console.WriteLine("area of circle = " + area);*/

            // Ép kiểu
            /*string a = "9";
            string b = "288";
            int num1 = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);
            Console.WriteLine("Tong = " + (num1 + num2));*/

            /*double a = 1.75;
            int s = (int)a;
            Console.WriteLine(s);*/
            Console.ReadLine();

        }
    }
}
