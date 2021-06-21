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
using System.IO;

namespace MainProject
{
   
    public partial class DietPlan : Form
    {

        double protine, fats, carbs, fiber, calories,amount;
        double tprotine=0, tfats=0, tcarbs=0, tfiber=0, tcalorries=0;



        private void button4_Click(object sender, EventArgs e)
        { // print into file

            using (var tw = new StreamWriter("diet.txt"))
            {
                tw.WriteLine("FOOD" + "        "+"Amount");
                foreach (ListViewItem item in listView1.Items)
                {
                    tw.Write(item.Text+"        "); // print name
                    tw.WriteLine(item.SubItems[1].Text+"Gram");//print  amount

                }
                //total nutrition
                tw.WriteLine("Calories: " + tcalorries + "        Protine:"+tprotine+"\nFats:"+tfats+ "        Catbs:"+tcarbs+"\nFiber:"+tfiber);
            }
           

            MessageBox.Show("Saved in Diet.txt ");
            this.Hide();
            MianForm n = new MianForm();
            n.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {// back new clint form
            this.Hide();
            Calc f = new Calc();
            f.ShowDialog();
        }

        

        public DietPlan()
        { // defult
            InitializeComponent();
            fillcomb();
        }

        void fillcomb()
        { // reading all name cloulmn from DB and put it into the combbox
             string sql = "Data Source=SHERBINY\\MSSQLSERVER01;Initial Catalog=nut;Integrated Security=True";
            string queryy = "SELECT * FROM Sheet1$ "; //sql command 

            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(queryy, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {


                    string sname = myreader.GetString(0);
                    comboBox1.Items.Add(sname); // add into combo box
                    
                }
            }
            catch
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { // get valus from tha DB by name 
            string selected = comboBox1.Text;

            try
            {
                amount = float.Parse(textBox1.Text);  

                protine = amount * (double)sheet1_TableAdapter1.SELECTPro(selected) / 100;                

                tprotine += protine;
                // 100            200
                //50 protine       ?         ?=200(amount)*50(protine)/100(amount)
                fats = amount * (double)sheet1_TableAdapter1.selectfats(selected) / 100;
                tfats += fats;
                calories = amount * (double)sheet1_TableAdapter1.SELECTCAL(selected) / 100;
                tcalorries += calories;
                carbs = amount * (double)sheet1_TableAdapter1.SelectCarb(selected) / 100;
                tcarbs += carbs;
                fiber = amount * (double)sheet1_TableAdapter1.selectfab(selected) / 100;
                tfiber += fiber;
            }
            catch
            {
                MessageBox.Show("invlaid input");
            }
            ListViewItem n = new ListViewItem(selected); // row in the list 
            n.SubItems.Add(amount.ToString());
            n.SubItems.Add(calories.ToString());
            n.SubItems.Add(protine.ToString());
            n.SubItems.Add(fats.ToString());
            n.SubItems.Add(fiber.ToString());
            n.SubItems.Add(carbs.ToString());

            listView1.Items.Add(n); //add row


            // total text box
            textBox2.Text = tcalorries.ToString();
            textBox3.Text = tprotine.ToString();
            textBox4.Text = tfats.ToString();
            textBox5.Text = tcarbs.ToString();
            textBox6.Text = tfiber.ToString();




        }

        private void DietPlan_Load(object sender, EventArgs e)
        {
            //nothing
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                string str = listView1.SelectedItems[0].Text;
                
                // edit total variabls
                tcalorries -=  double.Parse( listView1.SelectedItems[0].SubItems[2].Text);
                    tfats -= double.Parse(listView1.SelectedItems[0].SubItems[4].Text);
                    tcarbs -= double.Parse(listView1.SelectedItems[0].SubItems[6].Text);
                    tfiber -= double.Parse(listView1.SelectedItems[0].SubItems[5].Text);
                    tprotine -= double.Parse(listView1.SelectedItems[0].SubItems[3].Text);

                
                

                listView1.Items.Remove(listView1.SelectedItems[0]); //remove row 


                // show new total 
                textBox2.Text = tcalorries.ToString();
                textBox3.Text = tprotine.ToString();
                textBox4.Text = tfats.ToString();
                textBox5.Text = tcarbs.ToString();
                textBox6.Text = tfiber.ToString();
            }
        }
    }
 
  

}

