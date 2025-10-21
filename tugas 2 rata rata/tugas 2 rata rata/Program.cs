using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_2_rata_rata
{
    internal class Program
    {
        // Fungsi RataRata: menerima tiga nilai dan mengembalikan hasil rata-ratanya
        static double RataRata(double a, double b, double c)
        {
            double hasil = (a + b + c) / 3;
            return hasil; // mengembalikan nilai hasil rata-rata
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Menghitung Rata-Rata Tiga Nilai ===");

            Console.Write("Masukkan nilai pertama: ");
            double nilai1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan nilai kedua: ");
            double nilai2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan nilai ketiga: ");
            double nilai3 = Convert.ToDouble(Console.ReadLine());

            // Panggil fungsi RataRata dan tampilkan hasilnya
            double hasilRata = RataRata(nilai1, nilai2, nilai3);
            Console.WriteLine("Rata-rata dari {0}, {1}, dan {2} adalah: {3}", nilai1, nilai2, nilai3, hasilRata);
        }
    }
}
