using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppProcessi
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Esercitazione sulla gestone  dei processi");
            
            Process.Start("Notepad.exe", @"\\dc01srv\_Condivisa\INF\4 A\hamza el morsali\Tepsit\gestione_processi\AppProcessi\helloworld.txt");
            Process.Start("Chrome.exe", "web.spaggiari.eu");
            Process.Start("Chrome.exe", "www.youtube.com");
            
            var app = new Process();
            app.StartInfo.FileName = @"notepad.exe";
            app.StartInfo.Arguments = @"\\dc01srv\_Condivisa\INF\4 A\hamza el morsali\Tepsit\gestione_processi\AppProcessi\helloworld.txt";
            app.Start();
            app.PriorityClass = ProcessPriorityClass.RealTime;
            //app.WaitForExit();
            Console.WriteLine("PROGRAMMA TERMINATO");
            var processes = Process.GetProcesses();
            foreach(var p in processes)
            {
                if (p.ProcessName == "notepad")
                {
                    p.Kill();
                }  
            }
            Console.ReadLine();

        }
    }
}
