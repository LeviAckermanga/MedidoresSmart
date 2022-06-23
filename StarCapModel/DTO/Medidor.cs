using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel
{
    public class Medidor
    {
        private string numeroSerie;
        private Tipo tipoMedidor;

        public string NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        public Tipo TipoMedidor { get => tipoMedidor; set => tipoMedidor = value; }
    }
}
