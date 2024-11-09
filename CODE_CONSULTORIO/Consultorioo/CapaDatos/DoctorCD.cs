using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using CapaEntidad;

namespace CapaDatos
{
    public class DoctorCD
    {
        SqlConnection cn;
        Conexion objconexion = new Conexion();

        //Lista doctores
        public DataTable ListaDoctores()
        {
            cn = objconexion.getConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTADOCTOR", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Buscar doctor
        public DataTable BuscaDoctor(DoctorCE D)
        {
            cn = objconexion.getConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_BUSCARDOCTOR", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@DNI", SqlDbType.VarChar).Value = D.DNI;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Registrar doctor
        public void RegistrarDoctor(DoctorCE D)
        {
            cn = objconexion.getConexion();
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_NUEVODOCTOR";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.Add("@DNI", SqlDbType.Char).Value = D.DNI;
            cmd.Parameters.Add("@NOM", SqlDbType.Char).Value = D.NOMBRES;
            cmd.Parameters.Add("@APE", SqlDbType.Char).Value = D.APELLIDOS;
            cmd.Parameters.Add("@TEL", SqlDbType.Char).Value = D.TELEFONO;

            cmd.ExecuteNonQuery();
        }

        //Modificar doctor
        public void ModificarDoctor(DoctorCE D)
        {
            cn = objconexion.getConexion();
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_MODIFICADOCTOR";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.Add("@DNI", SqlDbType.Char).Value = D.DNI;
            cmd.Parameters.Add("@NOM", SqlDbType.Char).Value = D.NOMBRES;
            cmd.Parameters.Add("@APE", SqlDbType.Char).Value = D.APELLIDOS;
            cmd.Parameters.Add("@TEL", SqlDbType.Char).Value = D.TELEFONO;

            cmd.ExecuteNonQuery();
        }

        //Eliminar doctor
        public void EliminarDoctor(DoctorCE D)
        {
            cn = objconexion.getConexion();
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_ELIMINARDOCTOR";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.Add("@DNI", SqlDbType.Char).Value = D.DNI;

            cmd.ExecuteNonQuery();
        }

    }
}