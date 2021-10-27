using Iglesia.Model;
using IglesiaModel.Model;
using IglesiaData.Repositorio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            //using (var context = new IglesiaDb())
            //{
            //    var parroquias = context.Parroquia.Select(x => x).ToList();
            //    foreach (var parroquia in parroquias)
            //    {
            //        var data = new System.Text.StringBuilder();
            //        data.AppendLine($"Nombre: {parroquia.nombre}");
            //        data.AppendLine($"Direccion: {parroquia.direccion}");
            //        Debug.WriteLine(data);
            //    }
            //}

            var contexto = new IglesiaDb();
            ParroquiaRepositorio parroquiaRepositorio = new ParroquiaRepositorio(contexto);
            ParrocoRepositorio parrocoRepositorio = new ParrocoRepositorio(contexto);

            List<Parroquia> parroquias = parroquiaRepositorio.GetAllParroquias();
            List<Parroco> parrocos = parrocoRepositorio.GetAllParrocos();
            Debug.WriteLine("Inicio parroquia-------------------------->");
            foreach (var parroquia in parroquias)
            {
                Debug.WriteLine(parroquia.Nombre);
            }

            Debug.WriteLine("Inicio parroco-------------------------->");
            foreach(var parroco in parrocos)
            {
                Debug.WriteLine(parroco.Nombres);
            }
            // Gets and prints all books in database

        }
    }
}