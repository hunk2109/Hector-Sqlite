using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class frn_empleaado : Form
    {
        public frn_empleaado()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            oper.consultasinreaultado("insert into empleado(nombre,apellido,cedula,sexo,fecha_naci,fecha_ingr) values('"+ txtnom.Text +"','"+ textape.Text +"','"+txtcedula.Text+"','"+texsex.Text+"','"+txtnacimiento.Text+"','"+txtingreso.Text+"')");

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            texid.Text = ("");
            txtnom.Text = ("");
            textape.Text = ("");
            texsex.Text = ("");
            txtcedula.Text = ("");
          txtnacimiento.Text = ("");
            txtingreso.Text = ("");

        }
    }
}
