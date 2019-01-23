using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bangun2D panggil;
            Console.WriteLine("Perhitungan Luas Lingkaran");
            Console.WriteLine("============================");
            Console.WriteLine("1. Lingkaran");
            Console.WriteLine("2. Segitiga");
            Console.WriteLine("3. Persegi");
            Console.WriteLine("4. Persegi Panjang");
            Console.WriteLine("============================");
            Console.Write("Masukkan pilihan anda (1-4): ");
            string pilihan = Console.ReadLine();
            int i = Convert.ToInt16(pilihan);
            switch (i)
            {
                case 1:
                    Console.Write("Masukkan Nilai Jari-jari:");
                    double jari = Convert.ToDouble(Console.ReadLine());
                    panggil = new Lingkaran(jari);
                    panggil.CetakLuas("Lingkaran;");
                    Console.Read();
                    break;
                case 2:
                    Console.WriteLine("Masukkan Nilai Alas:");
                    double alas = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Masukkan Nilai Tinggi");
                    double tinggis = Convert.ToDouble(Console.ReadLine());
                    panggil = new Segitiga(alas, tinggis);
                    panggil.CetakLuas("Segitiga;");
                    Console.Read();
                    break;
                case 3:
                    Console.Write("Masukkan Nilai Sisi:");
                    double sisi = Convert.ToDouble(Console.ReadLine());
                    panggil = new Persegi(sisi);
                    panggil.CetakLuas("Persegi;");
                    Console.Read();
                    break;
                case 4:
                    Console.WriteLine("Masukkan Nilai Alas:");
                    double panjang = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Masukkan Nilai Tinggi");
                    double tinggip = Convert.ToDouble(Console.ReadLine());
                    panggil = new Persegipanjang(panjang, tinggip);
                    panggil.CetakLuas("Persegipanjang;");
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("Pilihan tidak ada -GOOD BYE-");
                    break;

            }
            Console.ReadLine();
        }
    }
}
