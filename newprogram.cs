using System;

namespace syech
{
    class staff
    {
        public int b;
        class Dokter : staff
        {
            public void dokter()
            {
                Console.Clear();
                Console.WriteLine("Halaman Dokter");
                Console.WriteLine("Menu :");
                Console.WriteLine("1. Rekam Medis Pasien");
                Console.WriteLine("2. Profile Dokter");
                Console.WriteLine("0. Exit");
                Console.Write("Pilihan = ");
                b = Convert.ToInt32(Console.ReadLine());
                switch (b)
                {
                    case 1:
                        Console.WriteLine("Halaman Rekam Medis Pasien");
                        Console.WriteLine("Nomor Pasien     : {0}", "17111122");
                        Console.WriteLine("Nama             : {0}", "Wadaw");
                        Console.WriteLine("Tempat,Tgl-lahir : {0},{1}", "Medan", "11-10-1998");
                        Console.WriteLine("Tipe Pasien      : {0}", "Super Duper VVVIP");
                        Console.WriteLine("Asuransi BPJS    : {0}", "1273928173921");
                        Console.WriteLine("No Handphone     : {0}", "08126655421");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Halaman Profile Dokter");
                        break;
                }
            }
        }
        class Adm : staff
        {
            public void adm()
            {
                Console.WriteLine("Halaman Administrasi");
                Console.WriteLine("Menu :");
                Console.WriteLine("1. List Data Pasien");
                Console.WriteLine("2. Tambah Data Pasien");
                Console.WriteLine("3. Edit Data Pasien");
                Console.WriteLine("4. Rekam Medis Pasien");
                Console.WriteLine("5. Tambah Data Administrasi");
                Console.WriteLine("6. Edit Data Administrasi");
                Console.WriteLine("7. Rekam Medis Pasien");
                Console.WriteLine("8. Profile Administrasi");
                Console.WriteLine("0. Exit");
                Console.Write("Pilihan = ");

                //if input 2 -- Adm -- List Data Pasien
                Console.WriteLine("List Data Pasien");
                Console.WriteLine("Nomor Pasien\tNama Pasien\tTipe Pasien\tAsuransi BPJS\tNo HP");
                Console.WriteLine("128789137\tFeby Guso\tVIP\t\t12312321\t21830918");
                Console.WriteLine("128789137\tFeby Guso\tVIP\t\t12312321\t21830918");
                Console.WriteLine("128789137\tFeby Guso\tVIP\t\t12312321\t21830918");
                Console.WriteLine("128789137\tFeby Guso\tVIP\t\t12312321\t21830918");
                //if input 2 -- Adm -- Tambah Data Pasien
                Console.WriteLine("List Data Pasien");
                Console.Write("Nomor Pasien     : ");
                Console.ReadLine();
                Console.Write("Nama             : ");
                Console.ReadLine();
                Console.Write("Tempat,Tgl-lahir : ");
                Console.ReadLine();
                Console.Write("Tipe Pasien      : ");
                Console.ReadLine();
                Console.Write("Asuransi BPJS    : ");
                Console.ReadLine();
                Console.Write("No Handphone     : ");
                Console.ReadLine();
                //if input 2 -- Adm -- Hapus Data Pasien
                Console.WriteLine("Edit Data Pasien");
                Console.Write("Nomor Pasien     : ");
                //pertama masukkan Nomor Pasien, jika sesuai maka tampilkan deskripsi dari nomor pasien,jika tidak maka berikan pesan "Obat Tidak Ada"

                Console.Write("Nama             : {0}", 12333);
                Console.Write("Tempat,Tgl-lahir : {0}", 111);
                Console.Write("Tipe Pasien      : {0}", 123);
                Console.Write("Asuransi BPJS    : {0}", 123);
                Console.Write("No Handphone     : {0}", 123);
                Console.Write("/nBerhasil Dihapus!");
                Console.ReadLine();
                Console.ReadLine();

                Console.Write("Nama             : ");
                Console.ReadLine();
                Console.Write("Tempat,Tgl-lahir : ");
                Console.ReadLine();
                Console.Write("Tipe Pasien      : ");
                Console.ReadLine();
                Console.Write("Asuransi BPJS    : ");
                Console.ReadLine();
                Console.Write("No Handphone     : ");
                Console.ReadLine();
                Console.ReadKey();
            }
        }
        class Admin : staff
        {
            public void admin()
            {
                Console.WriteLine("Halaman Admin");
                Console.WriteLine("Menu :");
                Console.WriteLine("1. Tambah Staff");//struktur mirip tambah obat
                Console.WriteLine("2. Hapus Staff");//struktur mirip hapus obat
                Console.WriteLine("3. Edit Staff");//struktur mirip edit obat
                Console.WriteLine("0. Exit");
                Console.Write("Pilihan = ");
            }
        }
        class MainClass
        {
            public static void Main(string[] args)
            {
                string nama, password;
                int a;
                Console.WriteLine("Selamat Datang di Puskesmas Suka Hati");
                Console.WriteLine("Menu :");
                Console.WriteLine("1. Sign In");
                Console.WriteLine("0. Exit");
                Console.Write("Pilihan = ");
                a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Sign In Page");
                    Console.Write("Username : ");
                    nama = Console.ReadLine();
                    Console.Write("Password : ");
                    password = Console.ReadLine();
                    if (nama == "st" && password == "st")
                    {
                        staff nilai = new staff();
                        Console.Clear();
                        Console.WriteLine("Selamat Datang {0}", "Cih Nakal");
                        Console.WriteLine("Menu :");
                        Console.WriteLine("1. Dokter");
                        Console.WriteLine("2. Administrasi");
                        Console.WriteLine("0. Exit");
                        ///Admin disembunyinya (demi keamanan),nanti buat aja untuk admin nilainya 7527
                        Console.Write("Pilihan = ");
                        nilai.b = int.Parse(Console.ReadLine());
                        if (nilai.b == 1)
                        {
                            Dokter dokterr = new Dokter();
                            dokterr.dokter();
                        }
                        else if (nilai.b == 2)
                        {
                            Adm admm = new Adm();
                            admm.adm();
                        }
                        else if (nilai.b == 3)
                        {
                            Admin adminn = new Admin();
                            adminn.admin();
                        }

                    }
                }
            }
        }
    }
}
