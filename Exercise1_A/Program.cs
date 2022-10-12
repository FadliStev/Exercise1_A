using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_A
{
    class ExerProgram
    {
        //Deklarasi array int dengan ukuran 20
        private int[] Fad = new int[20];

        //Deklarasi variabel int untuk menyimpan banyaknya data pada array 
        private int n;

        //Fungsi / Method untuk menerima masukan 
        public void baca()
        {
            //Menerima angka untuk menentukan banyaknya data yang disimpan pada array 
            while (true)
            {
                Console.Write("Sialhkan Masukkan Banyaknya Elemen Pada Array : ");
                string e = Console.ReadLine();
                n = Int32.Parse(e);
                if (n <= 4)
                    break;
                else
                    Console.Write("\n\tArray Hanya Dapat Dimasukkan Maksimal 4 Elemen");
            }

            Console.WriteLine("");
            Console.WriteLine("Masukkan Elemen Array");

            //User memasukkan elemen pada array 
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string e1 = Console.ReadLine();
                Fad[i] = Int32.Parse(e1);
            }
        }

        public void display()
        {
            //Menampilkan array yang tersusun 
            Console.WriteLine("");
            Console.WriteLine("Elemen Telah Tersusun");

            for (int wf = 0; wf < n; wf++)
            {
                Console.WriteLine(Fad[wf]);
            }
            Console.WriteLine();

        }

        public void SortArray()
        {
            
            for (int i = 1; i <n; i++) //For n-1 passes
            {
                //menambahkan variabel untuk array kosong
                int temp;


                for (int wf = 0; wf < n - i; wf++)
                {
                   

                    if (Fad[wf] < Fad [wf + 1])   // Jika elemen pada urutan yang salah
                    {
                        //tukar elemen 
                        temp = Fad[wf];
                        Fad[wf] = Fad[wf + 1];
                        Fad[wf + 1] = temp;

                    }
                }

            }
            

        }
        static void Main(string[] args)
        {
            //Membuat objek SortArray class
            ExerProgram SortExer = new ExerProgram();

            //Pemanggilan fungsi untuk menerima elemen array 
            SortExer.baca();

            //Pemanggilan fungsi untuk mengurutkan array
            SortExer.display();

            //Pemanggilan fungsi untuk menampilkan array yang tersusun
            SortExer.SortArray();

            //Keluar dari program
            Console.WriteLine("Tekan Sembarang Untuk Keluar");
            Console.Read();
        }
    }
}
