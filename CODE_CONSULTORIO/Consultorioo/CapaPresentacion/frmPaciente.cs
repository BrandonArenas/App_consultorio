using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class frmPaciente : Form
    {
        PacienteCN objpaci = new PacienteCN();

        public frmPaciente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgpaciente.DataSource = objpaci.ListaPacientes();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                PacienteCE objpaciCE = new PacienteCE();
                objpaciCE.DNI = txtbuscar.Text;
                DataTable dt = new DataTable();
                dt = objpaci.BuscaPaciente(objpaciCE);
                dgpaciente.DataSource = dt;
            }
            else
            {
                dgpaciente.DataSource = objpaci.ListaPacientes();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            PacienteCE objpaciCE = new PacienteCE();
            objpaciCE.DNI = txtdni.Text;
            objpaciCE.NOMBRES = txtnombre.Text;
            objpaciCE.APELLIDOS = txtapellido.Text;
            objpaciCE.TELEFONO = txttelefono.Text;

            try
            {
                objpaci.RegistrarPaciente(objpaciCE);
                MessageBox.Show("Se registro correctamente","Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgpaciente.DataSource = objpaci.ListaPacientes();
            }
            catch (Exception)
            {

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            PacienteCE objpaciCE = new PacienteCE();
            objpaciCE.DNI = txtdni.Text;
            objpaciCE.NOMBRES = txtnombre.Text;
            objpaciCE.APELLIDOS = txtapellido.Text;
            objpaciCE.TELEFONO = txttelefono.Text;

            try
            {
                objpaci.ModificarPaciente(objpaciCE);
                MessageBox.Show("Se actualizo correctamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgpaciente.DataSource = objpaci.ListaPacientes();
            }
            catch (Exception)
            {

            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PacienteCE objpaciCE = new PacienteCE();
            objpaciCE.DNI = txtdni.Text;
            objpaciCE.NOMBRES = txtnombre.Text;
            objpaciCE.APELLIDOS = txtapellido.Text;
            objpaciCE.TELEFONO = txttelefono.Text;

            try
            {
                objpaci.EliminarPaciente(objpaciCE);
                MessageBox.Show("Se elimino correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgpaciente.DataSource = objpaci.ListaPacientes();
            }
            catch (Exception)
            {

            }
        }

        private void dgpaciente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtdni.Text = dgpaciente.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgpaciente.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = dgpaciente.CurrentRow.Cells[2].Value.ToString();
            txttelefono.Text = dgpaciente.CurrentRow.Cells[3].Value.ToString();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            
        }
      
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
