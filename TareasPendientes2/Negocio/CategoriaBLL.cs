using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class CategoriaBLL
    {
        TareasPendientesEntities tp = new TareasPendientesEntities();

        public void Add(string nombre)
        {
            Categoria nueva = new Categoria();
            nueva.Nombre = nombre;

            tp.Categoria.Add(nueva);
            tp.SaveChanges();
        }

    }
}
