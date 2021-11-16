
namespace FrmAnalisisDeDatos
{
    partial class FrmAgregarProfesor
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
            this.lbl_hCatedra = new System.Windows.Forms.Label();
            this.nud_hCatedra = new System.Windows.Forms.NumericUpDown();

            ((System.ComponentModel.ISupportInitialize)(this.nud_pComprados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_plata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_compras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hCatedra)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_guardar.Location = new System.Drawing.Point(256, 449);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cancel.Location = new System.Drawing.Point(45, 449);
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // cmb_sexo
            // 
            this.cmb_sexo.DataSource = new Bibloteca.Esexo[] {
                 Bibloteca.Esexo.f,
                 Bibloteca.Esexo.m};
          
            // 
            // lbl_hCatedra
            // 
            this.lbl_hCatedra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_hCatedra.ForeColor = System.Drawing.Color.Coral;
            this.lbl_hCatedra.Location = new System.Drawing.Point(16, 375);
            this.lbl_hCatedra.Name = "lbl_hCatedra";
            this.lbl_hCatedra.Size = new System.Drawing.Size(138, 30);
            this.lbl_hCatedra.TabIndex = 33;
            this.lbl_hCatedra.Text = "Horas catedra";
            // 
            // nud_hCatedra
            // 
            this.nud_hCatedra.Location = new System.Drawing.Point(143, 378);
            this.nud_hCatedra.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_hCatedra.Name = "nud_hCatedra";
            this.nud_hCatedra.Size = new System.Drawing.Size(120, 23);
            this.nud_hCatedra.TabIndex = 34;
            this.nud_hCatedra.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // FrmAgregarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 529);
            this.Controls.Add(this.nud_hCatedra);
            this.Controls.Add(this.lbl_hCatedra);
            this.Name = "FrmAgregarProfesor";
            this.Text = "FrmAgregarProfesor";
            this.Controls.SetChildIndex(this.lbl_nombre, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lbl_plataGastada, 0);
            this.Controls.SetChildIndex(this.lbl_prodComprados, 0);
            this.Controls.SetChildIndex(this.lbl_apellido, 0);
            this.Controls.SetChildIndex(this.lbl_cantCompras, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.txt_apellido, 0);
            this.Controls.SetChildIndex(this.nud_pComprados, 0);
            this.Controls.SetChildIndex(this.nud_plata, 0);
            this.Controls.SetChildIndex(this.nud_compras, 0);
            this.Controls.SetChildIndex(this.cmb_sexo, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.lbl_hCatedra, 0);
            this.Controls.SetChildIndex(this.nud_hCatedra, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nud_pComprados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_plata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_compras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hCatedra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_hCatedra;
        public System.Windows.Forms.NumericUpDown nud_hCatedra;
    }
}