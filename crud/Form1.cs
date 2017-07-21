﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (cmbtablas.Text == ("Empleado"))
            {
                frn_empleaado f = new frn_empleaado();
                f.Show();
            }

            else if (cmbtablas.Text == ("Cargo"))
            {
                frn_cargo f = new frn_cargo();
                f.Show();
            }
            else if (cmbtablas.Text == ("Detalles Nomina"))
            {
                nomina f = new nomina();
                f.Show();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (cmbtablas.Text == ("Empleado"))
            {
                operaciones oper = new operaciones();
                dgvdatos.DataSource = oper.cosnsultaconresultado("select "+txtcondiocional.Text+"  from  empleado where nombre = '" + txtbuscar.Text + "'");
            }

            else if (cmbtablas.Text == ("Cargo"))
            {
                operaciones oper = new operaciones();
                dgvdatos.DataSource = oper.cosnsultaconresultado("select " + txtbuscar.Text + "  from  cargo " +txtcondiocional.Text + "");

            }

            else if (cmbtablas.Text == ("Detalles Nomina"))
            {
                operaciones oper = new operaciones();
                dgvdatos.DataSource = oper.cosnsultaconresultado("select " + txtbuscar.Text+  "from  detalle_nomina " + txtcondiocional.Text + "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            string resultado = oper.conectar();
            MessageBox.Show(resultado);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbtablas.Text == "Empleado")
            {
                operaciones oper = new operaciones();
                dgvdatos.DataSource = oper.cosnsultaconresultado("select * from  empleado ");
            }

            else if(cmbtablas.Text == "Cargo")
            {
                operaciones oper = new operaciones();
                dgvdatos.DataSource = oper.cosnsultaconresultado("select * from  cargo ");

            }

            else if(cmbtablas.Text == "Detalles Nomina")
            {
                operaciones oper = new operaciones();
                dgvdatos.DataSource = oper.cosnsultaconresultado("select * from  detalle_nomina ");
            }

        }
    }
}
