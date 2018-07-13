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
    public partial class Form1 : Form
    {
        Controlador con;
        String cedula,nombreSolicitante,destino,conducto,motivo;
        DateTime tiempoSalida,timepoEntrada;
        //Destino 
        public Form1()
        {
            con = new Controlador();
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            cedula = tcedula.Text;
            nombreSolicitante = tnombreSolicitante.Text;
            destino = "" + comboBox1.SelectedItem;
            conducto = "" + comboBox2.SelectedItem;
            motivo = richTextBox1.Text;
            con.guardarInfo(cedula,nombreSolicitante,destino,conducto,tiempoSalida,tiempoRetorno,motivoViaje);
        }
    }
}
