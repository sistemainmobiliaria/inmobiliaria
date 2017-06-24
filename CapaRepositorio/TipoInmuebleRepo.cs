using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class TipoInmuebleRepo
    {
        public IEnumerable<TipoInmueble> MostrarTipoInmuebles()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<TipoInmueble> result = modeloDeDominio.TipoInmuebles.ToList();
                return result;
            }
        }
        public int GuardarTipoInmueble(TipoInmueble tipoInmueble)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(tipoInmueble);
                modeloDeDominio.SaveChanges();
                return tipoInmueble.IdTipoInmueble;
            }
        }
        public string TraerTipoInmueble(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                TipoInmueble result = modeloDeDominio.TipoInmuebles.Where(c => c.IdTipoInmueble == id).FirstOrDefault();

                modeloDeDominio.CreateDetachedCopy(result);

                return result.Nombre;
            }
        }
    }
}
