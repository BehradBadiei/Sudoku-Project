using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            
        }
        

        Sudoku sudoku = new Sudoku();
        
        private void Main_Load(object sender, EventArgs e)
        {
            string[] difficulty = { "Easy", "medium", "hard" };
            for (int i = 0; i < difficulty.Length; i++)
            {
                comboBox1.Items.Add(difficulty[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Sudoku sudoku = new Sudoku();
                sudoku.Show();
                sudoku.Dif = 3;
                comboBox1.SelectedItem = null;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Sudoku sudoku = new Sudoku();
                sudoku.Show();
                sudoku.Dif = 5;
                comboBox1.SelectedItem = null;
            }
            else if(comboBox1.SelectedIndex==2)
            {
                Sudoku sudoku = new Sudoku();
                sudoku.Show();
                sudoku.Dif = 6;
                comboBox1.SelectedItem= null;
            }
            else
            {
                MessageBox.Show("Choose a Difficulty level!");
            }
        }
        
        
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
            this.Hide();
            e.Cancel = true;
            
            
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tutorial tut = new Tutorial();
            tut.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rock_paper_scissors rps=new Rock_paper_scissors();
            rps.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tutorial tut = new Tutorial();
            tut.Show();
        }
    }
}
