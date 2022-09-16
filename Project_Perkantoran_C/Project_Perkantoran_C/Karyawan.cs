using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Perkantoran_C
{
    class Karyawan
    {
        public string name,gender,phone;
        public string alamat;


        public  void add_info()
        {
            Console.WriteLine("Nama Karyawan :");
            this.name = Console.ReadLine();
            Console.WriteLine("Jenis Kelamin :");
            this.gender = Console.ReadLine();
            Console.WriteLine("Alamat tinggal :");
            this.alamat = Console.ReadLine();
            Console.WriteLine("Nomor Telepon :");
            this.phone = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Nama Karyawan    : "+ name);
            Console.WriteLine("Jenis Kelamin    : "+ gender);
            Console.WriteLine("Alamat tinggal   : "+ alamat);
            Console.WriteLine("Nomor Telepon    : "+ phone);
            Console.WriteLine("-----------------------------------------");
        }
    }
}
