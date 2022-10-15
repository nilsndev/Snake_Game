using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using World_Best_Snake_Game.Class;

namespace World_Best_Snake_Game{
    public partial class Form1 : Form{
        Label[,] labelgrid = new Label[16,16];
        List<Snake> snake = new List<Snake>();
        Random r = new Random();
        bool goUp,goDown,goLeft,goRight;

        public Form1()
        {
            InitializeComponent();
            new Settings();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Left && Settings.Direction != "right"){
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.Direction != "left"){
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.Direction != "down"){
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.Direction != "up"){
                goDown = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Up){
                goUp = false;

            }
            if (e.KeyCode == Keys.Left){
                goLeft= false;
                Console.WriteLine("Hallo!");
            }
            if (e.KeyCode == Keys.Down){
                goDown = false;

            }
            if (e.KeyCode == Keys.Right){
                goRight = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e){
            loadGrid();
        }
        void startGame(){
            clearGrid();
            clearFood();
            
            createSnake();
            drawSnake();
            randomFood();
            Settings.Direction = "right";
            this.start_Button1.Visible = false;
            this.exit_button1.Visible = false;
            game_timer1.Enabled = true;
        }
        void clearFood(){
            for (int i = 0; i < 16; i++){
                for (int j = 0; j < 16; j++){
                    if (labelgrid[i, j].Tag == "Apel"){
                        labelgrid[i, j].Tag = "";
                    }
                }
            }
        }
        private void game_timer1_Tick(object sender, EventArgs e){
            try{
                moveSake();
                drawSnake();
            }
            catch{
                gameOver();
            }
        }
        void randomFood(){
            int x;
            int y; 
            do
            {
                x = r.Next(0, 16);
                y = r.Next(0, 16);
                labelgrid[x,y].Tag = "Apel";
            } while (labelgrid[x,y].BackColor == Color.Green);
            
        }
        void loadGrid(){
            for (int x = 0; x < 16; x++){
                for (int y = 0; y < 16; y++){
                    labelgrid[x, y] = new Label();
                    labelgrid[x, y].Width = this.game_panel1.Width / 16;
                    labelgrid[x, y].Tag = "Block";
                    labelgrid[x, y].Height = this.game_panel1.Height / 16;
                    labelgrid[x, y].Location =
                    new Point(x * labelgrid[x, y].Width,
                              y * labelgrid[x, y].Height);
                    labelgrid[x, y].BorderStyle = BorderStyle.FixedSingle;
                    this.game_panel1.Controls.Add(labelgrid[x, y]);
                }
            }
        }
        void drawSnake(){
            for (int i = 0; i < snake.Count; i++){   
                if((snake[i].X < labelgrid.GetLength(0) && snake[i].X >= 0)&&
                   (snake[i].Y < labelgrid.GetLength(1) && snake[i].Y >= 0)){
                    labelgrid[snake[i].X, snake[i].Y].BackColor = Color.Green;
                }
            }
        }
        void clearGrid(){
            for (int x = 0; x < 16; x++){
                for (int y = 0; y < 16; y++){
                    labelgrid[x, y].BackColor = Color.Black;
                    if (labelgrid[x, y].Tag == "Apel"){
                        labelgrid[x, y].BackColor = Color.Red;
                    }
                }
            }

        }
        void createSnake()
        {
            snake.Clear();
            snake.Add(new Snake { X = 4, Y = 5 });
            snake.Add(new Snake { X = 3, Y = 5 });
            snake.Add(new Snake { X = 2, Y = 5 });
        }
        void moveSake(){
            if (goUp) Settings.Direction = "up";
            if (goDown) Settings.Direction = "down";
            if (goLeft) Settings.Direction = "left";
            if (goRight) Settings.Direction = "right";
            clearGrid();
            switch (Settings.Direction){
            case "left":moveDirection(0, -1, 0);break;
            case "right":moveDirection(0, 1, 0);break;
            case "up":moveDirection(0, 0, -1);break;
            case "down":moveDirection(0, 0, 1);break;
            }
        }

        private void exit_button1_Click(object sender, EventArgs e){
            Application.Exit();

        }

        private void start_Button1_Click(object sender, EventArgs e){
            startGame();
        }

        void moveDirection(int maxValue,int newX,int newY){
            slidingOverSnake(maxValue,newX,newY);
            for (int i = snake.Count - 1; i >= 0; i--){
                if (i >= 1){
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
                else{
                    
                    if (labelgrid[snake[i].X, snake[i].Y].Tag == "Apel"){
                        labelgrid[snake[i].X, snake[i].Y].Tag = "";
                        snake.Add(new Snake { X = snake[snake.Count - 1].X - 1, Y = snake[snake.Count - 1].Y });
                        randomFood();
                    }
                    snake[i].X = snake[i].X + newX;
                    snake[i].Y = snake[i].Y + newY;
                }
            }

        }
        void slidingOverSnake(int maxValue, int newX, int newY){
            for (int i = 1; i < snake.Count; i++){
                bool xTrue = snake[0].X + newX == snake[i].X;
                bool yTrue = snake[0].Y + newY == snake[i].Y;
                if (xTrue && yTrue){
                    gameOver();
                }
            
            }
        }
        void gameOver(){
            this.start_Button1.Visible = true;
            this.exit_button1.Visible = true;
            this.game_timer1.Stop();

        }
        private void header_label1_Click(object sender, EventArgs e)
        {

        }
    }
            
       
}
