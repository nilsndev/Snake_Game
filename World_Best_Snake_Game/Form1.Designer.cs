namespace World_Best_Snake_Game
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.game_panel1 = new System.Windows.Forms.Panel();
            this.exit_label1 = new System.Windows.Forms.Label();
            this.start_label1 = new System.Windows.Forms.Label();
            this.score_label1 = new System.Windows.Forms.Label();
            this.game_timer1 = new System.Windows.Forms.Timer(this.components);
            this.game_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // game_panel1
            // 
            this.game_panel1.BackColor = System.Drawing.Color.Black;
            this.game_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.game_panel1.Controls.Add(this.exit_label1);
            this.game_panel1.Controls.Add(this.start_label1);
            this.game_panel1.Controls.Add(this.score_label1);
            this.game_panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.game_panel1.Location = new System.Drawing.Point(0, 0);
            this.game_panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.game_panel1.Name = "game_panel1";
            this.game_panel1.Size = new System.Drawing.Size(642, 456);
            this.game_panel1.TabIndex = 0;
            this.game_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.game_panel1_Paint);
            // 
            // exit_label1
            // 
            this.exit_label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.exit_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_label1.ForeColor = System.Drawing.Color.White;
            this.exit_label1.Location = new System.Drawing.Point(217, 272);
            this.exit_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exit_label1.Name = "exit_label1";
            this.exit_label1.Size = new System.Drawing.Size(225, 82);
            this.exit_label1.TabIndex = 2;
            this.exit_label1.Text = "EXIT";
            this.exit_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit_label1.Click += new System.EventHandler(this.exit_label1_Click);
            // 
            // start_label1
            // 
            this.start_label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.start_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_label1.ForeColor = System.Drawing.Color.White;
            this.start_label1.Location = new System.Drawing.Point(217, 79);
            this.start_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.start_label1.Name = "start_label1";
            this.start_label1.Size = new System.Drawing.Size(225, 82);
            this.start_label1.TabIndex = 1;
            this.start_label1.Text = "START";
            this.start_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.start_label1.Click += new System.EventHandler(this.start_label1_Click);
            // 
            // score_label1
            // 
            this.score_label1.BackColor = System.Drawing.Color.Transparent;
            this.score_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label1.ForeColor = System.Drawing.Color.White;
            this.score_label1.Location = new System.Drawing.Point(274, 193);
            this.score_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score_label1.Name = "score_label1";
            this.score_label1.Size = new System.Drawing.Size(114, 61);
            this.score_label1.TabIndex = 0;
            this.score_label1.Text = "0";
            this.score_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.score_label1.Visible = false;
            // 
            // game_timer1
            // 
            this.game_timer1.Interval = 200;
            this.game_timer1.Tick += new System.EventHandler(this.game_timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(642, 456);
            this.Controls.Add(this.game_panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.game_panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel game_panel1;
        private System.Windows.Forms.Timer game_timer1;
        private System.Windows.Forms.Label score_label1;
        private System.Windows.Forms.Label start_label1;
        private System.Windows.Forms.Label exit_label1;
    }
}

