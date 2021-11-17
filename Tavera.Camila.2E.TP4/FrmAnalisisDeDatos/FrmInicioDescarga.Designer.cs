
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
            this.btn_db = new System.Windows.Forms.Button();
            this.btn_xml = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
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
            // btn_db
            // 
            this.btn_db.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_db.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_db.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_db.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_db.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_db.ForeColor = System.Drawing.Color.Coral;
            this.btn_db.Location = new System.Drawing.Point(396, 358);
            this.btn_db.Name = "btn_db";
            this.btn_db.Size = new System.Drawing.Size(261, 45);
            this.btn_db.TabIndex = 36;
            this.btn_db.Text = "Solo base de datos";
            this.btn_db.UseVisualStyleBackColor = true;
            this.btn_db.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_xml
            // 
            this.btn_xml.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_xml.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_xml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_xml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xml.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xml.ForeColor = System.Drawing.Color.Coral;
            this.btn_xml.Location = new System.Drawing.Point(92, 358);
            this.btn_xml.Name = "btn_xml";
            this.btn_xml.Size = new System.Drawing.Size(261, 45);
            this.btn_xml.TabIndex = 37;
            this.btn_xml.Text = "Agregar xml";
            this.btn_xml.UseVisualStyleBackColor = true;
            this.btn_xml.Click += new System.EventHandler(this.btn_xml_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_entrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_entrar.ForeColor = System.Drawing.Color.Coral;
            this.btn_entrar.Location = new System.Drawing.Point(659, 123);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(107, 152);
            this.btn_entrar.TabIndex = 38;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // FrmInicioDescarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.btn_xml);
            this.Controls.Add(this.btn_db);
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
        public System.Windows.Forms.Button btn_db;
        public System.Windows.Forms.Button btn_xml;
        public System.Windows.Forms.Button btn_entrar;
    }
}