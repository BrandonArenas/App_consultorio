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
    public class PacienteCD
    {
        SqlConnection cn;
        Conexion objconexion = new Conexion();

        //Lista pacientes
        public DataTable ListaPacientes()
        {
            cn = objconexion.getConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTAPACIENTE", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Buscar paciente
        public DataTable BuscaPaciente(PacienteCE P)
        {
            cn = objconexion.getConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_BUSCARPACIENTE", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@DNI", SqlDbType.VarChar).Value = P.DNI;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Registrar paciente
        public void RegistrarPaciente(PacienteCE P)
        {
            cn = objconexion.getConexion();
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_NUEVOPACIENTE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.Add("@DNI", SqlDbType.Char).Value = P.DNI;
            cmd.Parameters.Add("@NOM", SqlDbType.Char).Value = P.NOMBRES;
            cmd.Parameters.Add("@APE", SqlDbType.Char).Value = P.APELLIDOS;
            cmd.Parameters.Add("@TEL", SqlDbType.Char).Value = P.TELEFONO;

            cmd.ExecuteNonQuery();   
        }

        //Modificar paciente
        public void ModificarPaciente(PacienteCE P)
        {
            cn = objconexion.getConexion();
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_MODIFICAPACIENTE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.Add("@DNI", SqlDbType.Char).Value = P.DNI;
            cmd.Parameters.Add("@NOM", SqlDbType.Char).Value = P.NOMBRES;
            cmd.Parameters.Add("@APE", SqlDbType.Char).Value = P.APELLIDOS;
            cmd.Parameters.Add("@TEL", SqlDbType.Char).Value = P.TELEFONO;

            cmd.ExecuteNonQuery();
        }

        //Eliminar paciente
        public void EliminarPaciente(PacienteCE P)
        {
            cn = objconexion.getConexion();
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_ELIMINARPACIENTE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.Add("@DNI", SqlDbType.Char).Value = P.DNI;

            cmd.ExecuteNonQuery();
        }




    }
}
