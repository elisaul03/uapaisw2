using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAPA
{
    public class CLASE_LIMPIAR
    {

        public void limpiar_campos(Control c, TabPage t)//TabControl t
        {
            //limpiar texbox
            foreach (var texto in c.Controls)
            {
                if (texto is TextBox)
                {
                    ((TextBox)texto).Clear();
                }
                else if (texto is ComboBox)
                {
                    ((ComboBox)texto).Text = "";
                }

            }
            ////limpiar combobox
            foreach (var tbcon in t.Controls)
            {
                if (tbcon is TextBox)
                {
                    ((TextBox)tbcon).Clear();
                }
                else if (tbcon is ComboBox)
                {
                    ((ComboBox)tbcon).Text = "";
                }

            }



        }



        }
    }
