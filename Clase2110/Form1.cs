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
    public partial class Form1 : Form
    {

        private CapaNegocio _capanegocio;
        public Form1()
        {
            InitializeComponent();
            _capanegocio = new CapaNegocio();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormContactos formcontactos = new FormContactos();
            formcontactos.ShowDialog(this);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CargarContactos();
        }
        
        public void CargarContactos(String SearchText = null)
        {
            List<Contacto> contactos = _capanegocio.GetContact(SearchText);
            GridPersonas.DataSource = contactos;
        }

        public void GridPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cell va a ser nulo si no hace click en editar , o sea e la columna de editar.
            //El dataGridviewLinkcell es alguna de las celdas de las columnas de editar o eliminar
            DataGridViewLinkCell cell = (DataGridViewLinkCell)GridPersonas.Rows[e.RowIndex].Cells[e.ColumnIndex];
            
            //Veo que link apreto para saber que hacer
            if (cell.Value.ToString() == "Editar")
            {
                //llamo al formulario de contactos para poder editar
                FormContactos formcontactos = new FormContactos();
                //metodo que carga el contacto seleccionado
                formcontactos.LoadContact(new Contacto
                {
                    Id = int.Parse((GridPersonas.Rows[e.RowIndex].Cells[0]).Value.ToString()),
                    Apellido = GridPersonas.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Nombre = GridPersonas.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Direccion = GridPersonas.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Telefono = GridPersonas.Rows[e.RowIndex].Cells[4].Value.ToString(),
                });
                //Muestra el formulario de educion
                formcontactos.ShowDialog(this);
            }
            //si selecciona eliminar
            else if (cell.Value.ToString() == "Eliminar")
            {
                BorrarContacto(int.Parse((GridPersonas.Rows[e.RowIndex].Cells[0]).Value.ToString()));
                CargarContactos();
            }
        }

        private void BorrarContacto(int id)
        {
            _capanegocio.BorrarContacto(id);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarContactos(txtBuscar.Text);
            txtBuscar.Text = string.Empty;
        }
    }
}
