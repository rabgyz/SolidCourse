using System;
namespace InterfaceSegregation
{
	public class Canon : IPrinter, IFaxContent
	{
		public void Fax(string content)
        {
            Console.WriteLine("Canon fax");
        }

        public void PrintColor(string content)
        {
            Console.WriteLine("Canon print in color");
        }

        public void PrintGrey(string content)
        {
            Console.WriteLine("Canon print in gray");
        }
    }
}

