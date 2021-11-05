
namespace FrmAnalisisDeDatos
{
    partial class FrmOpcionesAgregar
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
            this.btn_estudiante = new System.Windows.Forms.Button();
            this.btn_ordenanza = new System.Windows.Forms.Button();
            this.btn_profesor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_estudiante
            // 
            this.btn_estudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_estudiante.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_estudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_estudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estudiante.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_estudiante.ForeColor = System.Drawing.Color.Coral;
            this.btn_estudiante.Location = new System.Drawing.Point(88, 62);
            this.btn_estudiante.Name = "btn_estudiante";
            this.btn_estudiante.Size = new System.Drawing.Size(245, 69);
            this.btn_estudiante.TabIndex = 27;
            this.btn_estudiante.Text = "Estudiante";
            this.btn_estudiante.UseVisualStyleBackColor = true;
            this.btn_estudiante.Click += new System.EventHandler(this.btn_estudiante_Click);
            // 
            // btn_ordenanza
            // 
            this.btn_ordenanza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ordenanza.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ordenanza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ordenanza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ordenanza.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ordenanza.ForeColor = System.Drawing.Color.Coral;
            this.btn_ordenanza.Location = new System.Drawing.Point(88, 167);
            this.btn_ordenanza.Name = "btn_ordenanza";
            this.btn_ordenanza.Size = new System.Drawing.Size(245, 69);
            this.btn_ordenanza.TabIndex = 28;
            this.btn_ordenanza.Text = "Ordenanza";
            this.btn_ordenanza.UseVisualStyleBackColor = true;
            this.btn_ordenanza.Click += new System.EventHandler(this.btn_ordenanza_Click);
            // 
            // btn_profesor
            // 
            this.btn_profesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_profesor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_profesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_profesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profesor.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_profesor.ForeColor = System.Drawing.Color.Coral;
            this.btn_profesor.Location = new System.Drawing.Point(88, 287);
            this.btn_profesor.Name = "btn_profesor";
            this.btn_profesor.Size = new System.Drawing.Size(245, 69);
            this.btn_profesor.TabIndex = 29;
            this.btn_profesor.Text = "Profesor";
            this.btn_profesor.UseVisualStyleBackColor = true;
            this.btn_profesor.Click += new System.EventHandler(this.btn_profesor_Click);
            // 
            // FrmOpcionesAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.btn_profesor);
            this.Controls.Add(this.btn_ordenanza);
            this.Controls.Add(this.btn_estudiante);
            this.Name = "FrmOpcionesAgregar";
            this.Text = "FrmOpcionesAgregar";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_estudiante;
        public System.Windows.Forms.Button btn_ordenanza;
        public System.Windows.Forms.Button btn_profesor;
    }
}