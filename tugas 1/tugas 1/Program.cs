using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_1
{
    internal class Program
    {
        // Fungsi Kali: menerima tiga bilangan dan menampilkan hasil perkalian
        static void Kali(double a, double b, double c)
        {
            double hasil = a * b * c;
            Console.WriteLine("Hasil perkalian dari {0}, {1}, dan {2} adalah: {3}", a, b, c, hasil);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Perkalian Tiga Bilangan ===");

            Console.Write("Masukkan bilangan pertama: ");
            double angka1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan bilangan kedua: ");
            double angka2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan bilangan ketiga: ");
            double angka3 = Convert.ToDouble(Console.ReadLine());

            // Panggil fungsi Kali
            Kali(angka1, angka2, angka3);
        }
    }
}