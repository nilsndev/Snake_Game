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
            this.game_timer1 = new System.Windows.Forms.Timer(this.components);
            this.game_panel1 = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.start_Button1 = new System.Windows.Forms.Label();
            this.exit_button1 = new System.Windows.Forms.Label();
            this.game_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // game_timer1
            // 
            this.game_timer1.Interval = 300;
            this.game_timer1.Tick += new System.EventHandler(this.game_timer1_Tick);
            // 
            // game_panel1
            // 
            this.game_panel1.Controls.Add(this.start_Button1);
            this.game_panel1.Controls.Add(this.exit_button1);
            this.game_panel1.Location = new System.Drawing.Point(91, 85);
            this.game_panel1.Name = "game_panel1";
            this.game_panel1.Size = new System.Drawing.Size(600, 600);
            this.game_panel1.TabIndex = 0;
            // 
            // start_Button1
            // 
            this.start_Button1.BackColor = System.Drawing.Color.Green;
            this.start_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_Button1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_Button1.ForeColor = System.Drawing.Color.Black;
            this.start_Button1.Location = new System.Drawing.Point(93, 81);
            this.start_Button1.Name = "start_Button1";
            this.start_Button1.Size = new System.Drawing.Size(441, 134);
            this.start_Button1.TabIndex = 2;
            this.start_Button1.Text = "START";
            this.start_Button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.start_Button1.Click += new System.EventHandler(this.start_Button1_Click);
            // 
            // exit_button1
            // 
            this.exit_button1.BackColor = System.Drawing.Color.Green;
            this.exit_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button1.ForeColor = System.Drawing.Color.Black;
            this.exit_button1.Location = new System.Drawing.Point(93, 343);
            this.exit_button1.Name = "exit_button1";
            this.exit_button1.Size = new System.Drawing.Size(441, 134);
            this.exit_button1.TabIndex = 3;
            this.exit_button1.Text = "EXIT";
            this.exit_button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit_button1.Click += new System.EventHandler(this.exit_button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.game_panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.game_panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer game_timer1;
        private System.Windows.Forms.Panel game_panel1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label exit_button1;
        private System.Windows.Forms.Label start_Button1;
    }
}

