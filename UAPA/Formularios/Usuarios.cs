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

namespace UAPA
{
    public partial class Usuarios : Form
    {
        //conección con SQL SERVER
        SqlConnection conexionsql = new SqlConnection(@"Data Source=DESKTOP-EVQDN0O;Initial Catalog=UAPA;Integrated Security=True");

        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnconsultaA_Click(object sender, EventArgs e)
        {

        }

        private void dgvconsultaA_DoubleClick(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void btniniciousu_Click(object sender, EventArgs e)
        {
            Form formulario = new fmrmenu();
            formulario.Show();
            this.Hide();
        }

        private void btnnuevousu_Click(object sender, EventArgs e)
        {
            CLASE_LIMPIAR limpia = new CLASE_LIMPIAR();
            limpia.limpiar_campos(this, tp2usu);
            txtcodusu.Text = "0";
            tabctrusu.SelectTab(tp2usu);
            txtcodusu.Focus();
        }

        private void btnconsultausu_Click(object sender, EventArgs e)
        {
            string consulta = txtconsultausu.Text;

            if (txtconsultausu.Text == "")
            {
                string sentencia = "select id_usu as Código,nombre_usu as Usuarios,clave_usu as Clave,nombre_completo as Nombre, estatususu as Estado from REGISTRO_USUARIOS ";
                SqlCommand comando = new SqlCommand(sentencia, conexionsql);
                SqlDataAdapter dt = new SqlDataAdapter(comando);
                DataTable tablaUSU = new DataTable();
                dt.Fill(tablaUSU);
                dgvconsultausu.DataSource = tablaUSU;
            }
            else
            {
                string sentencia = "select * from REGISTRO_USUARIOS  where id_usu = '" + consulta + "'";
                SqlCommand comando = new SqlCommand(sentencia, conexionsql);
                SqlDataAdapter dt = new SqlDataAdapter(comando);
                DataTable tablaUSU = new DataTable();
                dt.Fill(tablaUSU);
                dgvconsultausu.DataSource = tablaUSU;
            }
            CLASE_LIMPIAR limpia = new CLASE_LIMPIAR();
            limpia.limpiar_campos(this, tp1usu);
        }

        private void btnregistrarusu_Click(object sender, EventArgs e)
        {
            //validacion combobox texbox
            if (string.IsNullOrWhiteSpace(txtnombreusu.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtnombreusu.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtclaveusu.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtclaveusu.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtnombreusu.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtnombreusu.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbestatususu.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                cmbestatususu.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtcodusu.Text) == true)
            {
                string codigo = "0";

                clase_tipo_datosusu tipos = new clase_tipo_datosusu();
                tipos.id_usu = int.Parse(codigo);
                tipos.nombre_usu = txtnombreusu.Text;
                tipos.clave_usu = txtclaveusu.Text;
                tipos.nombre_completo = txtnombreusu.Text;
                tipos.estatususu = cmbestatususu.Text;


                clase_metodos datos = new clase_metodos();
                datos.registrarusuarios(tipos);
                MessageBox.Show("Usuario registrado correctamente");
            }
            else
            {
                clase_tipo_datosusu tipos = new clase_tipo_datosusu();
                tipos.id_usu = int.Parse(txtcodusu.Text);
                tipos.nombre_usu = txtnombreusu.Text;
                tipos.clave_usu = txtclaveusu.Text;
                tipos.nombre_completo = txtnombreusu.Text;
                tipos.estatususu = cmbestatususu.Text;



                clase_metodos datos = new clase_metodos();
                datos.registrarusuarios(tipos);
                MessageBox.Show("Usuario actualizado correctamente");

            }



            CLASE_LIMPIAR limpia = new CLASE_LIMPIAR();
            limpia.limpiar_campos(this, tp2usu);
            tabctrusu.SelectTab(tp2usu);
            txtcodusu.Focus();
        }

        private void dgvconsultausu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvconsultausu.CurrentRow.Index;
            if (string.IsNullOrEmpty(dgvconsultausu.Rows[fila].Cells[0].Value.ToString()) != true)
            {
                txtcodusu.Text = dgvconsultausu.Rows[fila].Cells[0].Value.ToString();
                txtusu.Text = dgvconsultausu.Rows[fila].Cells[1].Value.ToString();
                txtclaveusu.Text = dgvconsultausu.Rows[fila].Cells[2].Value.ToString(); 
                txtnombreusu.Text = dgvconsultausu.Rows[fila].Cells[3].Value.ToString();
                cmbestatususu.Text = dgvconsultausu.Rows[fila].Cells[4].Value.ToString();
                tabctrusu.SelectTab(tp2usu);
            }
            else
            {
                MessageBox.Show("Por favor verificar si la fila donde esta pulsando doble click contiene datos");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
