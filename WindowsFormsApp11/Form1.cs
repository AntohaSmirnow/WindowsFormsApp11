using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Файл (*.csv)|*.csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(dlg.FileName, false, Encoding.Unicode))
                {
                    sw.WriteLine( textBox1.Text);
                   
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}













//StreamWriter i = new StreamWriter(@"C:\Users\acer\source\repos\WindowsFormsApp11\1.csv");
            //i.WriteLine(textBox1.Text, '\n');
            //i.Close();

            //using (StreamWriter incdate = File.AppendText(@"C:\Users\acer\source\repos\WindowsFormsApp11\1.csv"))
            //{
            //    incdate.WriteLine(textBox1.Text, '\n');
            //}
