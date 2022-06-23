using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel
{
    public class Lectura
    {
        private Tipo tipoMedidor;
        private DateTime fecha;
        private string hora;
        private string consumo;

        public Tipo TipoMedidor { get => tipoMedidor; set => tipoMedidor = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Consumo { get => consumo; set => consumo = value; }
        public string Hora { get => hora; set => hora = value; }

    }
}
