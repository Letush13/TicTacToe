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
        int count_pictures = 0;
        bool win = false;
        bool turn = true; // True - X False - O
        Image image = Resources.Крестик;
        string player = "X";
        string computer = "O";
        PictureBox[,] pictures = new PictureBox[3, 3];
        public Form1()
        {
            InitializeComponent();
        }
        string[,] pictures_1 = new string[3, 3];

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
        private void Picture_Click(object sender, EventArgs e)
        {
            PictureBox cur_picture = (PictureBox)sender;
            //  MessageBox.Show(cur_picture.Tag.ToString());
            string tag_1 = cur_picture.Tag.ToString();
            int r = tag_1[0] - '0';
            int c = tag_1[1] - '0';
            //int r = cur_picture.Tag;
            if (win == false && pictures_1[r, c] != "O")
            {
                player = "X";
                count_pictures++;
                cur_picture.Image = Resources.Крестик;
                pictures_1[r, c] = player;
                CheckWin();
                if (win == false)
                {
                    Enemy_move();
                }

            }


        }

        //private bool CheckCell(PictureBox pictureBox)
        //{
        //    if (pictureBox.Image == null)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        private void CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                int row = 0;
                int col = 0;

                for (int j = 0; j < 3; j++)
                {
                    if (pictures_1[i, j] == player)
                        row++;

                    if (pictures_1[j, i] == player)
                        col++;
                }

                if (row == 3 || col == 3)
                {
                    MessageBox.Show("Win " + player);
                    win = true;
                    return;
                }
            }

            int diag1 = 0;
            int diag2 = 0;

            for (int i = 0; i < 3; i++)
            {
                if (pictures_1[i, i] == player)
                    diag1++;

                if (pictures_1[i, 2 - i] == player)
                    diag2++;
            }

            if (diag1 == 3 || diag2 == 3)
            {
                MessageBox.Show("Win " + player);
                win = true;
                return;
            }


            if (count_pictures == 9 && !win)
            {
                MessageBox.Show("notwin");
                win = true;
            }
        }

        private void Enemy_move()
        {
            Random numbers = new Random();
            int v = numbers.Next(3);
            int x = numbers.Next(3);

            while (!CheckCell(pictures[v, x]))
            {
                v = numbers.Next(3);
                x = numbers.Next(3);
            }
            player = "O";
            pictures_1[v, x] = player;
            //  CheckWin();
            pictures[v, x].Image = Resources.Нолик;
            CheckWin();

        }
     

        private void Form1_Load_1(object sender, EventArgs e)
        {
            draw_field();
        }
    }
}
