using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public interface IMedidoresDAL
    {
        List<Medidor> Obtener();
        void Agregar(Medidor medidor);
        void Eliminar(string numeroSerie);
        List<Medidor> Filtrar(string numeroSerie);
    }
}
