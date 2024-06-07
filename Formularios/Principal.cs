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

namespace ClasesINA.Formularios
{
    public partial class Principal : MaterialForm
    {

        string[] Vproductos = { }; //declaramos el vector para productos (que esté vacío)
        int[] VunidadesCompradas = { };//vector para unidades compradas
        double[] VprecioUnitario, Vtotal = { };//vector para el total generado por la linea de compra (unidades * precio)


        public Principal()
        {
            InitializeComponent();
            /*
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            //acá vamos a configurar el color
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Blue500, Primary.Blue700,
                    Primary.Blue500, Accent.LightBlue200,
                    TextShade.WHITE
                );
            */
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void txtPrecioUnitario_Leave(object sender, EventArgs e)
        {
            int precioUnitario = Convert.ToInt32(txtPrecioUnitario.Text);
            int unidadesCompradas = Convert.ToInt32(slideUnidades.Value);
            txtTotal.Text = "" + precioUnitario * unidadesCompradas;

        }

        private void slideUnidades_onValueChanged(object sender, int newValue)
        {
            int precioUnitario = Convert.ToInt32(txtPrecioUnitario.Text);
            int unidadesCompradas = Convert.ToInt32(slideUnidades.Value);
            txtTotal.Text = "" + precioUnitario * unidadesCompradas;
        }

        private void btnProcesarCompra_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtProducto.Text;
            int unidades = Convert.ToInt32(slideUnidades.Value);
            double precioUnitario = Convert.ToDouble(txtPrecioUnitario.Text);
            double total  = Convert.ToDouble(txtTotal.Text);

            

            if (total <= 0 || unidades <= 0 || precioUnitario <= 0) { 
                MessageBox.Show("Los valores no pueden ser cero");
            }else {
                if (string.IsNullOrEmpty(nombreProducto))
                {
                    MessageBox.Show("El nombre del producto no debe ser vacío");
                }
                else {//acá, entonces empezamos a realizar la inserción
                      //Ahora vamos a redimensionar los vectores
                    Array.Resize(ref Vproductos, Vproductos.Length + 1);
                    Array.Resize(ref VunidadesCompradas, VunidadesCompradas.Length+1);
                    Array.Resize(ref VprecioUnitario, VprecioUnitario.Length + 1);
                    Array.Resize(ref Vtotal, Vtotal.Length + 1);
                    //ya que hicimos espacio, vamos a guardar en ese espacio, los valores calculados
                    Vproductos[Vproductos.Length - 1] = nombreProducto;
                    VunidadesCompradas[VunidadesCompradas.Length -1 ] = unidades;
                    VprecioUnitario[VprecioUnitario.Length - 1] = precioUnitario;
                    Vtotal[Vtotal.Length -1 ] = total;
                    //acá únicamente empezamos a limpiar los datos del formulario para poder registrar otro producto
                    txtPrecioUnitario.Text = "";
                    txtProducto.Text = "";
                    txtTotal.Text = "0.0";
                    slideUnidades.Value = 0;//volvemos a hacer que el slide tenga como valor el 0
                    MessageBox.Show("Compra efectuada con éxito");
                    txtProducto.Focus();//para poner el foco dentro del primer campo de texto
                }
            }


        }
    }
}
