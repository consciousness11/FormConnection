using FormConnection.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student st = new Student();

        private void button1_Click(object sender, EventArgs e)
        {
            st.roll = Convert.ToInt32(textBox1.Text);
            st.name = textBox2.Text;
            st.marks = Convert.ToInt32(textBox3.Text);

            bool success = st.add(st);
            if (success)
            {
                MessageBox.Show("Inserted in database");
            }
            else
            {
                MessageBox.Show("Insertion Failure in database");
            }
            DataTable dt = st.read();
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = st.read();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowID = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[rowID].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[rowID].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[rowID].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if( int.Parse(textBox1.Text).
            st.roll = int.Parse(textBox1.Text);
            st.name = textBox2.Text;
            st.marks = int.Parse(textBox3.Text);

            bool success = st.Update(st);

            if (success) {
                MessageBox.Show("Updated Successfully");
                DataTable dt = st.read();
                dataGridView1.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Failed to Update");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            st.roll = Convert.ToInt32(textBox1.Text);
            bool success = st.Delete(st);

            if (success)
            {
                MessageBox.Show("Deleted Successfully");
                DataTable dt = st.read();
                dataGridView1.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Failed to Delete");
            }
        }
    }
}
