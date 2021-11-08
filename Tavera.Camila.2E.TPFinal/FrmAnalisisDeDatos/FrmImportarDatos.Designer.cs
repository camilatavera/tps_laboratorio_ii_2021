
namespace FrmAnalisisDeDatos
{
    partial class FrmImportarDatos
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
            this.btn_abrirArchivo = new System.Windows.Forms.Button();
            this.rtb_datos = new System.Windows.Forms.RichTextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_automatic = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_abrirArchivo
            // 
            this.btn_abrirArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_abrirArchivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_abrirArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_abrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abrirArchivo.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_abrirArchivo.ForeColor = System.Drawing.Color.Coral;
            this.btn_abrirArchivo.Location = new System.Drawing.Point(103, 21);
            this.btn_abrirArchivo.Name = "btn_abrirArchivo";
            this.btn_abrirArchivo.Size = new System.Drawing.Size(326, 45);
            this.btn_abrirArchivo.TabIndex = 27;
            this.btn_abrirArchivo.Text = "Abrir archivo";
            this.btn_abrirArchivo.UseVisualStyleBackColor = true;
            this.btn_abrirArchivo.Click += new System.EventHandler(this.btn_abrirArchivo_Click);
            // 
            // rtb_datos
            // 
            this.rtb_datos.Location = new System.Drawing.Point(93, 79);
            this.rtb_datos.Name = "rtb_datos";
            this.rtb_datos.Size = new System.Drawing.Size(608, 330);
            this.rtb_datos.TabIndex = 28;
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
            this.btn_cancel.Location = new System.Drawing.Point(291, 436);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(182, 45);
            this.btn_cancel.TabIndex = 29;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_guardar.Enabled = false;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_guardar.ForeColor = System.Drawing.Color.Coral;
            this.btn_guardar.Location = new System.Drawing.Point(479, 436);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(200, 45);
            this.btn_guardar.TabIndex = 30;
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
            this.btn_automatic.Location = new System.Drawing.Point(455, 10);
            this.btn_automatic.Name = "btn_automatic";
            this.btn_automatic.Size = new System.Drawing.Size(224, 63);
            this.btn_automatic.TabIndex = 32;
            this.btn_automatic.Text = "Importar automaticamente";
            this.btn_automatic.UseVisualStyleBackColor = true;
            this.btn_automatic.Click += new System.EventHandler(this.btn_automatic_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ayuda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ayuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayuda.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ayuda.ForeColor = System.Drawing.Color.Red;
            this.btn_ayuda.Location = new System.Drawing.Point(103, 432);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(165, 49);
            this.btn_ayuda.TabIndex = 33;
            this.btn_ayuda.Text = "Importante";
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // FrmImportarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(814, 527);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_automatic);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.rtb_datos);
            this.Controls.Add(this.btn_abrirArchivo);
            this.Name = "FrmImportarDatos";
            this.Text = "FrmImportarDatos";
            this.Load += new System.EventHandler(this.FrmImportarDatos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btn_abrirArchivo;
        private System.Windows.Forms.RichTextBox rtb_datos;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.Button btn_automatic;
        public System.Windows.Forms.Button btn_ayuda;
    }
}