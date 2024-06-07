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
    public partial class EstructurasDeControl : MaterialForm
    {
        String[] diasSemana = { "LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES"};

     


        public EstructurasDeControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 100;
            // x>50 x entre 100 y 200 etc

            if (x > 50)
            {
                MessageBox.Show($" {x} si es mayor que 50");
            }
            else if (x > 100)
            {
                MessageBox.Show($" {x} no es mayor que 50");
            }
            else {
                if (x < 50) {
                    MessageBox.Show($" {x} < que 50");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int opcionUsuario = 5;

            switch (opcionUsuario) {
                case 1:
                    Console.WriteLine("Es uno");
                    break;
                case 2:
                    Console.WriteLine("Es dos");
                    break;
                default:
                    Console.WriteLine("No es ni uno ni dos");
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"vamos por: {i}");
            }
            */
            int[] numeros = { 1, 2, 3, 4, 6, 77, 456, 345, 123 };
        
            foreach(int x in numeros) {
                Console.WriteLine($"{x}");
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"vamos por: {numeros[i]}");
            }

            String[] palabras = { "Hola", "Espero", "la", "pases", "bien" };
            foreach (string x in palabras) {
                Console.WriteLine(x);
            }

            for (int i=0; i<palabras.Length; i+=2) {
                Console.WriteLine(palabras[i]);
            }

            //también es posible hacer el siguiente ciclo
            //for (int i = 0; i < palabras.Length; Console.WriteLine(palabras[i+=2]));
        }

        private void EstructurasDeControl_Load(object sender, EventArgs e)
        {
            //VECTOR CON LOS DIAS DE LA SEMANA
            
            dtDias.Rows.Clear();//quita las filas que tiene el data

            foreach (string dia in diasSemana) {
                dtDias.Rows.Add(dia);//agregamos la fila al dt (la fila de cada iteración)
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

         
            string dia = txtDiaSemana.Text.Replace(" ","");

            if (string.IsNullOrEmpty(dia))
            {
                MessageBox.Show("Debes ingresar el día a registrar");
                txtDiaSemana.Focus();
            }
            else { 
                int pos = Array.IndexOf(diasSemana, dia);

                if (pos != -1)
                {
                    MessageBox.Show($"{dia} ya se encuentra registrado");
                }
                else { 
                    Array.Resize(ref diasSemana, diasSemana.Length+1);
                    diasSemana[diasSemana.Length-1] = dia;
                    dtDias.Rows.Clear();

                    txtDiaSemana.Text = "";
                   
                    foreach (string d in diasSemana) {
                       dtDias.Rows.Add((string)d);
                    }

                }
            }

        }

        private void dtDias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDiaSemana.Text = (string) dtDias[e.ColumnIndex, e.RowIndex].Value;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string dia = txtDiaSemana.Text;

            if (!dia.Equals("")){//En dado caso que no haya seleccionado un día para eliminarlo
                //acá abajo preguntamos si desea realmente eliminar el día seleccionado
                DialogResult opcionUsuario = MessageBox.Show(
                $"¿Deseas eliminar el día {txtDiaSemana.Text}?",//mensaje que pregunta
                "Advertencia!", //este es el título de la ventana
                MessageBoxButtons.YesNo);//opciones (botones) que salen de la ventana

                switch (opcionUsuario)
                {
                    case DialogResult.Yes:

                        bool existe = Array.Exists(diasSemana, filtro => filtro.Equals(dia));

                        if (existe)
                        {
                            //aqui lo que hago es salvar el ultimo valor del arreglo
                            string valorTemp = diasSemana[diasSemana.Length - 1];
                            //obtengo la posición del elemento que quiero quitar:
                            int posQuitar = Array.IndexOf(diasSemana, dia);
                            //Aquí reemplazo el valor que quiero quitar, por el ultimo valor que reemplacé
                            diasSemana[posQuitar] = valorTemp;
                            //ahora lo que hago es redimensionar el vector para quitar el ultimo element
                            Array.Resize(ref diasSemana, diasSemana.Length - 1);
                            //quitamos todas las filas del DataGrid
                            dtDias.Rows.Clear();

                            foreach (string d in diasSemana)
                            {
                                dtDias.Rows.Add(d);
                            }
                            //limpiamos el campo de texto para esperar que el usuario pueda seleccionar otro
                            txtDiaSemana.Text = "";
                        }
                        else {
                            MessageBox.Show($"El día {dia} no se encuentra registrado o fue eliminado");
                        }

                        break;
                    case DialogResult.No:
                        MessageBox.Show("Descuida, no eliminamos nada!");
                        break;
                }
            }
        }

        int contadorClicks = 0;
        private void label4_Click(object sender, EventArgs e)
        {
            if (contadorClicks < diasSemana.Length)
            {
                txtDiaSemana.Text = diasSemana.ElementAt(contadorClicks).ToString();
                contadorClicks++;
                dtDias.ClearSelection();
                dtDias.Rows[contadorClicks].Selected = true;
            }
            else {
                //por fuerza le ponemos como valor el ultimo elemento
                txtDiaSemana.Text = diasSemana[diasSemana.Length - 1];
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            contadorClicks--;
            if (contadorClicks > 0)
            {
                txtDiaSemana.Text = diasSemana.ElementAt(contadorClicks).ToString();
                dtDias.ClearSelection();
                dtDias.Rows[contadorClicks].Selected = true;
            }
            else if (contadorClicks == 0) {
                txtDiaSemana.Text = diasSemana[0];
                dtDias.ClearSelection();
                dtDias.Rows[0].Selected = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            string diaBuscar = txtDiaSemana.Text;
            if (diaBuscar.Equals(""))
            {
                MessageBox.Show("Debes escribir un día para buscar", "Información", MessageBoxButtons.OK);
            }
            else {
                bool existe = Array.Exists(diasSemana, filtro => filtro == diaBuscar);
                if (!existe)
                {
                    MessageBox.Show($"El día {diaBuscar} no existe o fue eliminado");
                }
                else { 
                    int pos = Array.IndexOf(diasSemana, diaBuscar);
                    dtDias.Rows.Clear();
                    dtDias.Rows.Add(diasSemana[pos]);

                }
            }

        }

        private void txtDiaSemana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDiaSemana.Text.Equals("")) {
                dtDias.Rows.Clear();

                foreach (string d in diasSemana)
                {
                    dtDias.Rows.Add((string)d);
                }
            }
        }
    }
}
