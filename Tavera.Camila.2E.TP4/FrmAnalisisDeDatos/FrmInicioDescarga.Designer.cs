
namespace FrmAnalisisDeDatos
{
    partial class FrmInicioDescarga
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
            this.lbl_xml = new System.Windows.Forms.Label();
            this.lbl_db = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_xml
            // 
            this.lbl_xml.AutoSize = true;
            this.lbl_xml.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_xml.ForeColor = System.Drawing.Color.White;
            this.lbl_xml.Location = new System.Drawing.Point(50, 134);
            this.lbl_xml.Name = "lbl_xml";
            this.lbl_xml.Size = new System.Drawing.Size(0, 25);
            this.lbl_xml.TabIndex = 31;
            // 
            // lbl_db
            // 
            this.lbl_db.AutoSize = true;
            this.lbl_db.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_db.ForeColor = System.Drawing.Color.White;
            this.lbl_db.Location = new System.Drawing.Point(50, 250);
            this.lbl_db.Name = "lbl_db";
            this.lbl_db.Size = new System.Drawing.Size(0, 25);
            this.lbl_db.TabIndex = 33;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.Color.Coral;
            this.btn_cancel.Location = new System.Drawing.Point(192, 339);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(166, 45);
            this.btn_cancel.TabIndex = 35;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_inicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_inicio.ForeColor = System.Drawing.Color.Coral;
            this.btn_inicio.Location = new System.Drawing.Point(403, 339);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(166, 45);
            this.btn_inicio.TabIndex = 36;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // FrmInicioDescarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_db);
            this.Controls.Add(this.lbl_xml);
            this.Name = "FrmInicioDescarga";
            this.Text = "FrmDescargaPrincipal";
            this.Load += new System.EventHandler(this.FrmDescargaPrincipal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmDescargaPrincipal_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_xml;
        private System.Windows.Forms.Label lbl_db;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_inicio;
    }
}