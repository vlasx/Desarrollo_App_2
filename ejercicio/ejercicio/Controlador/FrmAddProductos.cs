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
    public partial class FrmAddProductos : Form
    {
        public FrmAddProductos()
        {
            InitializeComponent();
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            bool bandera = true;
            decimal precio = new decimal(0.0);
            try
            {
                precio = Decimal.Parse(this.txtPrecio.Text);
            }
            catch(Exception)
            {
                bandera = false;
            }
            //switch (cbProductos.Text)
            //{
            //    case " ":
            //}
            //if (this.txtNombre.Text.Trim().Length == 0)
            //    bandera = false;
            if (bandera)
            {
                Data.add( new Productos(Productos.Producto.quesadillas, precio));
            }
            else
            {
                MessageBox.Show("Dato no Valido", "App Cliente - Administrador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmAddProductos_Load(object sender, EventArgs e)
        {
           
        }
    }
}
