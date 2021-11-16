
namespace FrmAnalisisDeDatos
{
    partial class FrmComparar
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
            this.cmb_grupo1 = new System.Windows.Forms.ComboBox();
            this.cmb_grupo2 = new System.Windows.Forms.ComboBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.lbl_intro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_grupo1
            // 
            this.cmb_grupo1.FormattingEnabled = true;
            this.cmb_grupo1.Location = new System.Drawing.Point(123, 141);
            this.cmb_grupo1.Name = "cmb_grupo1";
            this.cmb_grupo1.Size = new System.Drawing.Size(147, 23);
            this.cmb_grupo1.TabIndex = 0;
            // 
            // cmb_grupo2
            // 
            this.cmb_grupo2.FormattingEnabled = true;
            this.cmb_grupo2.Location = new System.Drawing.Point(317, 141);
            this.cmb_grupo2.Name = "cmb_grupo2";
            this.cmb_grupo2.Size = new System.Drawing.Size(140, 23);
            this.cmb_grupo2.TabIndex = 1;
            // 
            // btn_generar
            // 
            this.btn_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_generar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_generar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_generar.ForeColor = System.Drawing.Color.Coral;
            this.btn_generar.Location = new System.Drawing.Point(213, 212);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(164, 56);
            this.btn_generar.TabIndex = 28;
            this.btn_generar.Text = "Comparar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // lbl_intro
            // 
            this.lbl_intro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_intro.ForeColor = System.Drawing.Color.Coral;
            this.lbl_intro.Location = new System.Drawing.Point(77, 36);
            this.lbl_intro.Name = "lbl_intro";
            this.lbl_intro.Size = new System.Drawing.Size(432, 59);
            this.lbl_intro.TabIndex = 29;
            this.lbl_intro.Text = "Elija dos grupos y guarda el informe en un archivo.txt y los grupos en un archivo" +
    " Json";
            // 
            // FrmComparar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(651, 381);
            this.Controls.Add(this.lbl_intro);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.cmb_grupo2);
            this.Controls.Add(this.cmb_grupo1);
            this.Name = "FrmComparar";
            this.Text = "FrmComparar";
            this.Load += new System.EventHandler(this.FrmComparar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_grupo1;
        private System.Windows.Forms.ComboBox cmb_grupo2;
        public System.Windows.Forms.Button btn_generar;
        public System.Windows.Forms.Label lbl_intro;
    }
}