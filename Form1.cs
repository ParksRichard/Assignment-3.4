using System;
using System.Data;
using System.Reflection;

namespace Assignment_3._4
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("table");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //table.Columns.Add("Student ID", typeof(int));
            //table.Columns.Add("First Name", typeof(string));
            //table.Columns.Add("Last Name", typeof(string));
            //table.Columns.Add("Address", typeof(string));
            //table.Columns.Add("Grade", typeof(char));
            //dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //index = e.RowIndex;
            //DataGridViewRow row = dataGridView1.Rows[index];
            //textBox1.Text = row.Cells[0].Value.ToString();
            //textBox2.Text = row.Cells[1].Value.ToString();
            //textBox3.Text = row.Cells[2].Value.ToString();
            //textBox4.Text = row.Cells[3].Value.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //index = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.Rows.RemoveAt(index);

        }
    }
}
