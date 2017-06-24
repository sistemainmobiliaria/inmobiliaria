using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDominio;
using CapaNegocio;

namespace Inmobiliaria
{
    public partial class AltaInmueble : System.Web.UI.Page
    {
        private InmuebleNego inmuebleNego = new InmuebleNego();
        private TipoInmuebleNego tipoInmuebleNego = new TipoInmuebleNego();
        public static int idTipoInmuebleActual = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarListaTipoInmueble();
            }
        }

        private void LlenarListaTipoInmueble()
        {
            ddlTipoInmueble.DataSource = tipoInmuebleNego.MostrarTipoInmuebles().ToList();
            ddlTipoInmueble.DataValueField = "nombre";
            ddlTipoInmueble.DataBind();
        }

        protected void btnModalTipoInmuebleGuardar_Click(object sender, EventArgs e)
        {
            TipoInmueble tipoInmueble = new TipoInmueble();

            tipoInmueble.Nombre = txtTipoInmuebleModal.Text;

            idTipoInmuebleActual = tipoInmuebleNego.GuardarTipoInmueble(tipoInmueble);

            ddlTipoInmueble.Items.Clear();
            ddlTipoInmueble.Text = TraerTipoInmueble(idTipoInmuebleActual);
            LlenarListaTipoInmueble();
        }
        private string TraerTipoInmueble(int id)
        {
            return tipoInmuebleNego.TraerTipoInmueble(id);
        }

        protected void btnGuardarInmueble_Click(object sender, EventArgs e)
        {

        }
    }
}