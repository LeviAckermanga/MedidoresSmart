using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public class MedidorDALObjetos : IMedidoresDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();
        public void Agregar(Medidor medidor)
        {
            medidores.Add(medidor);
        }

        public List<Medidor> Obtener()
        {
            return medidores;
        }

        public void Eliminar(string numeroSerie)
        {
            Medidor eliminando = medidores.Find(c => c.NumeroSerie == numeroSerie);
            medidores.Remove(eliminando);
        }

        public List<Medidor> Filtrar(string numeroSerie)
        {
            return medidores.FindAll(c => c.NumeroSerie == numeroSerie);
        }
    }
}
