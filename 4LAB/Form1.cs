using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _4LAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            double y;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            y = a * b - 3 * c;
            DialogResult result = MessageBox.Show("Y=" + Convert.ToString(y), "Результат:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes) textBox1.BackColor = Color.Green;
            if (result == DialogResult.No) label2.BackColor = Color.Red;
            if (result == DialogResult.Cancel) button1.BackColor = Color.Yellow;
        }
    }
}