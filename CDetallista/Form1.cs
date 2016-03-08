using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace CDetallista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "Archivo txt (*.txt)|*.txt";
            //openFileDialog1.FilterIndex = 2;
            //openFileDialog1.RestoreDirectory = true;
            //string rutaTxt = "";
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    rutaTxt = openFileDialog1.FileName;
            //    archivo.Load(rutaTxt);
            //    label2.Text = openFileDialog1.FileName;
            //}
            //Directory.CreateDirectory("C:\\FacInte");
            openFileDialog1.ShowDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Archivo txt (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            label2.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private string GetNameFile()
        {
            DateTime fecha = DateTime.Now;
            int ano = fecha.Year;
            int mes = fecha.Month;
            int dia = fecha.Day;
            int hr = fecha.Hour;
            int min = fecha.Minute;
            int seg = fecha.Second;

            string namefile = ano.ToString() + "_" + mes.ToString() + "_" + dia.ToString() + "_" + hr + "_" + min;

            return namefile;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
