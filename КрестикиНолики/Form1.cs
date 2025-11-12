using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using КрестикиНолики.Properties;

namespace КрестикиНолики
{
    public partial class Form1 : Form
    {
        bool turn = true; // True - X False - O
        Image image = Resources.Крестик;
        public Form1()
        {
            InitializeComponent();
        }


        private bool CheckCell(PictureBox pictureBox)
        {
            if (pictureBox.Image == null) {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CheckWin()
        {
            if (pictureBox1.Tag == "X" && pictureBox2.Tag == "X" && pictureBox3.Tag == "X")
                {
                label1.Text = "X";
                }
            if (pictureBox1.Tag == "O" && pictureBox2.Tag == "O" && pictureBox3.Tag == "O")
            {
                label1.Text = "O";
            }
            if (pictureBox6.Tag == "X" && pictureBox5.Tag == "X" && pictureBox4.Tag == "X")
            {
                label1.Text = "X";
            }
            if (pictureBox6.Tag == "O" && pictureBox5.Tag == "O" && pictureBox4.Tag == "O")
            {
                label1.Text = "O";
            }
            if (pictureBox9.Tag == "X" && pictureBox8.Tag == "X" && pictureBox7.Tag == "X")
            {
                label1.Text = "X";
            }
            if(pictureBox9.Tag == "O" && pictureBox8.Tag == "O" && pictureBox7.Tag == "O")
            {
                label1.Text = "O";
            }
            if(pictureBox1.Tag == "X" && pictureBox5.Tag == "X" && pictureBox7.Tag == "X")
            {
                label1.Text = "X";
            }
            if (pictureBox1.Tag == "O" && pictureBox5.Tag == "O" && pictureBox7.Tag == "O")
            {
                label1.Text = "O";
            }
            if (pictureBox3.Tag == "X" && pictureBox5.Tag == "X" && pictureBox9.Tag == "X")
            {
                label1.Text = "X";
            }
            if(pictureBox3.Tag == "O" && pictureBox5.Tag == "O" && pictureBox9.Tag == "O")
            {
                label1.Text = "O";
            }
            if(pictureBox1.Tag == "X" && pictureBox6.Tag == "X" && pictureBox9.Tag == "X")
            {
                label1.Text = "X";
            }
            if (pictureBox1.Tag == "O" && pictureBox6.Tag == "O" && pictureBox9.Tag == "O")
            {
                label1.Text = "O";
            }
            if (pictureBox2.Tag == "X" && pictureBox5.Tag == "X" && pictureBox8.Tag == "X")
            {
                label1.Text = "X";
            }
            if (pictureBox2.Tag == "O" && pictureBox5.Tag == "O" && pictureBox8.Tag == "O")
            {
                label1.Text = "O";
            }
            if (pictureBox3.Tag == "X" && pictureBox4.Tag == "X" && pictureBox7.Tag == "X")
            {
                label1.Text = "X";
            }
            if (pictureBox3.Tag == "O" && pictureBox4.Tag == "O" && pictureBox7.Tag == "O")
            {
                label1.Text = "O";
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox1))
            {
                pictureBox1.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                pictureBox1.Tag = turn == true ? pictureBox1.Tag = "X" : pictureBox1.Tag = "O";
                CheckWin();
                turn = !turn; // NOT
                
                
            }

          
            //if (turn)
            //{
            //    pictureBox1.Image = Resources.Крестик;
            //    turn = false;
            //}
            //else
            //{
            //    pictureBox1.Image = Resources.Нолик;
            //    turn = true;
            //}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox2))
            {
                pictureBox2.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                pictureBox2.Tag = turn == true ? pictureBox2.Tag = "X" : pictureBox2.Tag = "O";
                CheckWin();
                turn = !turn; // NOT
            }
               
            //if (turn)
            //{
            //    pictureBox2.Image = Resources.Крестик;
            //    turn = false;
            //}
            //else
            //{
            //    pictureBox2.Image = Resources.Нолик;
            //    turn = true;
            //}
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox3))
            {
                pictureBox3.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                pictureBox3.Tag = turn == true ? pictureBox3.Tag = "X" : pictureBox3.Tag = "O";
                CheckWin();
                turn = !turn; // NOT
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox6))
            {
                pictureBox6.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                pictureBox6.Tag = turn == true ? pictureBox6.Tag = "X" : pictureBox6.Tag = "O";
                CheckWin();
                turn = !turn; // NOT
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox5))
            {
                pictureBox5.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                pictureBox5.Tag = turn == true ? pictureBox5.Tag = "X" : pictureBox5.Tag = "O";
                CheckWin();
                turn = !turn; // NOT
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox4))
            {
                pictureBox4.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                pictureBox4.Tag = turn == true ? pictureBox4.Tag = "X" : pictureBox4.Tag = "O";
                CheckWin();
                turn = !turn; // NOT
            }

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox9))
            {
                pictureBox9.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                pictureBox9.Tag = turn == true ? pictureBox9.Tag = "X" : pictureBox9.Tag = "O";
                CheckWin();
                turn = !turn; // NOT
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox8))
            {
                pictureBox8.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                pictureBox8.Tag = turn == true ? pictureBox8.Tag = "X" : pictureBox8.Tag = "O";
                CheckWin();
                turn = !turn; // NOT
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox7))
            {
                pictureBox7.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                pictureBox7.Tag = turn == true ? pictureBox7.Tag = "X" : pictureBox7.Tag = "O";
                CheckWin();
                turn = !turn; // NOT
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
