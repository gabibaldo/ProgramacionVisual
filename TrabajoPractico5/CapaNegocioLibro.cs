using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico5
{
    class CapaNegocioLibro
    {
        private CapaDatosLibro _capadatoslibro;
        
        public CapaNegocioLibro()
        {
            _capadatoslibro = new CapaDatosLibro();
        }

        public Libro GuardarLibro(Libro libro)
        {
            if (libro.Id == 0)
            {
                _capadatoslibro.InsertarLibro(libro);
            }
            else
            {
                _capadatoslibro.ActualizarLibro(libro);
            }
            return libro;
        }

        //Devueve en una lista los contactos de la base de datos
        public List<Libro> ObtenerLibro(string TextSearch = null)
        {
            return _capadatoslibro.ObtenerLibro(TextSearch);
        }

        public void BorrarLibro(int id)
        {
            _capadatoslibro.BorrarLibro(id);
        }
    }
}
