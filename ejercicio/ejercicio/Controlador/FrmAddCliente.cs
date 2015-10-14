using ejercicio.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio.Controlador
{
    public partial class FrmAddCliente : Form
    {
        public FrmAddCliente()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0 && MessageBox.Show("Deseas Agregar cliente " + txtNombre.Text, "App Empleado - Cliente",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Data.add(new cliente(txtNombre.Text.Trim()));
                MessageBox.Show("Cliente Agregado", "Ap - Empleado - Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNombre.Text = "";
            }
            else
            {
                MessageBox.Show("Favor de Introducir Datos Validos","App - Empleado - Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
