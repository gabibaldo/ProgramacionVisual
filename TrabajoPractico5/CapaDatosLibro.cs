using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico5
{
    class CapaDatosLibro
    {
        SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProgramaciónVisual;Data Source=NB-004544\\SQLEXPRESS");

        public void InsertarLibro(Libro libro)
        {
            try
            {
                cn.Open();

                string query = @"INSERT INTO Libro (Titulo, Autor, ISBN, Paginas, Edicion, Editorial, Ciudad, Pais, FechaEdicion) 
                                VALUES (@TITULO, @AUTOR, @ISBN, @PAGINAS, @EDICION, @EDITORIAL, @CIUDAD, @PAIS, @FECHA)";

                SqlParameter titulo = new SqlParameter("@TITULO", libro.Titulo);
                SqlParameter autor = new SqlParameter("@AUTOR", libro.Autor);
                SqlParameter isbn = new SqlParameter("@ISBN", libro.ISBN);
                SqlParameter paginas = new SqlParameter("@PAGINAS", libro.Paginas);
                SqlParameter edicion = new SqlParameter("@EDICION", libro.Edicion);
                SqlParameter editorial = new SqlParameter("@EDITORIAL", libro.Editorial);
                SqlParameter ciudad = new SqlParameter("@CIUDAD", libro.Ciudad);
                SqlParameter pais = new SqlParameter("@PAIS", libro.Pais);
                SqlParameter fecha = new SqlParameter("@FECHA", libro.FechaEdicion);

                SqlCommand comando = new SqlCommand(query, cn);
                comando.Parameters.Add(titulo);
                comando.Parameters.Add(autor);
                comando.Parameters.Add(isbn);
                comando.Parameters.Add(paginas);
                comando.Parameters.Add(edicion);
                comando.Parameters.Add(editorial);
                comando.Parameters.Add(ciudad);
                comando.Parameters.Add(pais);
                comando.Parameters.Add(fecha);
                
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                cn.Close();
            }
        }

        public List<Libro> ObtenerLibro(string search = null)
        {
            //Lista para guardar los contactos
            List<Libro> libros = new List<Libro>();
            try
            {
                cn.Open();

                string query = @"SELECT Idlibro, Titulo, Autor, Isbn, Paginas, Edicion, Editorial, Ciudad, Pais, FechaEdicion FROM Libro";

                SqlCommand comando = new SqlCommand();
                if (!string.IsNullOrEmpty(search))
                {
                    //Agrega esto al query para que busque 
                    query += @" WHERE Titulo LIKE @Search OR Autor LIKE @Search OR Isbn LIKE @Search OR Paginas LIKE @Search
                                OR Edicion LIKE @Search OR Editorial LIKE @Search OR Ciudad LIKE @Search OR Pais LIKE @Search OR FechaEdicion LIKE @Search";

                    //que lo buscado aparece en cualquier lugar de la columna
                    comando.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
                }

                comando.CommandText = query;
                comando.Connection = cn;

                //El data reader Trae todos los registros
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    libros.Add(new Libro
                    {
                        Id = int.Parse(reader["Idlibro"].ToString()),
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        ISBN = reader["Isbn"].ToString(),
                        Paginas = reader["Paginas"].ToString(),
                        Edicion = reader["Edicion"].ToString(),
                        Editorial = reader["Editorial"].ToString(),
                        Ciudad = reader["Ciudad"].ToString(),
                        Pais = reader["Pais"].ToString(),
                        FechaEdicion = reader["FechaEdicion"].ToString(),
                    });
                }
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return libros;
        }

        public void ActualizarLibro(Libro libro)
        {
            try
            {
                cn.Open();

                string query = @"UPDATE Libro SET Titulo=@TITULO, Autor=@AUTOR, Isbn=@ISNB, Paginas=@PAGINAS, Edicion=@EDICION,
                                                Editorial=@EDITORIAL, Ciudad=@CIUDAD, Pais=@PAIS, FechaEdicion=@Fecha WHERE IdLibro=@Id";

                //creo los parametrs
                SqlParameter id = new SqlParameter("@Id", libro.Id);
                SqlParameter titulo = new SqlParameter("@TITULO", libro.Titulo);
                SqlParameter autor = new SqlParameter("@AUTOR", libro.Autor);
                SqlParameter isbn = new SqlParameter("@ISNB", libro.ISBN);
                SqlParameter paginas = new SqlParameter("@PAGINAS", libro.Paginas);
                SqlParameter edicion = new SqlParameter("@EDICION", libro.Edicion);
                SqlParameter editorial = new SqlParameter("@EDITORIAL", libro.Editorial);
                SqlParameter ciudad = new SqlParameter("@CIUDAD", libro.Ciudad);
                SqlParameter pais = new SqlParameter("@PAIS", libro.Pais);
                SqlParameter fecha = new SqlParameter("@Fecha", libro.FechaEdicion);


                //creo el comando mandando os parametro
                SqlCommand comando = new SqlCommand(query, cn);
                comando.Parameters.Add(id);
                comando.Parameters.Add(titulo);
                comando.Parameters.Add(autor);
                comando.Parameters.Add(isbn);
                comando.Parameters.Add(paginas);
                comando.Parameters.Add(edicion);
                comando.Parameters.Add(editorial);
                comando.Parameters.Add(ciudad);
                comando.Parameters.Add(pais);
                comando.Parameters.Add(fecha);

                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public void BorrarLibro(int id)
        {
            try
            {
                cn.Open();

                string query = @"DELETE FROM Libro WHERE IdLibro=@Id";

                //creo el comando mandando el parametro
                SqlCommand comando = new SqlCommand(query, cn);
                
                //Solo necesito id para borrar
                comando.Parameters.Add(new SqlParameter("@Id", id));

                //Este comando devuelve cantidad de filas afectadas y cero si no
                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
