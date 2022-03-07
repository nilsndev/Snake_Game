using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace World_Best_Snake_Game
{
    public partial class Form1 : Form
    {
        List<Circle> Snake = new List<Circle> ();
        Circle food = new Circle();
        Random rand = new Random();
        int score = 0;
        int maxWidth;
        int maxHeight;
        bool goLeft,goRight,goUp,goDown;


        public Form1()
        {
            InitializeComponent();
            new Settings();
        }

        private void game_panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush color;
            for(int i = 0; i < Snake.Count; i++)
            {
                if(i == 0)
                {
                    color = Brushes.Yellow;

                }
                else
                {
                    color = Brushes.LightGreen;
                }
                g.FillEllipse(color,new Rectangle(Snake[i].X * Settings.Width,Snake[i].Y * Settings.Height
                                                 ,Settings.Width,Settings.Height));

            }

            g.FillEllipse(Brushes.Red, new Rectangle(food.X * Settings.Width, food.Y * Settings.Height, Settings.Width, Settings.Height));
     
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          if(e.KeyCode == Keys.A && Settings.Direction != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.D && Settings.Direction != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.W && Settings.Direction != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.S && Settings.Direction != "up")
            {
                goDown = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }

        }

       
        private void start_label1_Click(object sender, EventArgs e)
        {
            score = 0;
            score_label1.Visible = false;
            start_label1.Visible = false;
            exit_label1.Visible = false;
            startGame();
        }

        private void exit_label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        void startGame()
        {
            maxWidth = game_panel1.Width / Settings.Width;
            maxHeight = game_panel1.Height / Settings.Height;
            Snake.Clear();
         
            Circle head = new Circle { X = 20,Y = 20};
            Snake.Add(head);
            
            for(int i = 0; i < 2; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }
            food.X = rand.Next(0, maxWidth);
            food.Y = rand.Next(0, maxHeight);
            game_timer1.Start();
        }
        private void game_timer1_Tick(object sender, EventArgs e)
        {
            if (goLeft)
            Settings.Direction = "left";

            if (goRight)
            Settings.Direction = "right";

            if (goUp)
            Settings.Direction = "up";

            if (goDown)
            Settings.Direction = "down";

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.Direction)
                    {
                        case "left": Snake[i].X--; break;
                        case "right": Snake[i].X++; break;
                        case "up": Snake[i].Y--; break;
                        case "down": Snake[i].Y++; break;
                    }

                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }


                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if(Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        score_label1.Visible = true;
                        Circle body = new Circle();
                        body.X = Snake[Snake.Count -1].X;
                        body.Y = Snake[Snake.Count -1].Y;
                        food.X = rand.Next(0, maxWidth);
                        food.Y = rand.Next(0, maxHeight);
                        Snake.Add(body);
                        score++;
                        this.score_label1.Text = score.ToString();
                    }
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if(Snake[i].X == Snake[j].X&& Snake[i].Y == Snake[j].Y)
                        {
                            gameOver();
                        }
                    }


                }
              
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }

                game_panel1.Invalidate();
            }

            void gameOver()
            {
                score_label1.Visible = true;
                start_label1.Visible = true;
                exit_label1.Visible = true;
                game_timer1.Stop();
            }
        }
    }
}
