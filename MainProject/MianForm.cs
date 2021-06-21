using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    public partial class MianForm : Form
    {
        public MianForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {    // 
            Calc c = new Calc();
            this.Hide();
            c.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Client_Details c = new Client_Details();
            this.Hide();
            c.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FootTableControl f = new FootTableControl();
            this .Hide();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
