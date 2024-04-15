using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Aplicacion_Gym.Clases
{
    public class Usuarios
    {
        public int? Id { get; set; }
        public string? DNI { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public DateTime? Fnac { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
        public string? Dir { get; set; }

        public Usuarios() { }

        public static void Registrar(Usuarios u)
        {
            try
            {
                string sql = $"insert into clientes(dni_cli, nom_cli,apel_cli,tel_cli,fecnac_cli,edad_cli,sexocli,dir_cli) values " +
                    $"('{u.DNI}'," +
                    $"'{u.Name}'," +
                    $"'{u.LastName}'," +
                    $"'{u.Phone}'," +
                    $"'{u.Fnac.Value.Year}-{u.Fnac.Value.Month}-{u.Fnac.Value.Day}'," +
                    $"'{u.Age}'," +
                    $"'{u.Gender}'," +
                    $"'{u.Dir}'" +
                    $")";
                new Conexion().NoResult(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
