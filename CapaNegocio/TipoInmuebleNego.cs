using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class TipoInmuebleNego
    {
        private TipoInmuebleRepo tipoInmuebleRepo = new TipoInmuebleRepo();

        public IEnumerable<TipoInmueble> MostrarTipoInmuebles()
        {
            return tipoInmuebleRepo.MostrarTipoInmuebles();
        }
        public int GuardarTipoInmueble(TipoInmueble tipoInmueble)
        {
            return tipoInmuebleRepo.GuardarTipoInmueble(tipoInmueble);
        }
        public string TraerTipoInmueble(int id)
        {
            return tipoInmuebleRepo.TraerTipoInmueble(id);
        }
    }
}
