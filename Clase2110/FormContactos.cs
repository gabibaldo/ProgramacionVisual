using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase2110
{
    public partial class FormContactos : Form
    {
        //declaro una variable global de la calse CapaNegocio puedo acceder desde cualquier clase
        private CapaNegocio _capanegocio;
        private Contacto _contacto;
        public FormContactos()
        {
            InitializeComponent();
            _capanegocio = new CapaNegocio();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarContacto();
            this.Close();
            ((Form1)this.Owner).CargarContactos();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarContacto()
        {
            Contacto contacto = new Contacto();
            contacto.Nombre = txtNombre.Text;
            contacto.Apellido = txtApellido.Text;
            contacto.Direccion = txtDireccion.Text;
            contacto.Telefono = txtTelefono.Text;

            contacto.Id = _contacto != null ? _contacto.Id : 0;
            _capanegocio.GuardarContacto(contacto);
        }

        public void LoadContact(Contacto contacto)
        {
            //aqui en esta variable global copio la instancia de contacto para guardarme el ID del contacto
            _contacto = contacto;
            if (contacto != null)
            {
                ClearForm();
                txtNombre.Text = contacto.Nombre;
                txtApellido.Text = contacto.Apellido;
                txtDireccion.Text = contacto.Direccion;
                txtTelefono.Text = contacto.Telefono;
            }
        }

        private void ClearForm()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }
    }
}
