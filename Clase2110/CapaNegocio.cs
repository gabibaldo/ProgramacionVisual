using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2110
{
    class CapaNegocio
    {
        private CapaDatos _capadatos;

        public CapaNegocio()
        {
            _capadatos = new CapaDatos();
        }

        public Contacto GuardarContacto(Contacto contacto)
        {
            if (contacto.Id == 0)
            {
                _capadatos.InsertarContacto(contacto);
            }
            else
            {
                _capadatos.UpdateContacto(contacto);
            }
            return contacto;
        }
        
        //Devueve en una lista los contactos de la base de datos
        public List<Contacto> GetContact(string TextSearch = null)
        { 
            return _capadatos.GetContact(TextSearch);
        }

        public void BorrarContacto(int id)
        {
            _capadatos.BorrarContacto(id);
        }
    }
}
