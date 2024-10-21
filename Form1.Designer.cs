namespace GUI___Casino_Game
{
    partial class Form1
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
            this.btnSpin = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgSpinner1 = new System.Windows.Forms.PictureBox();
            this.imgSpinner3 = new System.Windows.Forms.PictureBox();
            this.imgSpinner2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinner3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinner2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.lblPrice.Location = new System.Drawing.Point(12, 410);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(168, 31);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "$10 Per Spin";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(563, 410);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(188, 31);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "Money: $1000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::GUI___Casino_Game.Properties.Resources.clancy;
            this.pictureBox1.Location = new System.Drawing.Point(196, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::GUI___Casino_Game.Properties.Resources.clancy;
            this.pictureBox2.Location = new System.Drawing.Point(342, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::GUI___Casino_Game.Properties.Resources.clancy;
            this.pictureBox3.Location = new System.Drawing.Point(490, 82);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 119);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.imgSpinner1);
            this.Controls.Add(this.imgSpinner3);
            this.Controls.Add(this.imgSpinner2);
            this.Controls.Add(this.btnSpin);
            this.Name = "Form1";
            this.Text = "TOP Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinner3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinner2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

