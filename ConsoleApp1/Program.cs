using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public interface IPrint
    {
        void Print();
    }

    abstract class PrinterCreater
    {
        public string Name { get; set; }
        public PrinterCreater(string name)
        {
            Name = name;
            PrintName();
        }
        public abstract IPrint PrintMethod();

        void PrintName()
        {
            Console.Write($"{Name} ");
        }
    }

    class Canon : PrinterCreater
    {
        public Canon(string name) : base(name) { }

        public override IPrint PrintMethod()
        {
            return new Perl();
        }
    }

    class HP : PrinterCreater
    {
        public HP(string name) : base(name) { }

        public override IPrint PrintMethod()
        {
            return new Offset();
        }
    }

    class Perl : IPrint
    {
        public Perl()
        {
            Print();
        }
        public void Print()
        {
            Console.WriteLine("печатает бумагой Perl");
        }
    }

    class Offset : IPrint
    {
        public Offset()
        {
            Print();
        }
        public void Print()
        {
            Console.WriteLine("печатает бумагой Offset");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            PrinterCreater printerCreater = null;

            printerCreater = new Canon("Canon");
            printerCreater.PrintMethod();

            printerCreater = new HP("HP");
            printerCreater.PrintMethod();
           

            Console.ReadKey();
        }
    }
}
