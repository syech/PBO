using System;
using System.Collections.Generic;

namespace syech
{
    abstract class staff
    {
        class Dokter : staff
        {
            public Dokter()
            {
                string nip, nama, ttl, sp, tamat, nohp,username,password;
                nip = Console.ReadLine();
                nama = Console.ReadLine();
                ttl = Console.ReadLine();
                sp = Console.ReadLine();
                tamat = Console.ReadLine();
                nohp = Console.ReadLine();
                username = Console.ReadLine();
                password = Console.ReadLine();
            }
        }
        class Admin : staff
        {
            public Admin()
            {
                string nops, nama, ttl, tipe, asuransi, nohp;
                nops = Console.ReadLine();
                nama = Console.ReadLine();
                ttl = Console.ReadLine();
                tipe = Console.ReadLine();
                asuransi = Console.ReadLine();
                nohp = Console.ReadLine();
            }
        }
        class petugasRM : staff
        {
            public petugasRM()
            {
                string nip, nama, ttl, nohp,username,password;
                nip = Console.ReadLine();
                nama = Console.ReadLine();
                ttl = Console.ReadLine();
                nohp = Console.ReadLine();
                username = Console.ReadLine();
                password = Console.ReadLine();
            }
        }
        class MainClass
        {
            public static void Main(string[] args)
            {
                string nama, password;
                int a;
                List<staff> data = new List<staff>();
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
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Selamat Datang");
                            Console.WriteLine("Menu :");
                            Console.WriteLine("1. Dokter");
                            Console.WriteLine("2. Administrasi");
                            Console.WriteLine("3. Staff Rekam Medis");
                            Console.WriteLine("0. Exit");
                            Console.Write("Pilihan = ");
                            a = int.Parse(Console.ReadLine());
                            if (a == 1)
                            {
                                data.Add(new Dokter());
                                break;
                            }
                            else if (a == 2)
                            {
                                data.Add(new Admin());
                                break;
                            }
                            else if (a == 3)
                            {
                                data.Add(new petugasRM());
                                break;
                            }
                        } while (a != 0);

                    }
                }
            }
        }
    }
}
