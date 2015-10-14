using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejercicio.Vista;
using ejercicio.Controlador;


namespace ejercicio
{
    public partial class FrmPrincipal : Form
    {
        VistaDatos vista = new VistaDatos();
        List<Productos> productos = new List<Productos>();
        List<Manger> administrativos = new List<Manger>();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productos.Add(new Productos(Productos.Producto.quesadillas, new decimal(10.5)));
            administrativos.Add(new Manger("007", "James", "Bond", "England", Manger.Depto.Ventas));
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro que quieres salir?","App Empleados Clientes", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            this.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddCliente formulario = new FrmAddCliente();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void altasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void altasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmAddProductos formulario = new FrmAddProductos();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente formulario = new FrmCliente();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void catalogoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAdministrador formulario = new FrmAdministrador();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void catalogoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmProducto formulario = new FrmProducto();
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}
