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
    public partial class fmrparticipante : Form
    {
        //conección con SQL SERVER
        SqlConnection conexionsql = new SqlConnection(@"Data Source=DESKTOP-EVQDN0O;Initial Catalog=UAPA;Integrated Security=True");

        public fmrparticipante()
        {
            InitializeComponent();
        }

        private void textBox8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new fmrmenu();
            formulario.Show();
            this.Hide();
        }

        private void btnnuevorgP_Click(object sender, EventArgs e)
        {
            CLASE_LIMPIAR limpia = new CLASE_LIMPIAR();
            limpia.limpiar_campos(this, tp2);
            txtcodpar.Text = "0";
            tabControl1.SelectTab(tp2);
            txtcodpar.Focus();
        }

        private void btnconsultaP_Click(object sender, EventArgs e)
        {
            string consulta = txtconsultaP.Text;

            if (txtconsultaP.Text == "")
            {
                string sentencia = "select id_par as Código,carrera as Carrera,matri_par as Matricula,nom_par as Nombre, apellido_par as Apellido, tp_docu_iden_par as Tipo_DCM, iden_par as Identificacion,telefono_par as Telefono,direccion_par as Direccion, ciudad_par as Ciudad, pais_par as Pais,fc_nac_par as Fecha_NC, fc_ingre_par as Fecha_ING, fc_termi_par as Fecha_TRM, sexo_par as Sexo, status_par as Estatus from PARTICIPANTES ";
                SqlCommand comando = new SqlCommand(sentencia, conexionsql);
                SqlDataAdapter dt = new SqlDataAdapter(comando);
                DataTable tablaPAR = new DataTable();
                dt.Fill(tablaPAR);
                dgvconsultaP.DataSource = tablaPAR;
            }
            else
            {
                string sentencia = "select * from PARTICIPANTES  where id_par = '" + consulta + "'";
                SqlCommand comando = new SqlCommand(sentencia, conexionsql);
                SqlDataAdapter dt = new SqlDataAdapter(comando);
                DataTable tablaPAR = new DataTable();
                dt.Fill(tablaPAR);
                dgvconsultaP.DataSource = tablaPAR;
            }
            CLASE_LIMPIAR limpia = new CLASE_LIMPIAR();
            limpia.limpiar_campos(this, tp1);

        }

        private void btnregistrarP_Click(object sender, EventArgs e)
        {

            //validacion combobox texbox
            if (string.IsNullOrWhiteSpace(txtcarrera.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtcarrera.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtmatricula.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtmatricula.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtnombre.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtnombre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtapellido.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtapellido.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txttelefono.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txttelefono.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtdireccion.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtdireccion.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtciudad.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                  txtciudad.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtpais.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtpais.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbsexo.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                cmbsexo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtidentificacion.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtidentificacion.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtfechnac.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtfechnac.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtfechai.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtfechai.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbestatus.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                cmbestatus.Focus();
                return;
            }
            



            if (string.IsNullOrWhiteSpace(txtcodpar.Text) == true)
            {
                string codigo = "0";

                clase_tipo_datospa tipos = new clase_tipo_datospa();
                tipos.id_par = int.Parse(codigo);
                tipos.carrera = txtcarrera.Text;
                tipos.matri_par = txtmatricula.Text;
                tipos.nom_par = txtnombre.Text;
                tipos.apellido_par = txtapellido.Text;
                tipos.tp_docu_iden_par = cmbtipo.Text;
                tipos.iden_par = txtidentificacion.Text;
                tipos.telefono_par = txttelefono.Text;
                tipos.direccion_par = txtdireccion.Text;
                tipos.ciudad_par = txtciudad.Text;
                tipos.pais_par = txtpais.Text;
                tipos.sexo_par = cmbsexo.Text;
                tipos.fc_nac_par = txtfechnac.Text;
                tipos.fc_ingre_par = txtfechai.Text;
                tipos.fc_termi_par = txtfechat.Text;
                tipos.status_par = cmbestatus.Text;


                clase_metodos datos = new clase_metodos();
                datos.registrarparticipante(tipos);
                MessageBox.Show("Participante registrado correctamente");
            }
            else
            {
                clase_tipo_datospa tipos = new clase_tipo_datospa();
                tipos.id_par = int.Parse(txtcodpar.Text);
                tipos.carrera = txtcarrera.Text;
                tipos.matri_par = txtmatricula.Text;
                tipos.nom_par = txtnombre.Text;
                tipos.apellido_par = txtapellido.Text;
                tipos.tp_docu_iden_par = cmbtipo.Text;
                tipos.iden_par = txtidentificacion.Text;
                tipos.telefono_par = txttelefono.Text;
                tipos.direccion_par = txtdireccion.Text;
                tipos.ciudad_par = txtciudad.Text;
                tipos.pais_par = txtpais.Text;
                tipos.sexo_par = cmbsexo.Text;
                tipos.fc_nac_par = txtfechnac.Text;
                tipos.fc_ingre_par = txtfechai.Text;
                tipos.fc_termi_par = txtfechat.Text;
                tipos.status_par = cmbestatus.Text;


                clase_metodos datos = new clase_metodos();
                datos.registrarparticipante(tipos);
                MessageBox.Show("Participante actualizado correctamente");

            }



            CLASE_LIMPIAR limpia = new CLASE_LIMPIAR();
            limpia.limpiar_campos(this,tp2);
            tabControl1.SelectTab(tp2);
            txtcodpar.Focus();
        }

        private void dgvconsultaP_DoubleClick(object sender, EventArgs e)
        {

            
        }

        private void dgvconsultaP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvconsultaP.CurrentRow.Index;
            if (string.IsNullOrEmpty(dgvconsultaP.Rows[fila].Cells[0].Value.ToString()) != true)
            {
                txtcodpar.Text = dgvconsultaP.Rows[fila].Cells[0].Value.ToString();
                txtcarrera.Text = dgvconsultaP.Rows[fila].Cells[1].Value.ToString();
                txtmatricula.Text = dgvconsultaP.Rows[fila].Cells[2].Value.ToString();
                txtnombre.Text = dgvconsultaP.Rows[fila].Cells[3].Value.ToString();
                txtapellido.Text = dgvconsultaP.Rows[fila].Cells[4].Value.ToString();
                cmbtipo.Text = dgvconsultaP.Rows[fila].Cells[5].Value.ToString();
                txtidentificacion.Text = dgvconsultaP.Rows[fila].Cells[6].Value.ToString();
                txttelefono.Text = dgvconsultaP.Rows[fila].Cells[7].Value.ToString();
                txtdireccion.Text = dgvconsultaP.Rows[fila].Cells[8].Value.ToString();
                txtciudad.Text = dgvconsultaP.Rows[fila].Cells[9].Value.ToString();
                txtpais.Text = dgvconsultaP.Rows[fila].Cells[10].Value.ToString();
                txtfechnac.Text = dgvconsultaP.Rows[fila].Cells[11].Value.ToString();
                txtfechai.Text = dgvconsultaP.Rows[fila].Cells[12].Value.ToString();
                txtfechat.Text = dgvconsultaP.Rows[fila].Cells[13].Value.ToString();
                cmbsexo.Text = dgvconsultaP.Rows[fila].Cells[14].Value.ToString();
                cmbestatus.Text = dgvconsultaP.Rows[fila].Cells[15].Value.ToString();
                tabControl1.SelectTab(tp2);
            }
            else
            {
                MessageBox.Show("Por favor verificar si la fila donde esta pulsando doble click contiene datos");
            }
        }

        private void fmrparticipante_Load(object sender, EventArgs e)
        {

        }

        private void txtfechan_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
