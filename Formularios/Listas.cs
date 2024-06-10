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
    public partial class Listas : Form
    {
        //creamos una instancia del tipo list de tipo entero
        List<int> numeros = new List<int>();//lista vacia

        //lista con valores predefinidos al momento de la ejecución
        List<int> numerosPredeterminados = new List<int> {10,20,30,40}; 


        public Listas()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            foreach (int numero in numerosPredeterminados) {
                Console.WriteLine(numero);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            int numero = 0;
            bool esNumero = int.TryParse(txtNumero.Text, out numero);
            if (esNumero) {
                //con esta instruccion agregamos  un valor nuevo a la lista
                numerosPredeterminados.Add(numero);
                //llamamos al evento del botón anterior
                materialButton1_Click(sender, e);

            }



        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            int numero = 0;
            //determinamos si el valor que recogemos del campo de texto, es un número o no
            bool esNumero = int.TryParse(txtNumero.Text, out numero);
            //preguntamos si es verdadero recordar que es lo mismo que preguntar esNumero == true
            if (esNumero)
            {
                //aqui aplicamos un filtro para determinar si dentro de la lista existe o no el número que capturamos
                bool existe = numerosPredeterminados.Exists(filtro => filtro == numero);
                if (existe)
                {
                    //Después de haber validado si existe el número, se procede a eliminar el valor de la colección
                    numerosPredeterminados.Remove(numero);
                    MessageBox.Show($"El número {numero} fu eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //llamamos al evento del boton para imprimirlo
                    materialButton1_Click(sender, e);
                    txtNumero.Text = "";
                }
                else {
                    MessageBox.Show($"El número {numero} no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            
        }
    }
}
