using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIK__3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Contoh Operator Logika ===");

            Console.Write("Masukkan angka pertama: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\n--- Hasil Operator Logika ---");
            Console.WriteLine($" {a} > 5 && {b} < 10 : " + (a > 5 && b < 10));
            Console.WriteLine($" {a} > 5 || {b} < 10 : " + (a > 5 || b < 10));
            Console.WriteLine($" !({a} > {b}) : " + (!(a > b)));
        }
    }
}
