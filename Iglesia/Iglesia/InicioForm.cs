//using Bautizo.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bautizo.Vista;
using Bautizo.Modelo;

namespace Iglesia
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void InicioForm_Load(object sender, EventArgs e)
        {
            MenuStrip menu = new MenuStrip();
            //Inicio
            ToolStripMenuItem inicioMenu = new ToolStripMenuItem("Inicio");
            ToolStripMenuItem salirMenu = new ToolStripMenuItem("Salir");
            salirMenu.Click += new EventHandler(this.botonSalir_Click);
            inicioMenu.DropDown.Items.Add(salirMenu);

            //Acciones
            ToolStripMenuItem accionesMenu = new ToolStripMenuItem("&Acciones");
            ToolStripMenuItem nuevoMenu = new ToolStripMenuItem("Nuevo");
            ToolStripMenuItem guardarMenu = new ToolStripMenuItem("Guardar");
            ToolStripMenuItem eliminarMenu = new ToolStripMenuItem("Eliminar");
            ToolStripMenuItem buscarMenu = new ToolStripMenuItem("Buscar");
            //parroquiaMenu.Click += new System.EventHandler(this.botonParroquia_Click);
            accionesMenu.DropDown.Items.Add(nuevoMenu);
            accionesMenu.DropDown.Items.Add(guardarMenu);
            

            //Bautizo
            ToolStripMenuItem bautizoMenu = new ToolStripMenuItem("Bautizo");
            ToolStripMenuItem parroquiaMenu = new ToolStripMenuItem("Parroquia");
            parroquiaMenu.Click += new System.EventHandler(this.botonParroquia_Click);
            bautizoMenu.DropDown.Items.Add(parroquiaMenu);

            this.MainMenuStrip=menu;
            this.MainMenuStrip.Items.Add(inicioMenu);
            this.MainMenuStrip.Items.Add(accionesMenu);
            this.MainMenuStrip.Items.Add(bautizoMenu);

            Controls.Add(menu);
        }
        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonParroquia_Click(object sender, EventArgs e)
        {
            if (!detectarFormularioAbierto("ParroquiaForm"))
            {              
                ParroquiaForm parroquiaForm = new ParroquiaModelo();
                parroquiaForm.MdiParent = this;
                parroquiaForm.Show();
                parroquiaForm.WindowState = FormWindowState.Maximized;
            }
        }

        public static bool detectarFormularioAbierto(string formulario)
        {
            bool abierto = false;
            if (Application.OpenForms[formulario] != null)
            {
                abierto = true;
                Application.OpenForms[formulario].Activate();
                Application.OpenForms[formulario].WindowState = FormWindowState.Maximized;
            }
            return abierto;
        }
        public static bool cerrarFormularioAbierto(string formulario)
        {
            bool abierto = false;
            if (Application.OpenForms[formulario] != null)
            {
                abierto = true;
                Application.OpenForms[formulario].Close();
            }
            return abierto;
        }
    }
}
