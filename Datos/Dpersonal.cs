﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MICRUD.Logica;
using System.Windows.Forms;
using System.Net.Configuration;




namespace MICRUD.Datos
{
    public class Dpersonal
    {

        public bool InsertarPersonal(Lpersonal parametros)
        {
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("InsertarPersonal",CONEXIONMAESTRA.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Nombres", parametros.Nombres);
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Pais", parametros.Pais);
                cmd.Parameters.AddWithValue("@id_cargo", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@SueldoPorHora", parametros.SueldoPorHora);
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
        public bool editarPersonal(Lpersonal parametros)
        {
            try
            {

                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editarPersonal", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Personal", parametros.Id_personal);
                cmd.Parameters.AddWithValue("@Nombres", parametros.Nombres);
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Pais", parametros.Pais);
                cmd.Parameters.AddWithValue("@Id_cargo", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@SueldoPorHora", parametros.SueldoPorHora);
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
        public bool eliminarPersonal(Lpersonal parametros)
        {
            try
            {

                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("eliminarPersonal", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Personal", parametros.Id_personal);
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
        public void mostrarPersonal(ref DataTable dt,int desde,int hasta)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarPersonal",CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
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
        public void BuscarPersonal(ref DataTable dt, int desde, int hasta, string buscador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("BuscarPersonal", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@hasta", hasta);
                da.SelectCommand.Parameters.AddWithValue("@buscador", buscador);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

        public void BuscarPersonalIdentidad(ref DataTable dt, string buscador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("BuscarPersonalIdentidad", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Buscadorid", buscador);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

        //public void buscarAsistenciasId(ref DataTable dt, int Idpersonal)
        //{
        //    try
        //    {
        //        CONEXIONMAESTRA.abrir();
        //        SqlDataAdapter da = new SqlDataAdapter("buscarAsistenciasId", CONEXIONMAESTRA.conectar);
        //        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //        da.SelectCommand.Parameters.AddWithValue("@Idpersonal", Idpersonal);
        //        da.Fill(dt);
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        CONEXIONMAESTRA.cerrar();
        //    }
        //}

        public bool restaurar_personal(Lpersonal parametros)
        {
            try
            {

                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("restaurar_personal", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idpersonal", parametros.Id_personal); ;
                //cmd.Parameters.AddWithValue("@Nombres", parametros.Nombres);
                //cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                //cmd.Parameters.AddWithValue("@Pais", parametros.Pais);
                //cmd.Parameters.AddWithValue("@Id_cargo", parametros.Id_cargo);
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
        public void ContarPersonal(ref int Contador) 

        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("Select COUNT (id_personal) from Personal",CONEXIONMAESTRA.conectar);
                Contador= Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                Contador = 0;
            }
                finally{
                CONEXIONMAESTRA.cerrar();
            }
        }
    }
}
