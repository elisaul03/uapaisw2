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

    public partial class fmrfacilitador : Form
    {
        //conección con SQL SERVER
        SqlConnection conexionsql = new SqlConnection(@"Data Source=DESKTOP-EVQDN0O;Initial Catalog=UAPA;Integrated Security=True");
        public fmrfacilitador()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Form formulario = new fmrmenu();
                formulario.Show();
                this.Hide();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            //validacion combobox texbox
            if (string.IsNullOrWhiteSpace(txtnom.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtnom.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtape.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtape.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbdoc.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                cmbdoc.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtide.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtide.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txttel.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txttel.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtdir.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtdir.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtciu.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtciu.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtpai.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtpai.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbsex.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                cmbsex.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(rtbestualcan.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                rtbestualcan.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtfcnaci.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtfcnaci.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtfeching.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txtfeching.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txteda.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                txteda.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbsta.Text) == true)
            {
                MessageBox.Show(" Para continuar debe llenar este campo ");
                cmbsta.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(txtcodfac.Text) == true)
            {
                string codigo = "0";
                clase_tipo_datosfc tipos = new clase_tipo_datosfc();
                tipos.cod_fac = int.Parse(codigo);
                tipos.nom_fac = txtnom.Text;
                tipos.apellido_fac = txtape.Text;
                tipos.tp_docu_iden_fac = cmbdoc.Text;
                tipos.iden_fac = txtide.Text;
                tipos.telefono_fac = txttel.Text;
                tipos.direccion_fac = txtdir.Text;
                tipos.ciudad_fac = txtciu.Text;
                tipos.pais_fac = txtpai.Text;
                tipos.sexo_fac = cmbsex.Text;
                tipos.estudios_alcanzado = rtbestualcan.Text;
                tipos.fc_naci_fac = txtfcnaci.Text;
                tipos.fc_ingre_fac = txtfeching.Text;
                tipos.edad_fac = txteda.Text;
                tipos.estatus_fac = cmbsta.Text;


                clase_metodos datos = new clase_metodos();
                datos.registrarfacilitadores(tipos);
                MessageBox.Show("Facilitador registrado correctamente");
            }
            else
            {

                clase_tipo_datosfc tipos = new clase_tipo_datosfc();
                tipos.cod_fac = int.Parse(txtcodfac.Text);
                tipos.nom_fac = txtnom.Text;
                tipos.apellido_fac = txtape.Text;
                tipos.tp_docu_iden_fac = cmbdoc.Text;
                tipos.iden_fac = txtide.Text;
                tipos.telefono_fac = txttel.Text;
                tipos.direccion_fac = txtdir.Text;
                tipos.ciudad_fac = txtciu.Text;
                tipos.pais_fac = txtpai.Text;
                tipos.sexo_fac = cmbsex.Text;
                tipos.estudios_alcanzado = rtbestualcan.Text;
                tipos.fc_naci_fac = txtfcnaci.Text;
                tipos.fc_ingre_fac = txtfeching.Text;
                tipos.edad_fac = txteda.Text;
                tipos.estatus_fac = cmbsta.Text;

                clase_metodos datos = new clase_metodos();
                datos.registrarfacilitadores(tipos);
                MessageBox.Show("Facilitador actualizado correctamente");
            }

                CLASE_LIMPIAR limpia = new CLASE_LIMPIAR();
                limpia.limpiar_campos(this, tp2);
                rtbestualcan.Clear();
                txtcodfac.Focus();
        }



        private void btnnuevorg_Click(object sender, EventArgs e)
        {
            CLASE_LIMPIAR limpia = new CLASE_LIMPIAR();
            limpia.limpiar_campos(this, tp2);
            txtcodfac.Text = "0";
            tabControl1.SelectTab(tp2);
            txtcodfac.Focus();
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            string consulta = txtconsultaf.Text;

            if (txtconsultaf.Text == "")
            {
                string sentencia = "select cod_fac as Código,nom_fac as Nombre,apellido_fac as Apellido, tp_docu_iden_fac as Tipo_Documento, iden_fac as Identificacion, telefono_fac as Teléfono,direccion_fac as Dirección,ciudad_fac as Ciudad, pais_fac as Pais, sexo_fac as Sexo, estudios_alcanzado as Estudios, fc_naci_fac as Fecha_Nacimiento, fc_ingre_fac as Fecha_Ingreso, edad_fac as Edad, status_fac as Estatus from FACILITADORES ";
                SqlCommand comando = new SqlCommand(sentencia, conexionsql);
                SqlDataAdapter dt = new SqlDataAdapter(comando);
                DataTable tablaFAC = new DataTable();
                DataTable tablaFAC1 = tablaFAC;
                int v = dt.Fill(tablaFAC1);
                dgvconsultaf.DataSource = tablaFAC;
            }
            else
            {
                string sentencia = "select * from FACILITADORES  where cod_fac = '" + consulta + "'";
                SqlCommand comando = new SqlCommand(sentencia, conexionsql);
                SqlDataAdapter dt = new SqlDataAdapter(comando);
                DataTable tablaFAC = new DataTable();
                dt.Fill(tablaFAC);
                dgvconsultaf.DataSource = tablaFAC;

            }
                txtconsultaf.Clear();
                txtconsultaf.Focus();
        }

        private void dgvconsultaf_DoubleClick(object sender, EventArgs e)
        {
           int fila = dgvconsultaf.CurrentRow.Index;
            if (string.IsNullOrEmpty(dgvconsultaf.Rows[fila].Cells[0].Value.ToString()) != true)
            {
                txtcodfac.Text = dgvconsultaf.Rows[fila].Cells[0].Value.ToString();
                txtnom.Text = dgvconsultaf.Rows[fila].Cells[1].Value.ToString();
                txtape.Text = dgvconsultaf.Rows[fila].Cells[2].Value.ToString();
                cmbdoc.Text = dgvconsultaf.Rows[fila].Cells[3].Value.ToString();
                txtide.Text = dgvconsultaf.Rows[fila].Cells[4].Value.ToString();
                txttel.Text = dgvconsultaf.Rows[fila].Cells[5].Value.ToString();
                txtdir.Text = dgvconsultaf.Rows[fila].Cells[6].Value.ToString();
                txtciu.Text = dgvconsultaf.Rows[fila].Cells[7].Value.ToString();
                txtpai.Text = dgvconsultaf.Rows[fila].Cells[8].Value.ToString();
                cmbsex.Text = dgvconsultaf.Rows[fila].Cells[9].Value.ToString();
                rtbestualcan.Text = dgvconsultaf.Rows[fila].Cells[10].Value.ToString();
                txtfcnaci.Text = dgvconsultaf.Rows[fila].Cells[11].Value.ToString();
                txtfeching.Text = dgvconsultaf.Rows[fila].Cells[12].Value.ToString();
                txteda.Text = dgvconsultaf.Rows[fila].Cells[13].Value.ToString();
                cmbsta.Text = dgvconsultaf.Rows[fila].Cells[14].Value.ToString();
                tabControl1.SelectTab(tp2);//linea para pasar al tapcomtrol (tp2, pagina 2)
            }
            else
            {
                MessageBox.Show("Por favor verificar si la fila donde esta pulsando doble click contiene datos");
            }





        }

        private void fmrfacilitador_Load(object sender, EventArgs e)
        {

        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tp2_Click(object sender, EventArgs e)
        {

        }

        private void tp1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
