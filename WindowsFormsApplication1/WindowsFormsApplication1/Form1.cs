using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            int n;
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();
            n = c1.random();
            label1.Text = n.ToString();
            for(int i=2 ;i<n ; i++)
            {
                if (c2.hihi(i) == true)
                    comboBox1.Items.Add(i);
            }
        }
    }
}
