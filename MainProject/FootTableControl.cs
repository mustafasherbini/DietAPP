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
    public partial class FootTableControl : Form
    {
        public FootTableControl()
        {
            InitializeComponent();
            dataGridView1.DataSource = loadUsetTable();
        }
        static string sql = "Data Source=SHERBINY\\MSSQLSERVER01;Initial Catalog=nut;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);

        public DataTable loadUsetTable()
        { // connect the data gride view to the data base 
            DataTable Dt = new DataTable();
            string query = "SELECT * FROM Sheet1$ "; //sql command 
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Dt);
            con.Close();
            return Dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ADD new row
        
            try
            {
               

                sheet1_TableAdapter1.InsertQuery(foodTextBox.Text, float.Parse(amountTextBox.Text), float.Parse(calories_TextBox.Text), float.Parse(protein_TextBox.Text), float.Parse(carbsTextBox.Text), float.Parse(fatsTextBox.Text), float.Parse(fiberTextBox.Text));
                MessageBox.Show("DONE");
                dataGridView1.DataSource = loadUsetTable();
            }
            catch
            {
                MessageBox.Show("invalid data");
            }

            

        }



        private void Form3_Load(object sender, EventArgs e)
        { // nothing 
            loadUsetTable();
        }







        private void button3_Click(object sender, EventArgs e)
        {
// edit rows in table by the name, name constant

            try
            {
                sheet1_TableAdapter1.UpdateQuery(double.Parse(amountTextBox.Text), double.Parse(calories_TextBox.Text), double.Parse(protein_TextBox.Text), double.Parse(carbsTextBox.Text), double.Parse(fatsTextBox.Text), double.Parse(fiberTextBox.Text), foodTextBox.Text);

                MessageBox.Show("DONE");

                dataGridView1.DataSource = loadUsetTable();

            }
            catch (Exception)
            {
                MessageBox.Show("invalid data");
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {      //delete from the table
            sheet1_TableAdapter1.DeleteQuery(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            dataGridView1.DataSource = loadUsetTable();
            MessageBox.Show("DONE");
        }

        private void button2_Click(object sender, EventArgs e)
        { // back
            this.Hide();
             MianForm m = new MianForm() ;
            m.ShowDialog();
        }






        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //no
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // connect data grid view to the text boxes
            foodTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            amountTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            calories_TextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            protein_TextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            carbsTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fatsTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fiberTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}