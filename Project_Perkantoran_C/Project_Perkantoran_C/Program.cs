using System;

namespace Project_Perkantoran_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string userinpute = "y";
            do
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("Menu Perkantoran");
                Console.WriteLine("1. Karyawan");
                Console.WriteLine("2. Gaji");
                Console.WriteLine("=====================================");
                string userinput = Console.ReadLine();
                switch (userinput)
                {
                    case "Karyawan":
                        Karyawan tambah = new Karyawan();
                        tambah.add_info();
                        break;
                    case "Gaji":
                        Console.WriteLine("Masukkan Jumlah Gaji : ");
                        string value1 = Console.ReadLine();
                        Console.WriteLine("Masukkan Jumlah Bonus : ");
                        string value2 = Console.ReadLine();
                        Gaji penghasilan = new Gaji();
                        double Hasil = penghasilan.total_pendapatan(Convert.ToDouble(value1), Convert.ToDouble(value2));
                        Console.WriteLine("Total Penghasilan yang didapat = Rp. " + Hasil);
                        break;
                    default:
                        Console.WriteLine("Mohon ketikkan dari pilihan 3 pilihan menu yang sudah ada");
                        break;
                }
                Console.WriteLine("Apa anda ingin melanjutkan? y/t?");
                userinpute = Console.ReadLine();
            } while (userinpute == "y");
        }
    }

    class Gaji
    {
        public double gaji_pokok, bonus;

        public double total_pendapatan(double value1, double value2)
        {
            return value1 + value2;
        }
    }
    
}
