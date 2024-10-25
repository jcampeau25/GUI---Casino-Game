namespace GUI___Casino_Game
{
    partial class Slot
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
            this.btnSpin = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.imgLogo3 = new System.Windows.Forms.PictureBox();
            this.imgLogo2 = new System.Windows.Forms.PictureBox();
            this.imgLogo1 = new System.Windows.Forms.PictureBox();
            this.imgSpinner1 = new System.Windows.Forms.PictureBox();
            this.imgSpinner3 = new System.Windows.Forms.PictureBox();
            this.imgSpinner2 = new System.Windows.Forms.PictureBox();
            this.tmrSpin1 = new System.Windows.Forms.Timer(this.components);
            this.tmrSpin2 = new System.Windows.Forms.Timer(this.components);
            this.tmrSpin3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinner3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinner2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(329, 281);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(143, 70);
            this.btnSpin.TabIndex = 0;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(12, 379);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(183, 31);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "$100 Per Spin";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(12, 410);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(203, 31);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "Money: $10000";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Black;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuit.Location = new System.Drawing.Point(690, 410);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(89, 28);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // imgLogo3
            // 
            this.imgLogo3.BackColor = System.Drawing.Color.White;
            this.imgLogo3.Image = global::GUI___Casino_Game.Properties.Resources.clancy;
            this.imgLogo3.Location = new System.Drawing.Point(490, 82);
            this.imgLogo3.Name = "imgLogo3";
            this.imgLogo3.Size = new System.Drawing.Size(117, 119);
            this.imgLogo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo3.TabIndex = 8;
            this.imgLogo3.TabStop = false;
            // 
            // imgLogo2
            // 
            this.imgLogo2.BackColor = System.Drawing.Color.White;
            this.imgLogo2.Image = global::GUI___Casino_Game.Properties.Resources.clancy;
            this.imgLogo2.Location = new System.Drawing.Point(342, 82);
            this.imgLogo2.Name = "imgLogo2";
            this.imgLogo2.Size = new System.Drawing.Size(117, 119);
            this.imgLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo2.TabIndex = 7;
            this.imgLogo2.TabStop = false;
            // 
            // imgLogo1
            // 
            this.imgLogo1.BackColor = System.Drawing.Color.White;
            this.imgLogo1.Image = global::GUI___Casino_Game.Properties.Resources.clancy;
            this.imgLogo1.Location = new System.Drawing.Point(196, 82);
            this.imgLogo1.Name = "imgLogo1";
            this.imgLogo1.Size = new System.Drawing.Size(117, 119);
            this.imgLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo1.TabIndex = 6;
            this.imgLogo1.TabStop = false;
            // 
            // imgSpinner1
            // 
            this.imgSpinner1.BackColor = System.Drawing.Color.White;
            this.imgSpinner1.Image = global::GUI___Casino_Game.Properties.Resources.white_screen1;
            this.imgSpinner1.Location = new System.Drawing.Point(180, 30);
            this.imgSpinner1.Name = "imgSpinner1";
            this.imgSpinner1.Size = new System.Drawing.Size(143, 226);
            this.imgSpinner1.TabIndex = 3;
            this.imgSpinner1.TabStop = false;
            // 
            // imgSpinner3
            // 
            this.imgSpinner3.BackColor = System.Drawing.Color.White;
            this.imgSpinner3.Image = global::GUI___Casino_Game.Properties.Resources.white_screen;
            this.imgSpinner3.Location = new System.Drawing.Point(478, 30);
            this.imgSpinner3.Name = "imgSpinner3";
            this.imgSpinner3.Size = new System.Drawing.Size(143, 226);
            this.imgSpinner3.TabIndex = 2;
            this.imgSpinner3.TabStop = false;
            // 
            // imgSpinner2
            // 
            this.imgSpinner2.BackColor = System.Drawing.Color.White;
            this.imgSpinner2.Image = global::GUI___Casino_Game.Properties.Resources.white_screen;
            this.imgSpinner2.Location = new System.Drawing.Point(329, 30);
            this.imgSpinner2.Name = "imgSpinner2";
            this.imgSpinner2.Size = new System.Drawing.Size(143, 226);
            this.imgSpinner2.TabIndex = 1;
            this.imgSpinner2.TabStop = false;
            // 
            // tmrSpin1
            // 
            this.tmrSpin1.Interval = 1000000;
            // 
            // tmrSpin2
            // 
            this.tmrSpin2.Interval = 200;
            // 
            // tmrSpin3
            // 
            this.tmrSpin3.Interval = 300;
            // 
            // Slot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.imgLogo3);
            this.Controls.Add(this.imgLogo2);
            this.Controls.Add(this.imgLogo1);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.imgSpinner1);
            this.Controls.Add(this.imgSpinner3);
            this.Controls.Add(this.imgSpinner2);
            this.Controls.Add(this.btnSpin);
            this.Name = "Slot";
            this.Text = "TOP Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinner3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinner2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.PictureBox imgSpinner2;
        private System.Windows.Forms.PictureBox imgSpinner3;
        private System.Windows.Forms.PictureBox imgSpinner1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.PictureBox imgLogo1;
        private System.Windows.Forms.PictureBox imgLogo2;
        private System.Windows.Forms.PictureBox imgLogo3;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Timer tmrSpin1;
        private System.Windows.Forms.Timer tmrSpin2;
        private System.Windows.Forms.Timer tmrSpin3;
    }
}

