﻿namespace CoffeShopApp
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
            this.btnKahveciAcilis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKahveciAcilis
            // 
            this.btnKahveciAcilis.Location = new System.Drawing.Point(98, 311);
            this.btnKahveciAcilis.Name = "btnKahveciAcilis";
            this.btnKahveciAcilis.Size = new System.Drawing.Size(287, 49);
            this.btnKahveciAcilis.TabIndex = 0;
            this.btnKahveciAcilis.Text = "Kahve Dükkanını Aç";
            this.btnKahveciAcilis.UseVisualStyleBackColor = true;
            this.btnKahveciAcilis.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeShopApp.Properties.Resources.coffee_cup_logo_coffee_shop_icon_design_free_vector;
            this.pictureBox1.Location = new System.Drawing.Point(37, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 372);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKahveciAcilis);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKahveciAcilis;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

