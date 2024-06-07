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
    public partial class Acceso : MaterialForm
    {
        public static string[] usuario = { "Admin" };
        public static string[] contrasennia = { "123" };

        public Acceso()
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

        private void Acceso_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreaCuentas crea = new CreaCuentas();
            crea.Show();
        }

        private void Acceso_Activated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CreaCuentas.usuario)) {
                txtUsuario.Text = CreaCuentas.usuario;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string usuarioAutentica = txtUsuario.Text;
            string passwdAutentica = txtPassword.Text;

            bool existeUsuario = Array.Exists(usuario, filtro => filtro == usuarioAutentica);
            bool existePasswd = Array.Exists(contrasennia, filtro => filtro == passwdAutentica);

            if (existePasswd && existeUsuario) {
                Principal principal = new Principal();
                principal.Show();
                Visible = false;//ocultar la ventana
            }
            else
            {
                MessageBox.Show(
                    "Usuario y/o contraseña no coinciden",
                    "Error de acceso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }

        }
    }
}
