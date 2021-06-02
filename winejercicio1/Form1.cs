using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ci = Convert.ToInt32(textBox1.Text);

            ServiceReference1.WebService1SoapClient ws = new ServiceReference1.WebService1SoapClient();
            dataGridView1.DataSource = ws.materia(ci).Tables[0];
        }
    }
}
