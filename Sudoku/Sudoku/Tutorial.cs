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
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f = "C:\\Users\\bshz2\\OneDrive\\Desktop\\Advanced Programming\\practice\\Sudoku\\How to Play Sudoku for Absolute Beginners.mp4";
        axWindowsMediaPlayer1.URL= f;
        }
    }
}
