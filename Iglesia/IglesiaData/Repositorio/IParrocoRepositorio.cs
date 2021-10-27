using IglesiaModel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IglesiaData.Repositorio
{
    public interface IParrocoRepositorio
    {
        List<Parroco> GetAllParrocos();
        Task<Parroco> GetParroco();
        Task<bool> InsertarParroco();
        Task<bool> ActualizarParroco();
        Task<bool> EliminarParroco();
    }
}
