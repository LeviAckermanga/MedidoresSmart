using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public class TiposDALObjetos : ITipos
    {
        public List<Tipo> ObtenerTipos()
        {
            return new List<Tipo>
            {
                new Tipo()
                {
                    Nombre = "Tipo 1",
                    Codigo = "1"
                },
                new Tipo()
                {
                    Nombre = "Tipo 2",
                    Codigo = "2"
                },
                new Tipo()
                {
                    Nombre = "Tipo 3",
                    Codigo = "3"
                },
                new Tipo()
                {
                    Nombre = "Tipo 4",
                    Codigo = "4"
                }
            };
        }
    }
}
