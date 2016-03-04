using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if ((openFileDialog1.ShowDialog() == DialogResult.OK) && (openFileDialog1.FileName.Length > 0))
                txtfile.Text = openFileDialog1.FileName;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string txtuser = "PERI8710304I7";
            string txtpasword = "123456";
            string xuser = txtuser.Text.Trim(), xpas = txtpasword.Text.Trim(), xcad = "", xerror = "";
            //string xuser = "XAXX010101000", xpas = "YPfz&vCC#", xcad = "", xerror = "";
            string namefile = GetNameFile();
            string fileqr = @"C:\FACINTE\qr_" + namefile + ".png";
            string filepdf = @"C:\FACINTE\Pdf_" + namefile + ".pdf";
            string filexml = @"C:\FACINTE\Xml_" + namefile + ".xml";
            byte[] xpdf = null, xqr = null, xmlx = null;
            //bool prodcutivo = checprod.Checked;


            var cadena = new StreamReader(txtfile.Text.Trim(), System.Text.Encoding.Default);
            xcad = cadena.ReadToEnd();
            cadena.Close();
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
    }
}
