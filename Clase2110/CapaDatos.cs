using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clase2110
{
    class CapaDatos
    {
        SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProgramaciónVisual;Data Source=NB-004544\\SQLEXPRESS");

        public void InsertarContacto(Contacto contacto)
        {
            try
            {
                cn.Open();

                string query = @"INSERT INTO Persona (Nombre, Apellido, Direccion, Telefono) VALUES (@NOMBRE, @APELLIDO, @DIRECCION, @TELEFONO)";

                SqlParameter nombre = new SqlParameter("@NOMBRE", contacto.Nombre);
                SqlParameter apellido = new SqlParameter("@APELLIDO", contacto.Apellido);
                SqlParameter direccion = new SqlParameter("@DIRECCION", contacto.Direccion);
                SqlParameter telefono = new SqlParameter("@TELEFONO", contacto.Telefono);

                SqlCommand comando = new SqlCommand(query, cn);
                comando.Parameters.Add(nombre);
                comando.Parameters.Add(apellido);
                comando.Parameters.Add(direccion);
                comando.Parameters.Add(telefono);

                comando.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }

            finally
            {
                cn.Close();
            }
        }

        public List<Contacto> GetContact(string search = null)
        {
            //Lista para guardar los contactos
            List<Contacto> contactos = new List<Contacto>();
            try
            {
                cn.Open();
                
                string query = @"SELECT Idpersona, Nombre, Apellido, Direccion, Telefono FROM Persona";
                
                SqlCommand comando = new SqlCommand();
                if (!string.IsNullOrEmpty(search))
                {
                    //Agrega esto al query para que busque 
                    query += @" WHERE Nombre LIKE @Search OR Apellido LIKE @Search OR Direccion LIKE @Search OR Telefono LIKE @Search";

                    //que lo buscado aparece en cualquier lugar de la columna
                    comando.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
                }

                comando.CommandText = query;
                comando.Connection = cn;

                //El data reader Trae todos los registros
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    //Itero el reader y lo agrego a la lista
                    contactos.Add(new Contacto
                    {
                        Id = int.Parse(reader["Idpersona"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return contactos;
        }

        public void UpdateContacto(Contacto contacto)
        {
            try
            {
                cn.Open();

                string query = @"UPDATE Persona SET Nombre=@Nombre, Apellido=@Apellido, Direccion=@Direccion, Telefono=@Telefono WHERE Id=@Idpersona";
                
                //creo los parametrs
                SqlParameter id = new SqlParameter("@Idpersona", contacto.Id);
                SqlParameter nombre = new SqlParameter("@Nombre", contacto.Nombre);
                SqlParameter apellido = new SqlParameter("@Apellido", contacto.Apellido);
                SqlParameter direccion = new SqlParameter("@Direccion", contacto.Direccion);
                SqlParameter telefono = new SqlParameter("@Telefono", contacto.Telefono);
                //creo el comando mandando os parametro
                SqlCommand comando = new SqlCommand(query, cn);
                comando.Parameters.Add(id);
                comando.Parameters.Add(nombre);
                comando.Parameters.Add(apellido);
                comando.Parameters.Add(direccion);
                comando.Parameters.Add(telefono);
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

        public void BorrarContacto(int id)
        {
            try
            {
                cn.Open();

                string query = @"DELETE FROM Persona WHERE Id=@Idpersona";
                
                //creo el comando mandando el parametro
                SqlCommand comando = new SqlCommand(query, cn);
                //Solo necesito id para borrar
                comando.Parameters.Add(new SqlParameter("@idpersona", id));

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
