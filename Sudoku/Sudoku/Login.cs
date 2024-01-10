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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            

        }

        Main main = new Main();

        Sign_in sign = new Sign_in();


        private void button1_Click(object sender, EventArgs e)
        {

            
            string user = textBox1.Text;
            string pass = textBox2.Text;
            string Password = "";
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\bshz2\OneDrive\Desktop\Advanced Programming\practice\Sudoku\Sudoku\Users.mdf"";Integrated Security=True");
            sc.Open();
            SqlCommand cmd = new SqlCommand("SELECT Password FROM Admin WHERE UserName=@user", sc);
            cmd.Parameters.AddWithValue("@user", user);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Password = reader["Password"].ToString();
            }
            if (pass != Password)
            {
                MessageBox.Show($"Wrong password! try another password maybe?");
            }
            else if (user == "")
            {
                MessageBox.Show("What is your username?");
            }
            else if (pass=="")
            {
                MessageBox.Show("What About Your Password?");
            }
            else
            {
                MessageBox.Show($"Welcome back, {user}!");
                main.Show();
                
                textBox1.Clear();
                textBox2.Clear();
            }
            sc.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.Show();
            
            textBox1.Clear();
            textBox2.Clear();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            sign.Show();
            
            
        }
    }
}