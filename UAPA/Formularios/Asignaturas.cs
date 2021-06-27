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
    public partial class fmrasignaturas : Form
    {
        SqlConnection conexionsql = new SqlConnection(@"Data Source=DESKTOP-EVQDN0O;Initial Catalog=UAPA;Integrated Security=True");
        //conección con SQL SERVER
        

        public fmrasignaturas()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static DataGridViewDataErrorContexts ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wm5g,
            int wparam, int lparam);

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new fmrmenu();
            formulario.Show();
            this.Hide();
        }

        private void btnnuevorgA_Click(object sender, EventArgs e)
        {
            CLASE_LIMPIAR limpia = new CLASE_LIMPIAR();
            limpia.limpiar_campos(this, tp2);
            txtcodasig.Text = "0";
            tabControl1.SelectTab(tp2);
            txtcodasig.Focus();
        }

        private void btnconsultaA_Click(object sender, EventArgs e)
        {
            string consulta = txtconsultaA.Text;

            if (txtconsultaA.Text == "")
            {
                string sentencia = "select cod_asig as Código,clave_asig as Clave, nom_asig as Nombre, ht_asig as Horas_Teoricas, hp_asig as Horas_Prácticas, cr_asig as Creditos, pre_req_asig as Pre_Resquisito, status_asig as Estatus from ASIGNATURAS"; 
                SqlCommand comando = new SqlCommand(sentencia, conexionsql);
                SqlDataAdapter dt = new SqlDataAdapter(comando);
                DataTable tablaASI = new DataTable();
                dt.Fill(tablaASI);
                dgvconsultaA.DataSource = tablaASI;
            }
            else
            {
                string sentencia = "select cod_asig as Código,clave_asig as Clave, nom_asig as Nombre, ht_asig as Horas_Teoricas, hp_asig as Horas_Prácticas, cr_asig as Creditos, pre_req_asig as Pre_Resquisito, status_asig as Estatus from ASIGNATURAS  where cod_asig = '" + consulta + "'";
                SqlCommand comando = new SqlCommand(sentencia, conexionsql);
                SqlDataAdapter dt = new SqlDataAdapter(comando);
                DataTable tablaASI = new DataTable();
                dt.Fill(tablaASI);
                dgvconsultaA.DataSource = tablaASI;

            }
            txtconsultaA.Clear();
            txtconsultaA.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //validar texbox y combobox
            if (string.IsNullOrWhiteSpace(txtclave.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtclave.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtnombre.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtnombre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txthorast.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txthorast.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txthorasp.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txthorasp.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtcreditos.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtcreditos.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtpre.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtpre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbestatus.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                cmbestatus.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtcodasig.Text) == true)
            {
                string codigo = "0";
                clase_tipo_datosas tipos = new clase_tipo_datosas();
                tipos.cod_asig = int.Parse(codigo);
                tipos.clave_asig = txtclave.Text;
                tipos.nom_asig = txtnombre.Text;
                tipos.ht_asig = txthorast.Text;
                tipos.hp_asig = txthorasp.Text;
                tipos.cr_asig = txtcreditos.Text;
                tipos.pre_req_asig = txtpre.Text;
                tipos.status_asig = cmbestatus.Text;

                clase_metodos datos = new clase_metodos();
                datos.registrarasignaturas(tipos);
                MessageBox.Show("Asignatura registrado correctamente");
            }
            else
            {
                clase_tipo_datosas tipos = new clase_tipo_datosas();
                tipos.cod_asig = int.Parse(txtcodasig.Text);
                tipos.clave_asig = txtclave.Text;
                tipos.nom_asig = txtnombre.Text;
                tipos.ht_asig = txthorast.Text;
                tipos.hp_asig = txthorasp.Text;
                tipos.cr_asig = txtcreditos.Text;
                tipos.pre_req_asig = txtpre.Text;
                tipos.status_asig = cmbestatus.Text;

                clase_metodos datos = new clase_metodos();
                datos.registrarasignaturas(tipos);
                MessageBox.Show("Asignatura actualizada correctamente");
            }

            CLASE_LIMPIAR limpia = new CLASE_LIMPIAR();
            limpia.limpiar_campos(this, tp2);
            txtcodasig.Focus();
        }

        private void dgvconsultaA_DoubleClick(object sender, EventArgs e)
        {
            int fila = dgvconsultaA.CurrentRow.Index;
            if (string.IsNullOrEmpty(dgvconsultaA.Rows[fila].Cells[0].Value.ToString()) != true)
            {

                txtcodasig.Text = dgvconsultaA.Rows[fila].Cells[0].Value.ToString();
                txtclave.Text = dgvconsultaA.Rows[fila].Cells[1].Value.ToString();
                txtnombre.Text = dgvconsultaA.Rows[fila].Cells[2].Value.ToString();
                txthorast.Text = dgvconsultaA.Rows[fila].Cells[3].Value.ToString();
                txthorasp.Text = dgvconsultaA.Rows[fila].Cells[4].Value.ToString();
                txtcreditos.Text = dgvconsultaA.Rows[fila].Cells[5].Value.ToString();
                txtpre.Text = dgvconsultaA.Rows[fila].Cells[6].Value.ToString();
                cmbestatus.Text = dgvconsultaA.Rows[fila].Cells[7].Value.ToString();
                tabControl1.SelectTab(tp2);
            }
        else
            {
                MessageBox.Show("Por favor verificar si la fila donde esta pulsando doble click contiene datos");
            }
}

        private void fmrasignaturas_Load(object sender, EventArgs e)
        {

        }

        private void txtpre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tp1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fmrasignaturas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
