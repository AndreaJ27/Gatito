﻿namespace Gatito
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FichasGato = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PicGanador = new System.Windows.Forms.PictureBox();
            this.LBLp1 = new System.Windows.Forms.Label();
            this.LBLp2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGanador)).BeginInit();
            this.SuspendLayout();
            // 
            // FichasGato
            // 
            this.FichasGato.BackColor = System.Drawing.Color.Transparent;
            this.FichasGato.ColumnCount = 3;
            this.FichasGato.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FichasGato.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FichasGato.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FichasGato.Location = new System.Drawing.Point(48, 22);
            this.FichasGato.Name = "FichasGato";
            this.FichasGato.RowCount = 3;
            this.FichasGato.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FichasGato.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FichasGato.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FichasGato.Size = new System.Drawing.Size(419, 307);
            this.FichasGato.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Gatito.Properties.Resources.Carrot;
            this.pictureBox1.Location = new System.Drawing.Point(356, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Gatito.Properties.Resources.unnamed;
            this.pictureBox2.Location = new System.Drawing.Point(504, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Gatito.Properties.Resources.Fox;
            this.pictureBox3.Location = new System.Drawing.Point(655, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 105);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "VS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PicGanador
            // 
            this.PicGanador.BackColor = System.Drawing.Color.Transparent;
            this.PicGanador.Image = global::Gatito.Properties.Resources.Sunflower;
            this.PicGanador.Location = new System.Drawing.Point(647, 182);
            this.PicGanador.Name = "PicGanador";
            this.PicGanador.Size = new System.Drawing.Size(144, 136);
            this.PicGanador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicGanador.TabIndex = 5;
            this.PicGanador.TabStop = false;
            // 
            // LBLp1
            // 
            this.LBLp1.AutoSize = true;
            this.LBLp1.Location = new System.Drawing.Point(544, 134);
            this.LBLp1.Name = "LBLp1";
            this.LBLp1.Size = new System.Drawing.Size(13, 13);
            this.LBLp1.TabIndex = 6;
            this.LBLp1.Text = "0";
            // 
            // LBLp2
            // 
            this.LBLp2.AutoSize = true;
            this.LBLp2.Location = new System.Drawing.Point(697, 134);
            this.LBLp2.Name = "LBLp2";
            this.LBLp2.Size = new System.Drawing.Size(13, 13);
            this.LBLp2.TabIndex = 7;
            this.LBLp2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(671, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "GANADOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gatito.Properties.Resources.tumblr_oh73mokS1a1v6jzs4o1_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBLp2);
            this.Controls.Add(this.LBLp1);
            this.Controls.Add(this.PicGanador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FichasGato);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Juego gatito";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGanador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FichasGato;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicGanador;
        private System.Windows.Forms.Label LBLp1;
        private System.Windows.Forms.Label LBLp2;
        private System.Windows.Forms.Label label4;
    }
}
