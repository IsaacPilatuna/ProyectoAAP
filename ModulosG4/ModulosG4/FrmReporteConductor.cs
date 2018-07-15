using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModulosG4
{
    public partial class Form2 : Form
    {
        private EscribirArchivo esc_Archivo;
        private ReporteConductor reporteConductor;

        public Form2()
        {
            InitializeComponent();
            esc_Archivo = new EscribirArchivo();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void obtenerDatos() {
            bool inconveniente = false;
            if (rb1_inconveniente.Checked) {
              
                inconveniente = true;
            }
            Console.WriteLine(true);
            String comportamiento = "";
            if (rb1_comportamiento.Checked)
            {
                comportamiento = "0";
            }
            else if (rb2_comportamiento.Checked)
            {
                comportamiento = "25";
            }
            else if (rb3_comportamiento.Checked)
            {
                comportamiento = "50";
            }
            else if (rb4_comportamiento.Checked)
            {
                comportamiento = "75";
            }
            else {
                comportamiento = "100";
            }

            Console.WriteLine(comportamiento);

            reporteConductor = new ReporteConductor(txt_ci.Text, txt_nombreCompleto.Text,txt_descripcion.Text, inconveniente,txt_dinComb.Text, comportamiento);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            obtenerDatos();
            esc_Archivo.escribirConductor(reporteConductor);
        }

        private void rb5_comportamiento_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
