using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class PacienteCN
    {
        PacienteCD objPacienteCD = new PacienteCD();

        public DataTable ListaPacientes()
        {
            return objPacienteCD.ListaPacientes();
        }

        public DataTable BuscaPaciente(PacienteCE P)
        {
            return objPacienteCD.BuscaPaciente(P);
        }

        public void RegistrarPaciente(PacienteCE P)
        {
            objPacienteCD.RegistrarPaciente(P);
        }
        public void ModificarPaciente(PacienteCE P)
        {
            objPacienteCD.ModificarPaciente(P);
        }
        public void EliminarPaciente(PacienteCE P)
        {
            objPacienteCD.EliminarPaciente(P);
        }
    }
}
