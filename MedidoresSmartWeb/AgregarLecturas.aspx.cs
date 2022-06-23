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
    public partial class AgregarLecturas : System.Web.UI.Page
    {
        private ILecturasDAL lecturasDAL = new LecturaDALObjetos();
        private ITipos tiposDAL = new TiposDALObjetos();
        /// <summary>
        /// Este metodo se ejecuta 
        /// - Cuando es una peticion GET (!PostBack)
        /// - cunado es una peticion POST (PostBack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Tipo> tipos = tiposDAL.ObtenerTipos();
                this.tipoDdl.DataSource = tipos;
                this.tipoDdl.DataTextField = "Nombre";
                this.tipoDdl.DataValueField = "Codigo";
                this.tipoDdl.DataBind();

            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1. Obtener los datos del formulario
            string consumo = this.Consumo.Text.Trim();
            string hora = this.Hora.Text.Trim();
            //obtener  el valor del dropdown
            string tipoValor = this.tipoDdl.SelectedValue;
            //obtener el texto
            string tipoTexto = this.tipoDdl.SelectedItem.Text;

            List<Tipo> tipos = tiposDAL.ObtenerTipos();
            Tipo tipo = tipos.Find(b => b.Codigo == this.tipoDdl.SelectedItem.Value);
            //2. construir el objeto de tipo cliente
            Lectura lectura = new Lectura()
            {
                TipoMedidor = tipo,
                Hora = hora,
                Consumo = consumo
            };
            //3. Llamar al DAL
            lecturasDAL.Agregar(lectura);
            //4. Mostrar mensajae de exito
            this.mensajeLbl.Text = "Lectura Ingresada Exitosamente !!!";
            Response.Redirect("VerLecturas.aspx");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime fecha = Calendar1.SelectedDate;
        }
    }
}