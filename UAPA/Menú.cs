using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAPA
{
    public partial class fmrmenu : Form
    {
        public fmrmenu()
        {
            InitializeComponent();
        }

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
            Close();
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
    }
}
