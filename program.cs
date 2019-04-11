using System;

namespace syech
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string nama,password;
            Console.WriteLine("Selamat Datang di Puskesmas Suka Hati");
            Console.WriteLine("Menu :");
            Console.WriteLine("1. Sign In");
            Console.WriteLine("0. Exit");
            Console.Write("Pilihan = ");
            //then after input 1
            Console.WriteLine("\n");
            Console.WriteLine("Sign In Page");
            Console.Write("Username : ");
            nama = Console.ReadLine();
            Console.Write("Password : ");
            password = Console.ReadLine();
            if (nama == "ap" && password == "ap") 
            {
                //!-- Apotek --!
                Console.WriteLine("\n");
                Console.WriteLine("Selamat Datang {0},var nama");
                Console.WriteLine("Menu :");
                Console.WriteLine("1. Obat");
                Console.WriteLine("2. Staff");
                Console.WriteLine("0. Exit");
                Console.Write("Pilihan = ");
                Console.ReadKey();
                //if input 1 --- Apotek
                Console.WriteLine("\n");
                Console.WriteLine("Halaman Obat");
                Console.WriteLine("Menu :");
                Console.WriteLine("1. List Obat");
                Console.WriteLine("2. Tambah Obat");
                Console.WriteLine("3. Hapus Obat");
                Console.WriteLine("4. Edit Obat");
                Console.WriteLine("5. Rekam Medis");
                Console.WriteLine("0. Exit");
                Console.Write("Pilihan = ");
                Console.ReadLine();
                //if input 1 (obat)
                Console.WriteLine("\n");
                Console.WriteLine("List Obat Page");
                Console.WriteLine("Menu :");
                Console.WriteLine("No\tNama\t\tJenis\t\tKode\t\tHarga");
                Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}", 1, "Panadol", "Paracetamol", "PR112201", 2000);
                Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}", 2, "Panadol", "Paracetamol", "PR112201", 2000);
                Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}", 3, "Panadol", "Paracetamol", "PR112201", 2000);
                Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}", 4, "Panadol", "Paracetamol", "PR112201", 2000);
                Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}", 5, "Panadol", "Paracetamol", "PR112201", 2000);
                Console.WriteLine("\n");
                Console.WriteLine("0. Exit");
                Console.Write("Pilihan = ");
                Console.ReadLine();
                //if input 2 (obat)
                Console.WriteLine("\n");
                Console.WriteLine("Tambah Obat Page");
                Console.Write("Kode Obat : ");
                Console.ReadLine();
                Console.Write("Nama  : ");
                Console.ReadLine();
                Console.Write("Jenis : ");
                Console.ReadLine();
                Console.Write("Kode  : ");
                Console.ReadLine();
                Console.Write("Harga : ");
                Console.ReadLine();
                Console.WriteLine("\n");
                //if input 3 (obat)
                Console.WriteLine("\n");
                Console.WriteLine("Hapus Obat Page");
                Console.WriteLine("Menu :");
                Console.Write("Kode Obat : ");
                //pertama masukkan kode obat, jika sesuai maka tampilkan deskripsi dari nomor pasien,jika tidak maka berikan pesan "Obat Tidak Ada"
                Console.ReadLine();
                Console.WriteLine("\n");
                //if input 4 (obat)
                Console.WriteLine("\n");
                Console.WriteLine("Edit Obat Page");
                Console.Write("Kode Obat : ");
                Console.ReadLine();
                Console.Write("Nama  : ");
                Console.ReadLine();
                Console.Write("Jenis : ");
                Console.ReadLine();
                Console.Write("Kode  : ");
                Console.ReadLine();
                Console.Write("Harga : ");
                Console.ReadLine();
                /*Stuktur Petugas sama seperti Obat (tinggal diganti sesuai keinginan*/
            }
            else if(nama == "ps" && password == "ps")
            {
                Console.WriteLine("\n");
                Console.WriteLine("Selamat Datang {0},var nama");
                Console.WriteLine("Menu :");
                Console.WriteLine("1. Profile");
                Console.WriteLine("0. Exit");
                Console.Write("Pilihan = ");
                Console.ReadLine();
                //if input 1
                Console.WriteLine("Profile Pasien Page");
                Console.WriteLine("Nomor Pasien     : {0}", "17111122");
                Console.WriteLine("Nama             : {0}", "Susi");
                Console.WriteLine("Tempat,Tgl-lahir : {0},{1}", "Susi", "11-10-1998");
                Console.WriteLine("Tipe Pasien      : {0}", "Super Duper VVVIP");
                Console.WriteLine("Asuransi BPJS    : {0}", "1273928173921");
                Console.WriteLine("No Handphone     : {0}", "08126655421");
                Console.ReadLine();
            }
            else if (nama == "st" && password == "st")
            {
                Console.WriteLine("Selamat Datang {0}","Cih Nakal");
                Console.WriteLine("Menu :");
                Console.WriteLine("1. Dokter");
                Console.WriteLine("2. Administrasi");
                Console.WriteLine("0. Exit");
                ///Admin disembunyinya (demi keamanan),nanti buat aja untuk admin nilainya 7527
                Console.Write("Pilihan = ");
                Console.ReadLine();
                //if input 1 -- Dokter
                Console.WriteLine("Halaman Dokter");
                Console.WriteLine("Menu :");
                Console.WriteLine("1. Rekam Medis Pasien");
                Console.WriteLine("2. Profile Dokter");
                Console.WriteLine("0. Exit");
                Console.Write("Pilihan = ");
                Console.ReadLine();
                //if input 1 -- Dokter -- Rekam Medis Pasien
                Console.WriteLine("Halaman Rekam Medis Pasien");
                Console.WriteLine("Nomor Pasien     : {0}", "17111122");
                Console.WriteLine("Nama             : {0}", "Susi");
                Console.WriteLine("Tempat,Tgl-lahir : {0},{1}", "Susi", "11-10-1998");
                Console.WriteLine("Tipe Pasien      : {0}", "Super Duper VVVIP");
                Console.WriteLine("Asuransi BPJS    : {0}", "1273928173921");
                Console.WriteLine("No Handphone     : {0}", "08126655421");
                Console.ReadLine();
                //if input 2 -- Dokter -- Profile Dokter
                Console.WriteLine("Halaman Profile Dokter");
                Console.WriteLine("NIP              : {0}", "17111122");
                Console.WriteLine("Nama             : {0}", "Susi");
                Console.WriteLine("Tempat,Tgl-lahir : {0},{1}", "Susi", "11-10-1998");
                Console.WriteLine("Spesialisasi     : {0}", "Super Duper VVVIP");
                Console.WriteLine("Lulusan          : {0}", "1273928173921");
                Console.WriteLine("No Handphone     : {0}", "08126655421");
                Console.ReadLine();
                //if input 2 -- Adm
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

                Console.Write("Nama             : ");
                Console.ReadLine();
                Console.Write("Tempat,Tgl-lahir : ");
                Console.ReadLine();
                Console.Write("Tipe Pasien      : ");
                Console.ReadLine();
                Console.Write("Asuransi BPJS    : ");
                Console.ReadLine();
                Console.Write("No Handphone     : ");
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
                //if input 7527 --  Admin
                Console.WriteLine("Halaman Admin");
                Console.WriteLine("Menu :");
                Console.WriteLine("1. Tambah Staff");//struktur mirip tambah obat
                Console.WriteLine("2. Hapus Staff");//struktur mirip hapus obat
                Console.WriteLine("3. Edit Staff");//struktur mirip edit obat
                Console.WriteLine("0. Exit");
                Console.Write("Pilihan = ");
                Console.ReadLine();
            }

        }
    }
}
