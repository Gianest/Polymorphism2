using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.npm = "17.11.1201";
            mhs.nama = "jhannad Nur Alfian";
            mhs.email = "alfiarstudents.ariikom.ac.id";
            Console.WriteLine("Pilih Format Konversi Data:");
            Console.WriteLine("1.Json");
            Console.WriteLine("2.XML");
            Console.WriteLine("3.Csv");
            Console.Write("Pilihan: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());
            IConvertObject convert; // dekiarasi objek konversi
            if (nomorPrinter == 1)
                convert = new ConvertToJson();
            else if (nomorPrinter == 2)
                convert = new ConvertToXml();
            else
                convert = new ConvertToCsv();
            // koriversi objek mhs ber’dasarkan foreat yang dipilih
            convert.Convert(mhs);
            Console.ReadKey();
        }
    }
}
