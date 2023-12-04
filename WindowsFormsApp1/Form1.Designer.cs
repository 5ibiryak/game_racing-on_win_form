namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backGround_move1 = new System.Windows.Forms.PictureBox();
            this.backGround_move2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enemy_1 = new System.Windows.Forms.PictureBox();
            this.labelLoseGame = new System.Windows.Forms.Label();
            this.buttonAgainPlay = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            this.labelCoins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGround_move1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGround_move2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(353, 446);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(128, 128);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // backGround_move1
            // 
            this.backGround_move1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backGround_move1.BackgroundImage")));
            this.backGround_move1.Image = ((System.Drawing.Image)(resources.GetObject("backGround_move1.Image")));
            this.backGround_move1.Location = new System.Drawing.Point(0, 0);
            this.backGround_move1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backGround_move1.Name = "backGround_move1";
            this.backGround_move1.Size = new System.Drawing.Size(840, 650);
            this.backGround_move1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.backGround_move1.TabIndex = 3;
            this.backGround_move1.TabStop = false;
            this.backGround_move1.Click += new System.EventHandler(this.backGround_move_Click_1);
            // 
            // backGround_move2
            // 
            this.backGround_move2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backGround_move2.BackgroundImage")));
            this.backGround_move2.Image = ((System.Drawing.Image)(resources.GetObject("backGround_move2.Image")));
            this.backGround_move2.Location = new System.Drawing.Point(0, -814);
            this.backGround_move2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backGround_move2.Name = "backGround_move2";
            this.backGround_move2.Size = new System.Drawing.Size(1028, 807);
            this.backGround_move2.TabIndex = 4;
            this.backGround_move2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(481, -219);
            this.enemy1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(123, 130);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 5;
            this.enemy1.TabStop = false;
            this.enemy1.Click += new System.EventHandler(this.enemy1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(627, -375);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // enemy_1
            // 
            this.enemy_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enemy_1.Image = ((System.Drawing.Image)(resources.GetObject("enemy_1.Image")));
            this.enemy_1.Location = new System.Drawing.Point(612, -74);
            this.enemy_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enemy_1.Name = "enemy_1";
            this.enemy_1.Size = new System.Drawing.Size(105, 112);
            this.enemy_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy_1.TabIndex = 7;
            this.enemy_1.TabStop = false;
            // 
            // labelLoseGame
            // 
            this.labelLoseGame.AutoSize = true;
            this.labelLoseGame.BackColor = System.Drawing.Color.Salmon;
            this.labelLoseGame.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoseGame.ForeColor = System.Drawing.Color.Snow;
            this.labelLoseGame.Location = new System.Drawing.Point(440, 229);
            this.labelLoseGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoseGame.Name = "labelLoseGame";
            this.labelLoseGame.Size = new System.Drawing.Size(229, 45);
            this.labelLoseGame.TabIndex = 8;
            this.labelLoseGame.Text = "You are lose";
            this.labelLoseGame.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAgainPlay
            // 
            this.buttonAgainPlay.BackColor = System.Drawing.Color.Salmon;
            this.buttonAgainPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAgainPlay.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAgainPlay.ForeColor = System.Drawing.Color.Snow;
            this.buttonAgainPlay.Location = new System.Drawing.Point(495, 310);
            this.buttonAgainPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAgainPlay.Name = "buttonAgainPlay";
            this.buttonAgainPlay.Size = new System.Drawing.Size(133, 50);
            this.buttonAgainPlay.TabIndex = 9;
            this.buttonAgainPlay.Text = "Again";
            this.buttonAgainPlay.UseVisualStyleBackColor = false;
            this.buttonAgainPlay.Click += new System.EventHandler(this.buttonAgainPlay_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(275, -27);
            this.coin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(63, 49);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 10;
            this.coin.TabStop = false;
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.BackColor = System.Drawing.Color.Salmon;
            this.labelCoins.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoins.ForeColor = System.Drawing.Color.Snow;
            this.labelCoins.Location = new System.Drawing.Point(31, 26);
            this.labelCoins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(110, 31);
            this.labelCoins.TabIndex = 11;
            this.labelCoins.Text = "Coins: 0";
            this.labelCoins.Click += new System.EventHandler(this.labelCoins_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1021, 761);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.buttonAgainPlay);
            this.Controls.Add(this.labelLoseGame);
            this.Controls.Add(this.enemy_1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.backGround_move1);
            this.Controls.Add(this.backGround_move2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGround_move1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGround_move2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox backGround_move1;
        private System.Windows.Forms.PictureBox backGround_move2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox enemy_1;
        private System.Windows.Forms.Label labelLoseGame;
        private System.Windows.Forms.Button buttonAgainPlay;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label labelCoins;
    }
}

