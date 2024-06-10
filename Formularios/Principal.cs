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

        string[] Vproductos = {"Papas"}; //declaramos el vector para productos (que esté vacío)
        int[] VunidadesCompradas = {2};//vector para unidades compradas
        double[] VprecioUnitario = {100};
        double[] Vtotal = {2000};//vector para el total generado por la linea de compra (unidades * precio)


        string nombreProductoEliminar = "";

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
            ImprimirCompras();
        }

        /// <summary>
        /// Imprime la información del vector dentro del DataGridView
        /// </summary>
        private void ImprimirCompras() {
            dtCompras.Rows.Clear();
            for (int i = 0; i < Vproductos.Length; i++)
            {
                if (Vproductos[i] != "") {
                    dtCompras.Rows.Add(Vproductos[i], VprecioUnitario[i], VunidadesCompradas[i], Vtotal[i]);
                }
            }
        }

        private void txtPrecioUnitario_Leave(object sender, EventArgs e)
        {
            //primero determinamos si el ususuario digitó algo
            if (txtPrecioUnitario.Text.Length >= 0) {
                double numero = 0;
                bool EsNumero = double.TryParse(txtPrecioUnitario.Text, out numero);

                if (EsNumero)
                {
                    double precioUnitario = Convert.ToDouble(txtPrecioUnitario.Text);
                    int unidadesCompradas = Convert.ToInt32(slideUnidades.Value);
                    txtTotal.Text = "" + precioUnitario * unidadesCompradas;
                }
                else {
                    txtPrecioUnitario.Focus();
                    txtPrecioUnitario.Hint = "Debe ser número";//
                    txtPrecioUnitario.SelectAll();
                    txtPrecioUnitario.BackColor = Color.Red;
                }
            }
            

        }

        private void slideUnidades_onValueChanged(object sender, int newValue)
        {
            double precio = 0.0;
            bool precioUnitarioEsNumero = double.TryParse(txtPrecioUnitario.Text,out precio);
            if (precioUnitarioEsNumero)
            {
                int precioUnitario = Convert.ToInt32(txtPrecioUnitario.Text);
                int unidadesCompradas = Convert.ToInt32(slideUnidades.Value);
                txtTotal.Text = "" + precioUnitario * unidadesCompradas;
            }
            else {
                txtPrecioUnitario.Hint = "De ser número";
                txtPrecioUnitario.Focus();
            }
           
        }

        private void btnProcesarCompra_Click(object sender, EventArgs e)
        {
            double precio = 0.0;

            //conversión del tipo cadena a int
            int unidades = (int)slideUnidades.Value;
            bool precioEsValido = double.TryParse(txtPrecioUnitario.Text, out precio);
            double total = double.Parse(txtTotal.Text);

            string nombreProducto = txtProducto.Text;

            if (total <= 0 || unidades <= 0 || !precioEsValido) { 
                MessageBox.Show("Los valores no pueden ser cero o valores negativos");
            }else {
                if (string.IsNullOrEmpty(nombreProducto))
                {
                    MessageBox.Show("El nombre del producto no debe ser vacío");
                }
                else {//acá, entonces empezamos a realizar la inserción
                      //Ahora vamos a redimensionar los vectores
                   
                    double precioUnitario = Convert.ToDouble(txtPrecioUnitario.Text);
                   

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

                    ImprimirCompras();
                }
            }


        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

            int cantidadFilasSeleccionadas = dtCompras.SelectedRows.Count;

            if (cantidadFilasSeleccionadas <= 0)
            {
                MessageBox.Show("Debes seleccionar una fila");
            }
            else {
                if (string.IsNullOrEmpty(nombreProductoEliminar))
                {
                    MessageBox.Show("No has seleccionado un producto de la tabla, primero presiónalo");
                }
                else {
                    if (existeProducto(nombreProductoEliminar)) {
                        int posEliminar = IndiceDelElemento(nombreProductoEliminar);
                        if (posEliminar < 0)
                        {
                            MessageBox.Show("El producto no existe o fue eliminado");
                        }
                        else {
                            EliminarCompra(posEliminar);
                            MessageBox.Show("Se ha eliminado correctamente la compra");
                            ImprimirCompras();
                        }
                    }
                }
            }

        }
        /// <summary>
        /// Elimina el la información de los vectores mediante la posición indicada
        /// </summary>
        /// <param name="pos">Es la posición de la cual se eliminará toda la información</param>
        private void EliminarCompra(int pos) {
            Vproductos[pos] = "";
            VprecioUnitario[pos] = 0;
            VunidadesCompradas[pos] = 0;
            Vtotal[pos] = 0;
        }

        /// <summary>
        /// Obtiene el indice del elemento a buscar
        /// </summary>
        /// <param name="elemento">Elemento a buscar dentro del vector</param>
        /// <returns>Posición donde fue encontrado el elemento</returns>
        private int IndiceDelElemento(string elemento) {
            return Array.IndexOf(Vproductos, elemento);
        }

        /// <summary>
        /// Determina si el producto indicado, existe o no dentro del vector
        /// </summary>
        /// <param name="nombreProducto">Cadena (nombre del producto) a buscar dentro del arreglo</param>
        /// <returns>boolean true: existe False: no existe</returns>
        private bool existeProducto(string nombreProducto) {
            return Array.Exists(Vproductos, consulta => consulta == nombreProducto);
        }

       
        private void dtCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(dtCompras.Rows.Count);
            //Aqui obtenemos toda la fila (con todos sus encabezados)
            DataGridViewRow fila = dtCompras.SelectedRows[0];
            //aqui obtengo el nombre del producto a eliminar
            //recordar que el Cells[0] pertenece a la primera columna
            // Cells[1] sería precio unitario etc...
            //este valor se lo asigno a la variable global nombreProducto eliminar para poder visualizarlo desde el boton
            //de eliminar
            nombreProductoEliminar = fila.Cells[0].Value.ToString();
            txtProducto.Text = nombreProductoEliminar;
            txtPrecioUnitario.Text = ""+ fila.Cells[1].Value.ToString();
            slideUnidades.Value = int.Parse(fila.Cells[2].Value.ToString());
            txtTotal.Text = fila.Cells[3].Value.ToString();




            Console.WriteLine(nombreProductoEliminar);
        }
    }
}
