using Iglesia.Model;
using IglesiaModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IglesiaData.Repositorio
{
    public class ParrocoRepositorio : IParrocoRepositorio
    {
        private IglesiaDb _iglesiaDb;
        public ParrocoRepositorio(IglesiaDb iglesiaDb)
        {
            _iglesiaDb = iglesiaDb;
        }
        public Task<bool> ActualizarParroco()
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarParroco()
        {
            throw new NotImplementedException();
        }

        public List<Parroco> GetAllParrocos()
        {
            var parrocos = _iglesiaDb.Parroco.Select(x => x);
            return parrocos.ToList();
        }

        public Task<Parroco> GetParroco()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertarParroco()
        {
            throw new NotImplementedException();
        }
    }
}
