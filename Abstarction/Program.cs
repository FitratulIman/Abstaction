using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


 namespace AbstractClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nama\t\t: M.FITRATUL IMAN");
            Console.WriteLine("NIM\t\t: 19.11.2809");
            Console.WriteLine("Kelas\t\t: 19 IF 04");


            Console.WriteLine();

            Console.WriteLine("^^^^ ANDROID ^^^^");

            Console.WriteLine();

            ACOperatingSystem android;

            android = new OPPO();
            android.pendiri();
            android.platform();
            android.jenis();

            Console.WriteLine();

            android = new ASUS();
            android.pendiri();
            android.platform();
            android.jenis();


            Console.WriteLine();

            Console.WriteLine(" ^^^^ MAKANAN ^^^^");

            Console.WriteLine();

            Makanan makanan;

            makanan = new Cilok();
            makanan.Asal();
            makanan.jenis();

            Console.WriteLine();

            makanan = new Sosis();
            makanan.Asal();
            makanan.jenis();
        }
    }

    // Abstract Class 
    public abstract class ACOperatingSystem
    {
        public abstract void pendiri();
        public abstract void platform();
        public abstract void jenis();
    }

    public class OPPO : ACOperatingSystem
    {
        public override void pendiri()
        {
            Console.WriteLine("Industri : OPPO ");
        }

        public override void platform()
        {
            Console.WriteLine("Plaatform : Hight Cuality ");
        }

        public override void jenis()
        {
            Console.WriteLine("Jenis : OPPO A7 ");
        }
    }

    public class ASUS : ACOperatingSystem
    {
        public override void pendiri()
        {
            Console.WriteLine("pendiri : ASUS ");
        }

        public override void platform()
        {
            Console.WriteLine("platform : Hight cuality ");
        }

        public override void jenis()
        {
            Console.WriteLine("Jenis : Zenfone 5 ");
        }
    }

    // Interface Class Makanan

    public interface Makanan
    {
        void Asal();
        void jenis();
    }

    public class Cilok : Makanan
    {
        public void Asal()
        {
            Console.WriteLine(" Indonesia ");
        }

        public void jenis()
        {
            Console.WriteLine(" Jenis: Junk Food ");
        }

        public void asal()
        {
            throw new NotImplementedException();
        }
    }


    public class Sosis : Makanan
    {
        public void Asal()
        {
            Console.WriteLine(" IRAQ ");
        }
        public void jenis()
        {
            Console.WriteLine(" Jenis : Makanan Berat");
        }

        public void asal()
        {
            throw new NotImplementedException();
        }
    }

}
