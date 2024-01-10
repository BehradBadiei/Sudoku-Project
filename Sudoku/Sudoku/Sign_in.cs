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

namespace Sudoku
{
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();
        }
        Main main=new Main();

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            string pass_con = textBox3.Text;    
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\bshz2\OneDrive\Desktop\Advanced Programming\practice\Sudoku\Sudoku\Users.mdf"";Integrated Security=True");
            sc.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Admin(UserName,Password) Values(@user,@pass)", sc);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            if (pass != pass_con)
            {
                MessageBox.Show($"your passwords dont match!");
            }
            else if (user == "" || pass == "" || pass_con == "")
            {
                MessageBox.Show("something went wrong! please try again");
            } 
            else
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account successfuly created!");
                main.Show();
                this.Hide();
                
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            sc.Close();
            
        }
    }
}
