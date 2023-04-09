using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemPTu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] list = new int[10] {10,4,6,7,8,0,0,0,0,0};
            int giaTri, thuTu;
            Console.WriteLine("Cho dãy sau:");
            foreach (int i in list)
            {
             Console.Write(i+"\t");
            }
            Console.WriteLine();
            Console.WriteLine("Giá trị muốn chèn");
            giaTri=int.Parse(Console.ReadLine());
            Console.WriteLine("Vị trí muốn chèn");
            thuTu=int.Parse(Console.ReadLine());
            if (thuTu<=1 || thuTu >= (list.Length - 1))
            {
                Console.WriteLine("Không chèn được vào mảng");
            }
            for (int i = (list.Length - 1); i > thuTu ; i--)
            {
                list[i] = list[i-1];
            }
            list[thuTu] = giaTri;
            Console.WriteLine($"Dãy sau khi chèn giá trị {giaTri} vào vị trí {thuTu} :");
            foreach (int i in list)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();

        }
    }
}
