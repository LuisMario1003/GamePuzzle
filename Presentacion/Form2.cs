using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var abrirarchivo = new OpenFileDialog();
            abrirarchivo.ShowDialog();
            var sr = new System.IO.StreamReader(abrirarchivo.FileName);
            richTextBox1.Text = sr.ReadToEnd();
        }
    }
}
