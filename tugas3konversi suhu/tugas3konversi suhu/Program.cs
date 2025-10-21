using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas3konversi_suhu
{
    internal class Program
    {
        // Fungsi KonversiSuhu: mengubah suhu dari Celcius ke Fahrenheit
        static double KonversiSuhu(double celcius)
        {
            double fahrenheit = (celcius * 9 / 5) + 32;
            return fahrenheit; // mengembalikan hasil konversi
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Konversi Suhu Celcius ke Fahrenheit ===");

            Console.Write("Masukkan suhu dalam Celcius: ");
            double suhuC = Convert.ToDouble(Console.ReadLine());

            // Panggil fungsi KonversiSuhu
            double suhuF = KonversiSuhu(suhuC);

            Console.WriteLine("Hasil konversi: {0}°C = {1}°F", suhuC, suhuF);
        }
    }
}
