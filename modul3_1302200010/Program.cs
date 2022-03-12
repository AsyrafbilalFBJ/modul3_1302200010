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
    enum State { Berdiri, Jongkok, Tengkurap, Terbang, Keluar };
    class PosisiKarakterGame
    {
        public static void posisiKarakterGame()
        {
            State state = State.Berdiri;
            string[] screenName = { "Berdiri", "Jongkok", "Tengkurap", "Terbang", "Keluar" };
            while (state != State.Keluar)
            {
                Console.WriteLine(screenName[(int)state]);
                Console.Write("Enter Command : ");
                ConsoleKeyInfo command = Console.ReadKey();
                if(command.Key == ConsoleKey.S)
                {
                    Console.WriteLine("\ntombol arah bawah ditekan\n");
                }
                if (command.Key == ConsoleKey.W)
                {
                    Console.WriteLine("\ntombol arah atas ditekan\n");
                }
                switch (state)
                {
                    case State.Berdiri:
                        if (command.Key == ConsoleKey.W)
                            state = State.Terbang;
                        else if (command.Key == ConsoleKey.S)
                            state = State.Jongkok;
                        //else if (command == "Keluar")
                        //    state = State.Keluar;
                        else
                            state = State.Berdiri;
                        break;
                    case State.Tengkurap:
                        if (command.Key == ConsoleKey.W)
                            state = State.Jongkok;
                        //else if (command == "Keluar")
                        //    state = State.Keluar;
                        else
                            state = State.Tengkurap;
                        break;
                    case State.Jongkok:
                        if (command.Key == ConsoleKey.W)
                            state = State.Berdiri;
                        else if (command.Key == ConsoleKey.S)
                            state = State.Tengkurap;
                        //else if (command == "Keluar")
                        //    state = State.Keluar;
                        else
                            state = State.Jongkok;
                        break;
                    case State.Terbang:
                        if (command.Key == ConsoleKey.S)
                            state = State.Berdiri;
                        else if (command.Key == ConsoleKey.X)
                        {
                            Console.WriteLine("\n");
                            state = State.Jongkok;
                        }
                        //else if (command == "Keluar")
                        //    state = State.Keluar;
                        else
                            state = State.Terbang;
                        break;
                    //case State.Keluar:
                    //    break;
                }
            }
            Console.WriteLine("Anda Keluar");
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

            Console.WriteLine();
            PosisiKarakterGame.posisiKarakterGame();
            Console.ReadKey();
        }
    }
}
