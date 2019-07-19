using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class WindowCreater
    {
        public string Name{get;set;}

        public WindowCreater(string name)
        {
            Name = name;
        }

        public abstract IOpenWindow OpenMethod();
    }


    class Windows : WindowCreater
    {
        public Windows(string name) : base(name) {}

        public override IOpenWindow OpenMethod()
        {
            return new Native();
        }
    }

    class Browser : WindowCreater
    {
        public Browser(string name) : base(name) { }

        public override IOpenWindow OpenMethod()
        {
            return new HTML();
        }
    }

    public interface IOpenWindow
    {
        string Open();
    }

    class Native : IOpenWindow
    {
        public string Open()
        {
           return "открывается окно Native";
        }
    }

    class HTML : IOpenWindow
    {
        public string Open()
        {
            return "открывается окно HTML";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WindowCreater window = null;
            IOpenWindow open = null; 

            window = new Windows("Windows");
            open = new Native();

            Console.WriteLine($"В {window.Name} {open.Open()}");

            open = new HTML();
            window = new Windows("Browser");
            Console.WriteLine($"В {window.Name} {open.Open()}");
            Console.ReadKey();
        }
    }
}
