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
    }
}
