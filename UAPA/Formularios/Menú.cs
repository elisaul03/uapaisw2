using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UAPA
{
    public partial class fmrmenu : Form
    {
        public fmrmenu()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static DataGridViewDataErrorContexts ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wm5g,
            int wparam, int lparam);

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bimestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void facilitadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void participanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form formulario = new fmrlogin();
            formulario.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new fmrasignaturas();
            formulario.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new fmrfacilitador();
            formulario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new fmrparticipante();
            formulario.Show();
            this.Hide();
        }


        private void pnmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnusu_Click(object sender, EventArgs e)
        {
            Form formulario = new Usuarios();
            formulario.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void fmrmenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
