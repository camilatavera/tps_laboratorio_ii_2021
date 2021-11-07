
namespace FrmAnalisisDeDatos
{
    partial class FrmExportarDatos
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
            this.rtb_datos = new System.Windows.Forms.RichTextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_automatic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_datos
            // 
            this.rtb_datos.Location = new System.Drawing.Point(89, 48);
            this.rtb_datos.Name = "rtb_datos";
            this.rtb_datos.Size = new System.Drawing.Size(608, 304);
            this.rtb_datos.TabIndex = 29;
            this.rtb_datos.Text = "";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.Color.Coral;
            this.btn_cancel.Location = new System.Drawing.Point(160, 381);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(214, 45);
            this.btn_cancel.TabIndex = 30;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_guardar.ForeColor = System.Drawing.Color.Coral;
            this.btn_guardar.Location = new System.Drawing.Point(414, 381);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(214, 45);
            this.btn_guardar.TabIndex = 31;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_automatic
            // 
            this.btn_automatic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_automatic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_automatic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_automatic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_automatic.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_automatic.ForeColor = System.Drawing.Color.Coral;
            this.btn_automatic.Location = new System.Drawing.Point(28, -3);
            this.btn_automatic.Name = "btn_automatic";
            this.btn_automatic.Size = new System.Drawing.Size(214, 45);
            this.btn_automatic.TabIndex = 32;
            this.btn_automatic.Text = "auto";
            this.btn_automatic.UseVisualStyleBackColor = true;
            this.btn_automatic.Click += new System.EventHandler(this.btn_automatic_Click);
            // 
            // FrmExportarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_automatic);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.rtb_datos);
            this.Name = "FrmExportarDatos";
            this.Text = "FrmExportarDatos";
            this.Load += new System.EventHandler(this.FrmExportarDatos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_datos;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.Button btn_automatic;
    }
}