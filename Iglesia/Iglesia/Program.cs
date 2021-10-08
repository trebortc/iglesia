using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iglesia
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PrintData();
            Application.Run(new Form1());


        }

        private static void PrintData()
        {
            // Gets and prints all books in database
            using (var context = new Model.IglesiaDb())
            {
                var parroquias = context.Parroquia.Select(x=>x).ToList();
                foreach (var parroquia in parroquias)
                {
                    var data = new System.Text.StringBuilder();
                    data.AppendLine($"Nombre: {parroquia.nombre}");
                    data.AppendLine($"Direccion: {parroquia.direccion}");
                    Console.WriteLine(parroquia.nombre);
                }
            }
        }
    }
}
