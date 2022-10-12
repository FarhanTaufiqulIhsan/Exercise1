using System;
 namespace Exercise_Algorithms
{

    class Program
    {
        // Deklarasi array int dengan ukuran 35
        private int[] farhan = new int[35];

        //Deklarasi variabel int untuk menyimpan banyak data pada array
        private int n;
        
        // Fungsi / Method untuk menerima masukan atau input

        public void read()
        {
            // Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 35)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 35 elemen.\n");

            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                farhan[i]=int.Parse(s1);
            }
        }

        public void display()
        {
            // Menampilkan array yang dimasukkan
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(" Elemen array yang telah tersusun");
            Console.WriteLine("---------------------------------");
            for (int fi = 0; fi < n; fi++)
            {
                Console.WriteLine(farhan[fi]);
            }
            Console.WriteLine("");
        }

        public void ArrayAlgorithm()
        {
            for (int i =0; i < n; i++) // For n - 1 passes
            {
                // Pada pass i, bandingkan n - i elemen

                for (int fi=0; fi < n; fi++)
                {
                    if (farhan[fi] < farhan[n-1])
                    {
                        // Tukar elemen
                        int temp;
                        temp = farhan[fi];
                        farhan[fi] = farhan[n-1];
                        farhan[n-1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Membuat objek dari kelas program
            Program algorithm = new Program();

            // pemanggilan fungsi untuk menerima elemen array
            algorithm.read();
            // Pemanggilan fungsi untuk menerima elemen array
            algorithm.ArrayAlgorithm();
            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            algorithm.display();
            // Exit
            Console.WriteLine("\n\nTekan tombol apa saja untuk keluar kecuali tombol power.");
            Console.ReadKey();
        }
    }
}