using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico5
{
    public partial class Form1 : Form
    {
        private CapaNegocioLibro _capanegociolibro;

        public Form1()
        {
            InitializeComponent();
            _capanegociolibro = new CapaNegocioLibro();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormLibro formlibro = new FormLibro();
            formlibro.ShowDialog(this);
        }

        public void CargarLibros(String SearchText = null)
        {
            List<Libro> libros = _capanegociolibro.ObtenerLibro(SearchText);
            GridLibros.DataSource = libros;
        }
              

        private void BorrarLibro(int id)
        {
            _capanegociolibro.BorrarLibro(id);
        }
               

        private void GridLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)GridLibros.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Editar")
            {
                //llamo al formulario de contactos para poder editar
                FormLibro formlibros = new FormLibro();
                //metodo que carga el contacto seleccionado
                formlibros.CargarLibro(new Libro
                {
                    Id = int.Parse((GridLibros.Rows[e.RowIndex].Cells[0]).Value.ToString()),
                    Titulo = GridLibros.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Autor = GridLibros.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    ISBN = GridLibros.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Paginas = GridLibros.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    Edicion = GridLibros.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    Editorial = GridLibros.Rows[e.RowIndex].Cells[6].Value.ToString(),
                    Ciudad = GridLibros.Rows[e.RowIndex].Cells[7].Value.ToString(),
                    Pais = GridLibros.Rows[e.RowIndex].Cells[8].Value.ToString(),
                    FechaEdicion = (GridLibros.Rows[e.RowIndex].Cells[9]).Value.ToString()
                });
                //Muestra el formulario de educion
                formlibros.ShowDialog(this);
            }
            //si selecciona eliminar
            else if (cell.Value.ToString() == "Eliminar")
            {
                BorrarLibro(int.Parse((GridLibros.Rows[e.RowIndex].Cells[0]).Value.ToString()));
                CargarLibros();
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            CargarLibros(txtBuscar.Text);
            txtBuscar.Text = string.Empty;
        }
    }
}
