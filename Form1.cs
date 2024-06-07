using ClasesINA.Formularios;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesINA
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            //acá vamos a configurar el color
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Blue500, Primary.Blue700,
                    Primary.Blue500,Accent.LightBlue200,
                    TextShade.WHITE
                );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comentario
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //esto es un comentario que no esta em git
        }

        private void btnConstantes_Click(object sender, EventArgs e)
        {
            //creamos una instancia del formulario Constante
            Constantes constantes = new Constantes();
            constantes.Show();//Le indicamos que se muestre
        }

        private void btnValoresCompuestos_Click(object sender, EventArgs e)
        {
            ValoresCompuestos vc = new ValoresCompuestos();
            vc.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EstructurasDeControl estructuras = new EstructurasDeControl();
            estructuras.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
