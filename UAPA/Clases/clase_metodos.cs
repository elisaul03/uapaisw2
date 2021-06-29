using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace UAPA
{
    public class clase_metodos
    {
        //conección con SQL SERVER
        SqlConnection conexionsql = new SqlConnection(@"Data Source=DESKTOP-25FO5IC\SQLEXPRESS;Initial Catalog=uapa;Integrated Security=True");


        public bool entrar(string usuario, string contrasena) //metodo para boton entrar del login 
        {
//Declaracion de variable tipo string llamada strsql y asig nacion de sentencia SQL para seleccionar la tabla registro usuario y validar los campo usuario y clave
            string strsql = "select * from REGISTRO_USUARIOS where nombre_usu = '" + usuario + "' and clave_usu = '" + contrasena + "' ";
            DataTable dt = new DataTable();//creacion tabla temporal nombre dt
            SqlDataAdapter da = new SqlDataAdapter(strsql, conexionsql); //declarar variable da he instanciarla con  metodo SqlDataAdapter
            da.Fill(dt); //llamar la variable da con el metodo FILL con la bariable dt de tabla temporal como parametro para llenar la tabla temporal
            if (dt.Rows.Count > 0) //Condicion si en las filas de la variable dt recibe un valor mayor que cero contado por el count devueveme true
            {
                ClaUsuarios.nombre_completo = dt.Rows[0]["nombre_completo"].ToString();
                return true;
            }
            else // encaso contrario devuelve false 
            {

                return false;
            }
        }

        public void registrarfacilitadores(clase_tipo_datosfc tipos)
        {
            string strsql = "SP_registrar_facilitadores";
            SqlCommand cmd = new SqlCommand(strsql, conexionsql);
            conexionsql.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cod_fac", tipos.cod_fac);
            cmd.Parameters.AddWithValue("@nom_fac", tipos.nom_fac);
            cmd.Parameters.AddWithValue("@apellido_fac", tipos.apellido_fac);
            cmd.Parameters.AddWithValue("@tp_docu_iden_fac", tipos.tp_docu_iden_fac);
            cmd.Parameters.AddWithValue("@iden_fac", tipos.iden_fac);
            cmd.Parameters.AddWithValue("@telefono_fac", tipos.telefono_fac);
            cmd.Parameters.AddWithValue("@direccion_fac", tipos.direccion_fac);
            cmd.Parameters.AddWithValue("@ciudad_fac", tipos.ciudad_fac);
            cmd.Parameters.AddWithValue("@pais_fac", tipos.pais_fac);
            cmd.Parameters.AddWithValue("@sexo_fac", tipos.sexo_fac);
            cmd.Parameters.AddWithValue("@estudios_alcanzado", tipos.estudios_alcanzado);
            cmd.Parameters.AddWithValue("@fc_naci_fac", tipos.fc_naci_fac);
            cmd.Parameters.AddWithValue("@fc_ingre_fac", tipos.fc_ingre_fac);
            cmd.Parameters.AddWithValue("@edad_fac", tipos.edad_fac);
            cmd.Parameters.AddWithValue("@status_fac", tipos.estatus_fac);

            cmd.ExecuteNonQuery();
            conexionsql.Close();

        }

        public void registrarparticipante(clase_tipo_datospa tipos)
        {
            string strsql = "SP_registrar_participantes";
            SqlCommand cmd = new SqlCommand(strsql, conexionsql);
            conexionsql.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_par", tipos.id_par);
            cmd.Parameters.AddWithValue("@matri_par", tipos.matri_par);
            cmd.Parameters.AddWithValue("@nom_par", tipos.nom_par);
            cmd.Parameters.AddWithValue("@apellido_par", tipos.apellido_par);
            cmd.Parameters.AddWithValue("@tp_docu_iden_par", tipos.tp_docu_iden_par);
            cmd.Parameters.AddWithValue("@iden_par", tipos.iden_par);
            cmd.Parameters.AddWithValue("@telefono_par", tipos.telefono_par);
            cmd.Parameters.AddWithValue("@direccion_par", tipos.direccion_par);
            cmd.Parameters.AddWithValue("@ciudad_par", tipos.ciudad_par);
            cmd.Parameters.AddWithValue("@pais_par", tipos.pais_par);
            cmd.Parameters.AddWithValue("@sexo_par", tipos.sexo_par);
            cmd.Parameters.AddWithValue("@carrera", tipos.carrera);
            cmd.Parameters.AddWithValue("@fc_nac_par", tipos.fc_nac_par);
            cmd.Parameters.AddWithValue("@fc_ingre_par", tipos.fc_ingre_par);
            cmd.Parameters.AddWithValue("@fc_termi_par", tipos.fc_termi_par);
            cmd.Parameters.AddWithValue("@status_par", tipos.status_par);

            cmd.ExecuteNonQuery();
            conexionsql.Close();

        }

        public void registrarasignaturas(clase_tipo_datosas tipos)
        {
            string strsql = "SP_registra_asignaturas";
            SqlCommand cmd = new SqlCommand(strsql, conexionsql);
            conexionsql.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cod_asig", tipos.cod_asig);
            cmd.Parameters.AddWithValue("@clave_asig", tipos.clave_asig);
            cmd.Parameters.AddWithValue("@nom_asig", tipos.nom_asig);
            cmd.Parameters.AddWithValue("@ht_asig", tipos.ht_asig);
            cmd.Parameters.AddWithValue("@hp_asig", tipos.hp_asig);
            cmd.Parameters.AddWithValue("@cr_asig", tipos.cr_asig);
            cmd.Parameters.AddWithValue("@pre_req_asig", tipos.pre_req_asig);
            cmd.Parameters.AddWithValue("@status_asig", tipos.status_asig);

            cmd.ExecuteNonQuery();
            conexionsql.Close();
            //registrarasignatura

        }
        public void registrarusuarios (clase_tipo_datosusu tipos)
        {
            string strsql = "SP_registrar_usuarios";
            SqlCommand cmd = new SqlCommand(strsql, conexionsql);
            conexionsql.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_usu", tipos.id_usu);
            cmd.Parameters.AddWithValue("@nombre_usu", tipos.nombre_usu);
            cmd.Parameters.AddWithValue("@clave_usu", tipos.clave_usu);
            cmd.Parameters.AddWithValue("@nombre_completo", tipos.nombre_completo);
            cmd.Parameters.AddWithValue("@estatususu", tipos.estatususu);

            cmd.ExecuteNonQuery();
            conexionsql.Close();

        }

    }
}
