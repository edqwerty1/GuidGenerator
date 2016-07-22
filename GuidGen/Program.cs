using System;
using System.Threading;
using System.Windows.Forms;

namespace GuidGen
{
    class Program
    {
        private static void Main(string[] args)
        {
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                var guid = Guid.NewGuid();
                Console.WriteLine(guid);
                Thread thread = new Thread(() => Clipboard.SetText(guid.ToString()));
                thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
                thread.Start();
                thread.Join();
            }
        }
    }
}
