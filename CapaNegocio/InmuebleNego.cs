using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class InmuebleNego
    {
        private InmuebleRepo inmuebleRepo = new InmuebleRepo();

        public IEnumerable<Inmueble> MostrarInmuebles()
        {
            return inmuebleRepo.MostrarInmuebles();
        }
    }
}
