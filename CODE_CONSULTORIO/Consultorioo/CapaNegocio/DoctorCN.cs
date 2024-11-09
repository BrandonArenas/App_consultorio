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
    public class DoctorCN
    {
        DoctorCD objDoctorCD = new DoctorCD();

        public DataTable ListaDoctores()
        {
            return objDoctorCD.ListaDoctores();
        }

        public DataTable BuscaDoctor(DoctorCE D)
        {
            return objDoctorCD.BuscaDoctor(D);
        }

        public void RegistrarDoctor(DoctorCE D)
        {
            objDoctorCD.RegistrarDoctor(D);
        }

        public void ModificarDoctor(DoctorCE D)
        {
            objDoctorCD.ModificarDoctor(D);
        }

        public void EliminarDoctor(DoctorCE D)
        {
            objDoctorCD.EliminarDoctor(D);
        }
    }
}
