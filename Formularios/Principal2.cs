using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesINA.Formularios
{
    public partial class Principal2 : Form
    {
        public Principal2()
        {
            InitializeComponent();
        }

        private void facturarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedor.Controls.Clear();  //quitamos forms si ya los hay
            //creamos una isntancia del formulario a abrir
            Principal facturacion = new Principal();
            //le indicamos que no es el principal (sino que es secundario)
            facturacion.TopLevel = false;
            //permite hacer scroll en caso de desbordamiento de info
            facturacion.AutoScroll = true;
            //quitamos bordes
            facturacion.FormBorderStyle = FormBorderStyle.None;
            //hacemos que se estire al máximo
            //facturacion.Dock = DockStyle.Fill;
            //y finalmente lo pegamos al panel que agregamos en el formulario
            Contenedor.Controls.Add(facturacion);
            //hacemos visible el formulario
            facturacion.Show(); 

        }

        private void crearCuentaDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedor.Controls.Clear();  //quitamos forms si ya los hay
            //creamos una isntancia del formulario a abrir
            CreaCuentas crear = new CreaCuentas();
            //le indicamos que no es el principal (sino que es secundario)
            crear.TopLevel = false;
            //permite hacer scroll en caso de desbordamiento de info
            crear.AutoScroll = true;
            //quitamos bordes
            crear.FormBorderStyle = FormBorderStyle.None;
            //hacemos que se estire al máximo
            //facturacion.Dock = DockStyle.Fill;
            //y finalmente lo pegamos al panel que agregamos en el formulario
            Contenedor.Controls.Add(crear);

            crear.Show();
        }

        private void Principal2_Load(object sender, EventArgs e)
        {
            crearCuentaDeUsuarioToolStripMenuItem.ToolTipText = "Este es un tootip programado con código";
        }

        private void formularioDeListasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedor.Controls.Clear();  //quitamos forms si ya los hay
            //creamos una isntancia del formulario a abrir
            Listas listas = new Listas();
            //le indicamos que no es el principal (sino que es secundario)
            listas.TopLevel = false;
            //permite hacer scroll en caso de desbordamiento de info
            listas.AutoScroll = true;
            //quitamos bordes
            listas.FormBorderStyle = FormBorderStyle.None;
            //hacemos que se estire al máximo
            //facturacion.Dock = DockStyle.Fill;
            //y finalmente lo pegamos al panel que agregamos en el formulario
            Contenedor.Controls.Add(listas);

            listas.Show();
        }
    }
}
