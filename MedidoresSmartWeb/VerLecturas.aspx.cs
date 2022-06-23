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
    public partial class VerLecturas : System.Web.UI.Page
    {
        private ILecturasDAL lecturasDAL = new LecturaDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaGrilla();
            }

        }
        private void cargaGrilla()
        {
            List<Lectura> lecturas = lecturasDAL.Obtener();
            this.grillaLecturas.DataSource = lecturas;
            this.grillaLecturas.DataBind();
        }
        private void cargaGrilla(List<Lectura> filtrada)
        {
            List<Lectura> lecturas = lecturasDAL.Obtener();
            this.grillaLecturas.DataSource = filtrada;
            this.grillaLecturas.DataBind();
        }
    }
}