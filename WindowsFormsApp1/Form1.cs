using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Point pos;
        private bool dragging, lose = false;
        private int countCoins = 0;
        public Form1()
        {
            InitializeComponent();
            backGround_move1.MouseDown += MouseClickDown;
            backGround_move1.MouseUp += MouseClickUp;
            backGround_move1.MouseMove += MouseClickMove;
            backGround_move2.MouseDown += MouseClickDown;
            backGround_move2.MouseUp += MouseClickUp;
            backGround_move2.MouseMove += MouseClickMove;
            labelLoseGame.Visible = false;
            buttonAgainPlay.Visible = false;
            KeyPreview = true;
        }

        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            
        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentPos = PointToScreen(new Point(e.X,e.Y));
                this.Location = new Point(currentPos.X - pos.X, currentPos.Y - pos.Y);
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int speed = 10;
            backGround_move1.Top += speed;
            backGround_move2.Top += speed;

            int carSpeed = 7;
            enemy1.Top += carSpeed;
            enemy_1.Top += carSpeed;

            coin.Top += speed;
            if (backGround_move1.Top >= 650)
            {
                backGround_move1.Top = 0;
                backGround_move2.Top = -650;
            }

            if (coin.Top >= 650)
            {
                coin.Top = -90;
                Random rand = new Random();
                coin.Left = rand.Next(150, 560);
            }

            if (enemy1.Top >= 650)
            {
                enemy1.Top = -240;
                Random rand = new Random();
                enemy1.Left = rand.Next(150, 300);
            }
            if (enemy_1.Top >= 650)
            {
                enemy_1.Top = -62;
                Random rand = new Random();
                enemy_1.Left = rand.Next(300, 560);
            }

            if (player.Bounds.IntersectsWith(enemy1.Bounds) || player.Bounds.IntersectsWith(enemy_1.Bounds))
            {
                timer1.Enabled = false;
                labelLoseGame.Visible = true;
                buttonAgainPlay.Visible = true;
                lose = true;
            }

            if (player.Bounds.IntersectsWith(coin.Bounds))
            {
                countCoins++;
                labelCoins.Text = "Coins: " + countCoins.ToString();
                coin.Top = -90;
                Random rand = new Random();
                coin.Left = rand.Next(150, 560);

            }
        }

        private void backGround_move_Click(object sender, EventArgs e)
        {

        }

        private void backGround_move_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return;
            int speed = 10;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left > 150)
            {
                player.Left -= speed;
            }
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right < 700)
            {
                player.Left += speed;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enemy1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelCoins_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgainPlay_Click(object sender, EventArgs e)
        {
            enemy1.Top = -70;
            enemy_1.Top = -140;
            labelLoseGame.Visible = false;
            buttonAgainPlay.Visible = false;
            timer1.Enabled = true;
            lose = false;
            countCoins=0;
            labelCoins.Text = "Coins: 0";
            coin.Top = -150;
        }
    }
}
