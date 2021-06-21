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
    public partial class Client_Details : Form
    {
        public Client_Details()
        {
            InitializeComponent();
        }

        

        private void Client_Details_Load(object sender, EventArgs e)
        {    ///// by defult 
            // TODO: This line of code loads data into the 'nutDataSet1.clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.nutDataSet1.clients);

        }

        private void button4_Click(object sender, EventArgs e)
        { // delete from the DB
            try
            {
                clientsTableAdapter.DeleteQuery(int.Parse(iDTextBox.Text));
                MessageBox.Show("DONE");
            } catch
            {
                MessageBox.Show("invalid input");
            }
         
        }

       

        private void button2_Click(object sender, EventArgs e)
        {// Back
            this.Hide();
            MianForm f = new MianForm();
            f.ShowDialog();
        }
    }
}
