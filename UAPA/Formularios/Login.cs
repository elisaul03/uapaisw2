using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace UAPA
{
    public partial class fmrlogin : Form
    {

        public fmrlogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static DataGridViewDataErrorContexts ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wm5g,
            int wparam, int lparam);

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtusuario.Text) == true)
            {
                MessageBox.Show(" El campo USUARIO no debe quedar vacio, especifique el usuario ");
                txtusuario.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtclave.Text) == true)
            {
                MessageBox.Show(" El campo CLAVE no debe quedar vacio, especifique la clave ");
                txtclave.Focus();
                return;
            }
            clase_metodos datos = new clase_metodos();

            if (datos.entrar(txtusuario.Text, txtclave.Text) == true)
            {
                Welcome formulario = new Welcome();
                formulario.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecta, por favor verificar");
                txtusuario.Clear();
                txtclave.Clear();
                txtusuario.Focus();
            }



        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chbclave_CheckedChanged(object sender, EventArgs e)
        {
            if (chbclave.Checked == true)
            {
                if (txtclave.PasswordChar == '*')
                {
                    txtclave.PasswordChar = '\0';

                }

            }
            else
            {
                txtclave.PasswordChar = '*';

            }
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtclave_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "CONTRASEÑA")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;
            }
        }

        private void txtclave_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "CONTRASEÑA";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void fmrlogin_Load(object sender, EventArgs e)
        {

        }

        private void fmrlogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnentrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            clase_metodos datos = new clase_metodos();

            if (datos.entrar(txtusuario.Text, txtclave.Text) == true)
            {
                Welcome formulario = new Welcome();
                formulario.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecta, por favor verificar");
                txtusuario.Clear();
                txtclave.Clear();
                txtusuario.Focus();
            }
        }
    }

}
