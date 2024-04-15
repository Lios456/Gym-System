using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Aplicacion_Gym.Clases
{
    public class Conexion
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=root;database=gym");

        public void NoResult(string sql)
        {
            try
            {
                connection.Open();
                MySqlCommand query = new MySqlCommand(sql, connection);
                query.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se ha registrado satisfactoriamente");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public List<Usuarios> Result(string sql)
        {
            connection.Open();
            MySqlCommand query = new MySqlCommand(sql, connection);
            var lista = query.ExecuteReader();
            List<Usuarios> result = new List<Usuarios> ();
            while (lista.Read())
            {
                result.Add(new Usuarios { 
                    Id = lista.GetInt32(0),
                    DNI = lista.GetString(1),
                    Name = lista.GetString(2),
                    LastName = lista.GetString(3),
                    Phone = lista.GetString(4),
                    Fnac = lista.GetDateTime(5),
                    Age = lista.GetInt32(6),
                    Gender = lista.GetString(7),
                    Dir = lista.GetString(8)
                });
            }
            connection.Close();
            return result;
        }
    }
}
