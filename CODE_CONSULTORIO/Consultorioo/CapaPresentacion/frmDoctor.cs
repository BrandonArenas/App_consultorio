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
    public partial class frmDoctor : Form
    {
        DoctorCN objdoc = new DoctorCN();

        public frmDoctor()
        {
            InitializeComponent();
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            dgdoctor.DataSource = objdoc.ListaDoctores();
        }

    
        private void dgdoctor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtdni.Text = dgdoctor.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgdoctor.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = dgdoctor.CurrentRow.Cells[2].Value.ToString();
            txttelefono.Text = dgdoctor.CurrentRow.Cells[3].Value.ToString();
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

        private void btnconsultar_Click_1(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                DoctorCE objdocCE = new DoctorCE();
                objdocCE.DNI = txtbuscar.Text;
                DataTable dt = new DataTable();
                dt = objdoc.BuscaDoctor(objdocCE);
                dgdoctor.DataSource = dt;
            }
            else
            {
                dgdoctor.DataSource = objdoc.ListaDoctores();
            }
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            DoctorCE objdocCE = new DoctorCE();
            objdocCE.DNI = txtdni.Text;
            objdocCE.NOMBRES = txtnombre.Text;
            objdocCE.APELLIDOS = txtapellido.Text;
            objdocCE.TELEFONO = txttelefono.Text;

            try
            {
                objdoc.RegistrarDoctor(objdocCE);
                MessageBox.Show("Se registro correctamente", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgdoctor.DataSource = objdoc.ListaDoctores();
            }
            catch (Exception)
            {

            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            DoctorCE objdocCE = new DoctorCE();
            objdocCE.DNI = txtdni.Text;
            objdocCE.NOMBRES = txtnombre.Text;
            objdocCE.APELLIDOS = txtapellido.Text;
            objdocCE.TELEFONO = txttelefono.Text;

            try
            {
                objdoc.ModificarDoctor(objdocCE);
                MessageBox.Show("Se actualizo correctamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgdoctor.DataSource = objdoc.ListaDoctores();
            }
            catch (Exception)
            {

            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            DoctorCE objdocCE = new DoctorCE();
            objdocCE.DNI = txtdni.Text;
            objdocCE.NOMBRES = txtnombre.Text;
            objdocCE.APELLIDOS = txtapellido.Text;
            objdocCE.TELEFONO = txttelefono.Text;

            try
            {
                objdoc.EliminarDoctor(objdocCE);
                MessageBox.Show("Se elimino correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgdoctor.DataSource = objdoc.ListaDoctores();
            }
            catch (Exception)
            {

            }
        }

        private void dgdoctor_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            txtdni.Text = dgdoctor.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgdoctor.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = dgdoctor.CurrentRow.Cells[2].Value.ToString();
            txttelefono.Text = dgdoctor.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
