using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MainProject
{
    public partial class Calc : Form
    {    // data types 
        int ag,selctedactive;
        double wh, hi, nk, wst, hp;
        string nm;

        private void button3_Click(object sender, EventArgs e)
        { // back 
            this.Hide();
            MianForm f = new MianForm();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        { //open diet plan form
            this.Hide();
           DietPlan f = new DietPlan();
            f.ShowDialog();
        }

        public Calc()
        {// defult code
            InitializeComponent();
        }

      

        private void Form2_Load(object sender, EventArgs e)
        {// no
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        { // hip show when it is female 
            if (radioButton2.Checked == true)
            {
                textBox7.Show();
                label8.Show();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {// hip hide when it is male 
            if (radioButton1.Checked == true)
            {
                textBox7.Hide();
                label8.Hide();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                wh = double.Parse(textBox4.Text);
                ag = int.Parse(textBox2.Text);
                hi = double.Parse(textBox3.Text);
                nk = double.Parse(textBox5.Text);
                wst = double.Parse(textBox6.Text);
                nm = textBox1.Text;
                 //get data from text box
                if (radioButton2.Checked == true) //check if female
                {
                    hp = double.Parse(textBox7.Text);
                }
                selctedactive = comboBox1.SelectedIndex; //select index
            }
            catch
            {
                MessageBox.Show("invalid input");
            }

            if (radioButton2.Checked == true) //if female
            {
                 female onee = new female(nm, ag, hi, wh, wst, nk, hp);
                textBox8.Text = onee.calories(selctedactive+1).ToString();
                textBox10.Text = onee.Fatpecntge().ToString();
                clientsTableAdapter1.InsertQuery(nm, ag, false, wh, hi, nk, hp, onee.calories(selctedactive + 1), onee.Fatpecntge());
            }
            else
            {
                male onee = new male(nm, ag, hi, wh, wst, nk);
                textBox8.Text = onee.calories(selctedactive+1).ToString();
                textBox10.Text = onee.Fatpecntge().ToString()+"%";
                clientsTableAdapter1.InsertQuery(nm, ag, true, wh, hi, nk, null, onee.calories(selctedactive + 1), onee.Fatpecntge());
            }
            MessageBox.Show("DONE");

        }
    }
}