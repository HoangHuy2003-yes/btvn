using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, b, h, thetich;

                while (true)
                {
                    Console.Write("Nhap ban kinh day lon = : ");
                    if (double.TryParse(Console.ReadLine(), out a) && a > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Nhap sai roi , nhap lai!");
                }

                while (true)
                {
                    Console.Write("Nhap ban kinh day nho cao : ");
                    if (double.TryParse(Console.ReadLine(), out b) && b > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Nhap sai roi , nhap lai!");
                }

                while (true)
                {
                    Console.Write("Nhap chieu cao : ");
                    if (double.TryParse(Console.ReadLine(), out h) && h > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Nhap sai roi , nhap lai!");
                }

                thetich = Math.PI * (a * a + b * b + a * b) * h / 3;
                Console.WriteLine($"The tich hinh non cut la : {thetich}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
