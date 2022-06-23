using StarCapModel;
using StarCapModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresSmartWeb
{
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidorDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaGrilla();
            }

        }
        private void cargaGrilla()
        {
            List<Medidor> medidores = medidoresDAL.Obtener();
            this.grillaMedidores.DataSource = medidores;
            this.grillaMedidores.DataBind();
        }
        private void cargaGrilla(List<Medidor> filtrada)
        {
            List<Medidor> medidores = medidoresDAL.Obtener();
            this.grillaMedidores.DataSource = filtrada;
            this.grillaMedidores.DataBind();
        }
        protected void grillaMedidores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                string numeroSerie = Convert.ToString(e.CommandArgument);
                medidoresDAL.Eliminar(numeroSerie);
                cargaGrilla();
            }
        }

        protected void tipoDb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tipoDb1.SelectedItem != null)
            {
                string numeroSerie = Convert.ToString(this.tipoDb1.SelectedItem.Value);
                //filtrar por tipo de medidor
                List<Medidor> filtrada = medidoresDAL.Filtrar(numeroSerie);
                cargaGrilla(filtrada);
            }
        }
    }
}