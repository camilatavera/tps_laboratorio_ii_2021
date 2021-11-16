
namespace FrmAnalisisDeDatos
{
    partial class FrmAgregarEstudiante
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
            this.txt_promedio = new System.Windows.Forms.TextBox();
            this.lbl_promedio = new System.Windows.Forms.Label();
            this.nud_anio = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pComprados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_plata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_compras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_anio)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_guardar.Location = new System.Drawing.Point(263, 471);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cancel.Location = new System.Drawing.Point(61, 471);
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // cmb_sexo
            // 
            this.cmb_sexo.DataSource = new Bibloteca.Esexo[] {
        Bibloteca.Esexo.f,
        Bibloteca.Esexo.m};
           
            // 
            // txt_promedio
            // 
            this.txt_promedio.Location = new System.Drawing.Point(142, 374);
            this.txt_promedio.Name = "txt_promedio";
            this.txt_promedio.Size = new System.Drawing.Size(121, 23);
            this.txt_promedio.TabIndex = 33;
            // 
            // lbl_promedio
            // 
            this.lbl_promedio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_promedio.ForeColor = System.Drawing.Color.Coral;
            this.lbl_promedio.Location = new System.Drawing.Point(29, 372);
            this.lbl_promedio.Name = "lbl_promedio";
            this.lbl_promedio.Size = new System.Drawing.Size(99, 33);
            this.lbl_promedio.TabIndex = 34;
            this.lbl_promedio.Text = "Promedio";
            // 
            // nud_anio
            // 
            this.nud_anio.Location = new System.Drawing.Point(142, 417);
            this.nud_anio.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_anio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_anio.Name = "nud_anio";
            this.nud_anio.Size = new System.Drawing.Size(120, 23);
            this.nud_anio.TabIndex = 35;
            this.nud_anio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(20, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Año del curso";
            // 
            // FrmAgregarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_anio);
            this.Controls.Add(this.lbl_promedio);
            this.Controls.Add(this.txt_promedio);
            this.Name = "FrmAgregarEstudiante";
            this.Text = "Agregar Estudiante";
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
            this.Controls.SetChildIndex(this.txt_promedio, 0);
            this.Controls.SetChildIndex(this.lbl_promedio, 0);
            this.Controls.SetChildIndex(this.nud_anio, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nud_pComprados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_plata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_compras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_anio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_promedio;
        public System.Windows.Forms.Label lbl_promedio;
        public System.Windows.Forms.NumericUpDown nud_anio;
        public System.Windows.Forms.Label label1;
    }
}