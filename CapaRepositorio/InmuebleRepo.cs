using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class InmuebleRepo
    {
        public IEnumerable<Inmueble> MostrarInmuebles()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Inmueble> result = modeloDeDominio.Inmuebles.ToList();
                return result;
            }
        }
    }
}
