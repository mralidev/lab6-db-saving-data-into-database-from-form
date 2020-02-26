using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namebx = namebox.Text;
            string cnicbx = cnicbox.Text;
            string emailbx = emailbox.Text;
            string contactbx = contactbox.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V2A6ALP\\SQLEXPRESS;Initial Catalog=lab6;Integrated Security=True"); //path from app config
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into crudApp values(@a, @b, @c, @d)", con);
            cmd.Parameters.AddWithValue("@a", namebx);
            cmd.Parameters.AddWithValue("@b", cnicbx);
            cmd.Parameters.AddWithValue("@c", emailbx);
            cmd.Parameters.AddWithValue("@d", contactbx);

            cmd.ExecuteNonQuery();
            MessageBox.Show("recorde has been submitted");
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
