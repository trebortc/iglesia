using Iglesia.Model;
using IglesiaModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IglesiaData.Repositorio
{
    public class ParroquiaRepositorio : IParroquiaRepositorio
    {
        private IglesiaDb _iglesiaDb;
        public ParroquiaRepositorio(IglesiaDb iglesiaDb)
        {
            _iglesiaDb = iglesiaDb;
        }
        public Task<bool> ActualizarParroquia()
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarParroquia()
        {
            throw new NotImplementedException();
        }

        public List<Parroquia> GetAllParroquias()
        {
            var parroquias = _iglesiaDb.Parroquia.Select(x => x);
            return parroquias.ToList();
        }

        public Task<Parroquia> GetParroquia()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertarParroquia()
        {
            throw new NotImplementedException();
        }
    }
}
