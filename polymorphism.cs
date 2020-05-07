using System;

namespace Poly
{
    class Program
    {
        static void Main(string[] args)
        {

            PrinterWindows printer;

            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Cannon");
            Console.WriteLine("3. LaserJet\n");

            Console.WriteLine("Nomer Printer [1..3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
            {
                printer = new Epson();
            }
            else if (nomorPrinter == 2)
            {
                printer = new Cannon();
            }
            else
            {
                printer = new LaserJet();
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();

        }
    }

    public class PrinterWindows
    {

        public string Name { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("printer printing...");
        }

        public virtual void Show()
        {
            Console.WriteLine("display dimension");
        }

    }

    
    public class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }

        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing....");
        }
    }

    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }

        public override void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }

    public class Cannon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Cannon display dimension : 9.5*12");
        }

        public override void Print()
        {
            Console.WriteLine("Cannon printer printing....");
        }
    }


}