using System;
namespace InterfaceSegregation
{
	public class HpLaserJet : IPrinter, IFaxContent, IScanner
	{
		public void Fax(string content)
        {
            Console.WriteLine("Hp laser jet fax");
        }

        public void PrintColor(string content)
        {
            Console.WriteLine("Hp laser jet print color");
        }

        public void PrintGrey(string content)
        {
            Console.WriteLine("Hp laser jet print gray");
        }

        public void Scan(string content)
        {
            Console.WriteLine("Hp laser jet scan");
        }
    }
}

