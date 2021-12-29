using Iglesia.LogicaVistaInterface;
using System.Windows.Forms;

namespace Iglesia.LogicaVistaClass
{
    public abstract class GeneralForm : Form, IAcccionesGeneralesVista
    {
        public abstract void editar();
        public abstract void eliminar();
        public abstract void grabar();
        public abstract void iniciar();
        public abstract void nuevo();
    }
}
