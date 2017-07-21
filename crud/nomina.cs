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
    public partial class nomina : Form
    {
        public nomina()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomina_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            
           
            
            

           
            
                
            
        }

        private void btnguarnomina_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            oper.consultasinreaultado("insert into detalle_nomina(i_s_r,deduccion_ss,otros,total_deduc,sueldo_neto,fecha,Empleado_empleado_id) values('" + txtisr.Text + "','" + txtdeducionss.Text + "','" + txtotros.Text + "','" + txtdeducciontt.Text + "','" + txtsueldoneto.Text + "','" + txtfechanomina.Text+ "','"+ txtidempleadonomina.Text + "')");
        }

        private void txtdeducionss_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtisr.Text = ("");
            txtfechanomina.Text = ("");
            txtdeducionss.Text = ("");
            txtdeducciontt.Text = ("");
            txtotros.Text = ("");
            txtsueldoneto.Text = ("");
            txtidempleadonomina.Text = ("");
            txtdetallesid.Text = ("");
               
        }
    }
}
