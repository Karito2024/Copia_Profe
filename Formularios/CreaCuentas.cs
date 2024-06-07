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
    public partial class CreaCuentas : MaterialForm
    {
        //Variable global para accederla desde el otro formulario
        public static String usuario ="";

        public CreaCuentas()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            //acá vamos a configurar el color
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Blue500, Primary.Blue700,
                    Primary.Blue500, Accent.LightBlue200,
                    TextShade.WHITE
                );
        }

        private void CreaCuentas_Load(object sender, EventArgs e)
        {
           
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (txtUsuarioCrear.Text.Equals(""))
            {
                MessageBox.Show("No ingresaste el nombre de usuario");
            }
            else {
                if (txtContrasennia.Text.Equals("") || txtRepiteContrasennia.Text.Equals(""))
                {
                    MessageBox.Show("No ingresaste la contraseña");
                }
                else {
                    if (!txtContrasennia.Text.Equals(txtRepiteContrasennia.Text))
                    {
                        MessageBox.Show("Las contraseñas no coinciden!");
                    }
                    else {
                        //Código para empezar a crear el usuario    
                        string usuarioRegistrar = txtUsuarioCrear.Text;//capturo el usuario digitado en el txt
                        string contrasennia = txtContrasennia.Text;


                        bool existe = Array.Exists(Acceso.usuario, filtro => filtro == usuarioRegistrar);
                        if (existe)//en caso de que realmente ya esté registrado en la colección
                        {   //entonces mostramos un mensaje al usuario indicando que ya existe
                            MessageBox.Show($"El usuario {usuarioRegistrar} ya existe dentro de la base de datos");
                        }
                        else {//en caso de que no se haya registrado entonces, lo registramos
                            // primero hacemos crecer los vectores para darle espacio al nuevo usuario
                            Array.Resize(ref Acceso.usuario, Acceso.usuario.Length + 1);
                            Array.Resize(ref Acceso.contrasennia, Acceso.contrasennia.Length + 1);

                            Acceso.usuario[Acceso.usuario.Length - 1] = usuarioRegistrar;
                            Acceso.contrasennia[Acceso.contrasennia.Length - 1] = contrasennia;

                            MessageBox.Show($"Usuario: {usuarioRegistrar} creado existosamente!");

                            DialogResult respuesta =  MessageBox.Show("Deseas autenticarte con este usuario? ","Pregunta",
                                MessageBoxButtons.OKCancel
                                );

                            switch (respuesta) {
                                case DialogResult.OK:
                                    usuario = usuarioRegistrar;
                                    this.Dispose();//cierra la ventana
                                    break;
                                case DialogResult.Cancel:
                                    break;
                            }
                        }
                    }
                }
            }
        }//finaliza el evento del bótón

        private void CreaCuentas_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
