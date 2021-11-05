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
    public partial class FormLibro : Form
    {
        private CapaNegocioLibro _capanegociolibro;
        private Libro _libro;

        public FormLibro()
        {
            InitializeComponent();
            _capanegociolibro = new CapaNegocioLibro();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtIsbn.Clear();
            txtPaginas.Clear();
            txtEdicion.Clear();
            txtEditorial.Clear();
            txtCiudad.Clear();
            txtPais.Clear();
            txtFecha.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarLibro();
                this.Close();
                ((Form1)this.Owner).CargarLibros();
            }
            else
            {
                MessageBox.Show("Intente nuevamente");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarLibro()
        {
            Libro libro = new Libro();
            libro.Titulo = txtTitulo.Text;
            libro.Autor = txtAutor.Text;
            libro.ISBN = txtIsbn.Text;
            libro.Paginas = txtPaginas.Text;
            libro.Edicion = txtEdicion.Text;
            libro.Editorial = txtEditorial.Text;
            libro.Ciudad = txtCiudad.Text;
            libro.Pais = txtPais.Text;
            libro.FechaEdicion = txtFecha.Text;

            libro.Id = _libro != null ? _libro.Id : 0;
            _capanegociolibro.GuardarLibro(libro);
        }

        public void CargarLibro(Libro libro)
        {
            _libro = libro;
            if (libro != null)
            {
                LimpiarFormulario();
                txtTitulo.Text = libro.Titulo;
                txtAutor.Text = libro.Autor;
                txtIsbn.Text = libro.ISBN;
                txtPaginas.Text = libro.Paginas;
                txtEdicion.Text = libro.Edicion;
                txtEditorial.Text = libro.Editorial;
                txtCiudad.Text = libro.Ciudad;
                txtPais.Text = libro.Pais;
                txtFecha.Text = libro.FechaEdicion;
            }
        }
        
        private void LimpiarFormulario()
        {
            txtTitulo.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtIsbn.Text = string.Empty;
            txtPaginas.Text = string.Empty;
            txtEdicion.Text = string.Empty;
            txtEditorial.Text = string.Empty;
            txtCiudad.Text = string.Empty;
            txtPais.Text = string.Empty;
            txtFecha.Text = string.Empty;
        }

        #region METODO PRIVADO
        private bool Validar()
        {
            bool datoValido;
            datoValido = true;

            if (txtTitulo.Text.Trim() == "")
            {
                MessageBox.Show("El Título esta vacio");
                txtTitulo.Focus();
                datoValido = false;
            }

            if (txtAutor.Text.Trim() == "")
            {
                MessageBox.Show("El Autor esta vacio");
                txtAutor.Focus();
                datoValido = false;
            }

            if (txtIsbn.Text.Trim() == "")
            {
                MessageBox.Show("El ISNB esta vacio");
                txtIsbn.Focus();
                datoValido = false;
            }

            try
            {
                Int32.Parse(txtPaginas.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El dato Cantidad de Páginas es incorrecto o esta vacio.");
                datoValido = false;
            }

            if (txtEdicion.Text.Trim() == "")
            {
                MessageBox.Show("La Edicion esta vacia");
                txtEdicion.Focus();
                datoValido = false;
            }

            if (txtEditorial.Text.Trim() == "")
            {
                MessageBox.Show("La Editorial esta vacia");
                txtEditorial.Focus();
                datoValido = false;
            }

            if (txtIsbn.Text.Trim() == "")
            {
                MessageBox.Show("La Ciudad esta vacia");
                txtCiudad.Focus();
                datoValido = false;
            }

            if (txtIsbn.Text.Trim() == "")
            {
                MessageBox.Show("El País esta vacio");
                txtCiudad.Focus();
                datoValido = false;
            }

            if (txtIsbn.Text.Trim() == "")
            {
                MessageBox.Show("La Fecha de Edición esta vacia");
                txtFecha.Focus();
                datoValido = false;
            }

            return datoValido;
        }
        #endregion
    }
}
