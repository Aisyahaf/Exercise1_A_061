using System;

namespace Exercise1
{
    class Program
    {
        //deklarasi array int dengan ukuran 27
        private int[] aisah = new int[27];
        //deklarasi variabel int untuk menyimpan banyaknya data yang aada pada array
        private int n;
        //method untuk menerima masukan
        public void Read()
        {
            //menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while(true)
            {
                Console.Write("Masukkan banyaknya elemen pada array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 27) 
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 27 elemen. \n");
            }
            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("Masukkan elemen array : ");
            Console.WriteLine("------------------------");
            //memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                aisah[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Elemen array yang telah tersusun");
            Console.WriteLine("--------------------------------");
            for (int AF = 0; AF < n; AF++)
            {
                Console.WriteLine(aisah[AF]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
           //pada pass i, bandingkan n -1 elemen dengan elemen selanjutnya
            for (int i = 1 ; i < n - 1; i++)
            {
                for (int AF = 0; AF < n - 2; AF++)
                {
                    if (aisah[i] < aisah[AF])
                        break;
                    else
                        AF = i;

                    if (aisah[AF] > aisah[i])
                    {
                        int temp;
                        temp = aisah[AF];
                        aisah[AF] = aisah[i];
                        aisah[i] = temp;
                    }
                }

            }

        }
        static void Main(string[] args)
        {
            Program Exe = new Program();

            Exe.Read();

            Exe.BubbleSortArray();

            Exe.display();

            Console.WriteLine("\n\nTekan Enter untuk keluar.");
            Console.Read();
        }

    }
}
