using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public class LecturaDALObjetos : ILecturasDAL
    {
        private static List<Lectura> lecturas = new List<Lectura>();
        public void Agregar(Lectura lectura)
        {
            lecturas.Add(lectura);
        }

        public List<Lectura> Obtener()
        {
            return lecturas;
        }

        public void Actualizar(string consumo)
        {
            Lectura actualizando = lecturas.Find(c => c.Consumo == consumo);
            lecturas.Remove(actualizando);
        }
    }
}
