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
        string player = "X";
        PictureBox[,] pictures = new PictureBox[3,3];
        public Form1()
        {
            InitializeComponent();
        }

        private void draw_field()
        {
            int x = 170;
            int y = 50;
            for (int i = 0; i < 3; i++) // столбцы
            {
                for (int j = 0; j < 3; j++) // Строки
                {
                    PictureBox new_picture = new PictureBox();
                    new_picture.BackColor = Color.HotPink;
                    new_picture.Location = new Point(x, y);
                    new_picture.Size = new Size(75, 75);
                    new_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    new_picture.Click += Picture_Click;
                    new_picture.Tag = i + "" + j;
                    Controls.Add(new_picture);
                    pictures[i, j] = new_picture;
                    x += 80;
                }
                y += 80;
                x = 170;
            }
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            PictureBox cur_picture = (PictureBox)sender;
            MessageBox.Show(cur_picture.Tag.ToString());
            if ( player == "X" && CheckCell(cur_picture))
            {
                
                cur_picture.Image = Resources.Крестик;
                player = "O";
            }
            else if (player == "O" && CheckCell(cur_picture))
            {
                
                cur_picture.Image = Resources.Нолик;
                player = "X";
            }
        
        }

        private bool CheckCell(PictureBox pictureBox)
        {
            if (pictureBox.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CheckWin()
        {
            // СТРОКИ
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; i++)
                {
                   // if (pictures[i, j])
                    {
                        MessageBox.Show("win");
                    }
                }
            }
            

            //if (pictureBox1.Tag == "X" && pictureBox2.Tag == "X" && pictureBox3.Tag == "X")
            //    {
            //    label1.Text = "X";
            //    }
            //if (pictureBox1.Tag == "O" && pictureBox2.Tag == "O" && pictureBox3.Tag == "O")
            //{
            //    label1.Text = "O";
            //}
            //if (pictureBox6.Tag == "X" && pictureBox5.Tag == "X" && pictureBox4.Tag == "X")
            //{
            //    label1.Text = "X";
            //}
            //if (pictureBox6.Tag == "O" && pictureBox5.Tag == "O" && pictureBox4.Tag == "O")
            //{
            //    label1.Text = "O";
            //}
            //if (pictureBox9.Tag == "X" && pictureBox8.Tag == "X" && pictureBox7.Tag == "X")
            //{
            //    label1.Text = "X";
            //}
            //if(pictureBox9.Tag == "O" && pictureBox8.Tag == "O" && pictureBox7.Tag == "O")
            //{
            //    label1.Text = "O";
            //}
            //if(pictureBox1.Tag == "X" && pictureBox5.Tag == "X" && pictureBox7.Tag == "X")
            //{
            //    label1.Text = "X";
            //}
            //if (pictureBox1.Tag == "O" && pictureBox5.Tag == "O" && pictureBox7.Tag == "O")
            //{
            //    label1.Text = "O";
            //}
            //if (pictureBox3.Tag == "X" && pictureBox5.Tag == "X" && pictureBox9.Tag == "X")
            //{
            //    label1.Text = "X";
            //}
            //if(pictureBox3.Tag == "O" && pictureBox5.Tag == "O" && pictureBox9.Tag == "O")
            //{
            //    label1.Text = "O";
            //}
            //if(pictureBox1.Tag == "X" && pictureBox6.Tag == "X" && pictureBox9.Tag == "X")
            //{
            //    label1.Text = "X";
            //}
            //if (pictureBox1.Tag == "O" && pictureBox6.Tag == "O" && pictureBox9.Tag == "O")
            //{
            //    label1.Text = "O";
            //}
            //if (pictureBox2.Tag == "X" && pictureBox5.Tag == "X" && pictureBox8.Tag == "X")
            //{
            //    label1.Text = "X";
            //}
            //if (pictureBox2.Tag == "O" && pictureBox5.Tag == "O" && pictureBox8.Tag == "O")
            //{
            //    label1.Text = "O";
            //}
            //if (pictureBox3.Tag == "X" && pictureBox4.Tag == "X" && pictureBox7.Tag == "X")
            //{
            //    label1.Text = "X";
            //}
            //if (pictureBox3.Tag == "O" && pictureBox4.Tag == "O" && pictureBox7.Tag == "O")
            //{
            //    label1.Text = "O";
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            draw_field();
        }
    }
}
