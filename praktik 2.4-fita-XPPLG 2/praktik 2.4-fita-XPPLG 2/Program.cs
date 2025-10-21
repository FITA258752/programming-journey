using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_2._4_fita_XPPLG_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // deklarasi variabel
            string nama_siswa = "Rizki Ulinuha";
            string jk = "Laki-Laki";
            int umur = 16;
            int nilai = 85;
            char grade = 'B';
            double tb = 170.5;
            bool lulus = true;

            // menampilkan variabel
            Console.WriteLine("Nama Siswa   :" + nama_siswa);
            Console.WriteLine("Jenis Kelamin:" + jk);
            Console.WriteLine("Umur         :" + umur);
            Console.WriteLine("Nilai        :" + nilai);
            Console.WriteLine("Grade nilai  :" + grade);
            Console.WriteLine("Tinggi badan :" + tb + "cm");
            Console.WriteLine("Lulus        :" + lulus);
        }
    }
}
