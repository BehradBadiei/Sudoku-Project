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
    public partial class Sudoku : Form
    {
        public Sudoku()
        {
            InitializeComponent();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    string textBoxName = $"textBox{i}{j}";
                    TextBox textBox = (TextBox)Controls.Find(textBoxName, true).FirstOrDefault();

                    if (textBox != null)
                    {
                        textBox.Leave += CommonTextBoxLeaveEvent;
                    }
                    else
                    {
                        // Handle the case where the textbox was not found (check the naming convention)
                        Console.WriteLine($"TextBox {textBoxName} not found.");
                    }
                }
            }
        }
        public int Dif;
        int[,] Board = new int[9, 9];
        TextBox[,] textBoxes = new TextBox[9, 9];
        private void CommonTextBoxLeaveEvent(object sender, EventArgs e)
        {
            // This method will be called when any of the textboxes lose focus (Leave event)
            TextBox textBox = (TextBox)sender;
            string textBoxName = textBox.Name.ToString();
            int i = 0;
            string[] charArray = new string[textBoxName.Length];
            foreach (char c in textBoxName)
            {
                charArray[i] = c.ToString();
                i++;
            }
            int Row = int.Parse(charArray[7]);
            int Col = int.Parse(charArray[8]);
            int Result = Check(Row, Col, Board);
            if (Result != int.Parse(textBox.Text))
            {

                textBox.BackColor = Color.IndianRed;
            }
            else
            {
                textBox.BackColor = Color.White;
            }

        }


        public void button1_Click(object sender, EventArgs e)
        {
            Board = numbers();

            Print(Board, this);


        }
        public static int[,] numbers()
        {
            int[,] board = new int[9, 9];
            Random random = new Random();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int newnum = 0;
                    int check = 0;

                    do
                    {
                        newnum = random.Next(1, 10);

                        if (check == 9)
                        {
                            ClearRow(board, i);
                            j = 0;
                            check = 0;
                        }
                        check++;
                    } while (!isValid(board, i, j, newnum));

                    board[i, j] = newnum;
                }
            }

            return board;
        }
        public static bool isValid(int[,] board, int row, int col, int num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[i, col] == num || board[row, i] == num || board[row - row % 3 + i / 3, col - col % 3 + i % 3] == num)
                {
                    return false;
                }
            }
            return true;

        }
        public static void ClearRow(int[,] board, int row)
        {
            for (int i = 0; i < 9; i++)
            {
                board[row, i] = 0;
            }


        }
        public void Print(int[,] board, Form form)
        {
            Random rand = new Random();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int a = rand.Next(Dif);
                    string textBoxName = $"textBox{i}{j}";
                    TextBox textBox = form.Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;
                    if (a == 0)
                    {
                        if (textBox != null)
                        {

                            textBox.Text = board[i, j].ToString();
                            textBox.BackColor = Color.White;
                        }
                    }
                    else
                    {
                        if (textBox != null)
                        {
                            textBox.Text = "0";
                            textBox.BackColor = Color.IndianRed;
                        }
                    }

                }
            }

        }
        private static int Check(int a, int b, int[,] board)
        {
            int CHECKER = board[a, b];
            return CHECKER;
        }

        private void Sudoku_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

