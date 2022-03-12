using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302200010
{
    class KodeBuah
    {
        public static string GetKodeBuah(string k)
        {
            string[] buah = { "Apel", "Aprikot", "Alpukat", "Pisang", "Paprika", "Blackberry",
                "Ceri", "Kelapa", "Jagung", "Kurma", "Durian", "Anggur", "Melon", "Semangka"};
            string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
            int jumlahKelurahan = buah.Length - 1;
            string hasil = "";
            int i = 0;
            while (i < jumlahKelurahan)
            {
                if (k == buah[i])
                {
                    hasil = kodeBuah[i];
                }
                i++;
            }
            return hasil;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan Nama Buah    : ");
            string buah = Console.ReadLine();
            Console.Write("Kode Pos             : ");
            Console.WriteLine(KodeBuah.GetKodeBuah(buah));


            Console.ReadKey();
        }
    }
}
