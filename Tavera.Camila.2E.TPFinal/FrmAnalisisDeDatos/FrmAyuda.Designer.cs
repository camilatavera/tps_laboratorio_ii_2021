﻿
namespace FrmAnalisisDeDatos
{
    partial class FrmAyuda
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
            this.txt_ayuda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_ayuda
            // 
            this.txt_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txt_ayuda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ayuda.ForeColor = System.Drawing.Color.Coral;
            this.txt_ayuda.Location = new System.Drawing.Point(54, 57);
            this.txt_ayuda.Multiline = true;
            this.txt_ayuda.Name = "txt_ayuda";
            this.txt_ayuda.Size = new System.Drawing.Size(558, 316);
            this.txt_ayuda.TabIndex = 18;
            // 
            // FrmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.txt_ayuda);
            this.Name = "FrmAyuda";
            this.Text = "FrmAyuda";
            this.Load += new System.EventHandler(this.FrmAyuda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_ayuda;
    }
}