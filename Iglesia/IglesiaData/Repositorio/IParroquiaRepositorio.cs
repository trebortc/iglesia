using IglesiaModel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IglesiaData.Repositorio
{
    public interface IParroquiaRepositorio
    {
        List<Parroquia> GetAllParroquias();
        Task<Parroquia> GetParroquia();
        Task<bool> InsertarParroquia();
        Task<bool> ActualizarParroquia();
        Task<bool> EliminarParroquia();
    }
}
