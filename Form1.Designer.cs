namespace GameProject_Aleksic
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.player = new System.Windows.Forms.PictureBox();
            this.MainGameTimer = new System.Windows.Forms.Timer(this.components);
            this.picBoxWeapon = new System.Windows.Forms.PictureBox();
            this.picBoxWeapon2 = new System.Windows.Forms.PictureBox();
            this.picBoxWeapon3 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.pictureBoxHealth1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHealth2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHealth3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWeapon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWeapon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHealth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHealth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHealth3)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.player.Image = global::GameProject_Aleksic.Properties.Resources.pphop;
            this.player.Location = new System.Drawing.Point(331, 496);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(68, 65);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // MainGameTimer
            // 
            this.MainGameTimer.Interval = 20;
            this.MainGameTimer.Tick += new System.EventHandler(this.MainGameTimer_Tick);
            // 
            // picBoxWeapon
            // 
            this.picBoxWeapon.BackColor = System.Drawing.Color.Transparent;
            this.picBoxWeapon.Image = global::GameProject_Aleksic.Properties.Resources.weapon;
            this.picBoxWeapon.InitialImage = global::GameProject_Aleksic.Properties.Resources.weapon;
            this.picBoxWeapon.Location = new System.Drawing.Point(96, 48);
            this.picBoxWeapon.Name = "picBoxWeapon";
            this.picBoxWeapon.Size = new System.Drawing.Size(36, 90);
            this.picBoxWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxWeapon.TabIndex = 1;
            this.picBoxWeapon.TabStop = false;
            this.picBoxWeapon.Tag = "weapon";
            // 
            // picBoxWeapon2
            // 
            this.picBoxWeapon2.BackColor = System.Drawing.Color.Transparent;
            this.picBoxWeapon2.Image = global::GameProject_Aleksic.Properties.Resources.weapon;
            this.picBoxWeapon2.InitialImage = global::GameProject_Aleksic.Properties.Resources.weapon;
            this.picBoxWeapon2.Location = new System.Drawing.Point(347, 48);
            this.picBoxWeapon2.Name = "picBoxWeapon2";
            this.picBoxWeapon2.Size = new System.Drawing.Size(36, 90);
            this.picBoxWeapon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxWeapon2.TabIndex = 2;
            this.picBoxWeapon2.TabStop = false;
            this.picBoxWeapon2.Tag = "weapon";
            // 
            // picBoxWeapon3
            // 
            this.picBoxWeapon3.BackColor = System.Drawing.Color.Transparent;
            this.picBoxWeapon3.Image = global::GameProject_Aleksic.Properties.Resources.weapon;
            this.picBoxWeapon3.InitialImage = global::GameProject_Aleksic.Properties.Resources.weapon;
            this.picBoxWeapon3.Location = new System.Drawing.Point(588, 48);
            this.picBoxWeapon3.Name = "picBoxWeapon3";
            this.picBoxWeapon3.Size = new System.Drawing.Size(36, 90);
            this.picBoxWeapon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxWeapon3.TabIndex = 3;
            this.picBoxWeapon3.TabStop = false;
            this.picBoxWeapon3.Tag = "weapon";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblScore.Location = new System.Drawing.Point(13, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 22);
            this.lblScore.TabIndex = 4;
            // 
            // pictureBoxHealth1
            // 
            this.pictureBoxHealth1.Image = global::GameProject_Aleksic.Properties.Resources.heart;
            this.pictureBoxHealth1.Location = new System.Drawing.Point(588, 9);
            this.pictureBoxHealth1.Name = "pictureBoxHealth1";
            this.pictureBoxHealth1.Size = new System.Drawing.Size(44, 33);
            this.pictureBoxHealth1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHealth1.TabIndex = 5;
            this.pictureBoxHealth1.TabStop = false;
            // 
            // pictureBoxHealth2
            // 
            this.pictureBoxHealth2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHealth2.Image")));
            this.pictureBoxHealth2.Location = new System.Drawing.Point(638, 9);
            this.pictureBoxHealth2.Name = "pictureBoxHealth2";
            this.pictureBoxHealth2.Size = new System.Drawing.Size(44, 33);
            this.pictureBoxHealth2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHealth2.TabIndex = 6;
            this.pictureBoxHealth2.TabStop = false;
            // 
            // pictureBoxHealth3
            // 
            this.pictureBoxHealth3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHealth3.Image")));
            this.pictureBoxHealth3.Location = new System.Drawing.Point(688, 9);
            this.pictureBoxHealth3.Name = "pictureBoxHealth3";
            this.pictureBoxHealth3.Size = new System.Drawing.Size(44, 33);
            this.pictureBoxHealth3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHealth3.TabIndex = 7;
            this.pictureBoxHealth3.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(738, 554);
            this.Controls.Add(this.pictureBoxHealth3);
            this.Controls.Add(this.pictureBoxHealth2);
            this.Controls.Add(this.pictureBoxHealth1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picBoxWeapon3);
            this.Controls.Add(this.picBoxWeapon2);
            this.Controls.Add(this.picBoxWeapon);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ppHop Vanja Aleksič 3.I SPŠS Betlémská";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWeapon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWeapon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHealth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHealth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHealth3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer MainGameTimer;
        private System.Windows.Forms.PictureBox picBoxWeapon;
        private System.Windows.Forms.PictureBox picBoxWeapon2;
        private System.Windows.Forms.PictureBox picBoxWeapon3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pictureBoxHealth1;
        private System.Windows.Forms.PictureBox pictureBoxHealth2;
        private System.Windows.Forms.PictureBox pictureBoxHealth3;
    }
}

