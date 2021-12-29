using System;
using System.Collections.Generic;
using System.Text;

namespace Iglesia.LogicaVistaInterface
{
    public interface IAcccionesGeneralesVista
    {
        public abstract void iniciar();
        public abstract void nuevo();
        public abstract void grabar();
        public abstract void editar();
        public abstract void eliminar();
    }
}
