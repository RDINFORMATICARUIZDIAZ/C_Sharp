using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MICRUD.Logica;
using System.Windows.Forms;

namespace MICRUD.Datos
{
    public class Dcargos
    {
        public bool insertar_cargo(Lcargos parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_cargo", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cargo", parametros.cargo);
                cmd.Parameters.AddWithValue("@sueldoPorHora", parametros.sueldoPorHora);
                //cmd.Parameters.AddWithValue("@Pais", parametros.Pais);
                //cmd.Parameters.AddWithValue("@id_cargo", parametros.Id_cargo);
                //cmd.Parameters.AddWithValue("@SueldoPorHora", parametros.SueldoPorHora);
                cmd.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

        public bool editar_cargo(Lcargos parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_cargo", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@cargo", parametros.cargo);
                cmd.Parameters.AddWithValue("@sueldoPorHora", parametros.sueldoPorHora);
                //cmd.Parameters.AddWithValue("@Pais", parametros.Pais);
                //cmd.Parameters.AddWithValue("@id_cargo", parametros.Id_cargo);
                //cmd.Parameters.AddWithValue("@SueldoPorHora", parametros.SueldoPorHora);
                cmd.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

        public void buscarCargos(ref DataTable dt, string buscador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscarCargos", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscador", buscador);
                //da.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                //da.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }


    }
}
