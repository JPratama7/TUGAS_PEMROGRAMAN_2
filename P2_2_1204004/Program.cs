using System;

namespace P2_2_1204004
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Elektronik hp = new Elektronik("Oppo M1 X PRO", "DC");
            Elektronik kipas = new Elektronik("COSMOS SUPREME", "AC");
            Makanan nasi_kuning = new Makanan("Nasi Kuning", "150");
            Makanan mie_sedap = new Makanan("Mie Sedap Goreng", "400");

            Console.WriteLine("Produk  1 bernama {0} berupa {1} dan memiliki\"{2}\" kalori", nasi_kuning.Nama, nasi_kuning.Tipe, nasi_kuning.Kalori);
            Console.WriteLine("Produk  2 bernama {0} berupa {1} dan memiliki\"{2}\" kalori", mie_sedap.Nama, mie_sedap.Tipe, mie_sedap.Kalori);
            Console.WriteLine("Produk  3 bernama {0} berupa {1} dan menggunakan tipe aliran listrk \"{2}\"", hp.Nama, hp.Tipe, hp.Tipe_Listrik);
            Console.WriteLine("Produk  4 bernama {0} berupa {1} dan menggunakan tipe aliran listrk \"{2}\"", kipas.Nama, kipas.Tipe, kipas.Tipe_Listrik);



        }
    }
}
