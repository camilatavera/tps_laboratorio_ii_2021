
namespace FrmAnalisisDeDatos
{
    partial class FrmAgregarOrdenanza
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
            this.lbl_turno = new System.Windows.Forms.Label();
            this.cmb_turno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pComprados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_plata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_compras)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Enabled = true;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_guardar.Location = new System.Drawing.Point(232, 447);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cancel.Location = new System.Drawing.Point(29, 447);
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // nud_compras
            // 
            this.nud_compras.Location = new System.Drawing.Point(142, 325);
            // 
            // cmb_sexo
            // 
            this.cmb_sexo.Location = new System.Drawing.Point(143, 188);
            // 
            // lbl_turno
            // 
            this.lbl_turno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_turno.ForeColor = System.Drawing.Color.Coral;
            this.lbl_turno.Location = new System.Drawing.Point(42, 373);
            this.lbl_turno.Name = "lbl_turno";
            this.lbl_turno.Size = new System.Drawing.Size(86, 37);
            this.lbl_turno.TabIndex = 33;
            this.lbl_turno.Text = "Turno";
            // 
            // cmb_turno
            // 
            this.cmb_turno.FormattingEnabled = true;
            this.cmb_turno.Location = new System.Drawing.Point(134, 375);
            this.cmb_turno.Name = "cmb_turno";
            this.cmb_turno.Size = new System.Drawing.Size(121, 23);
            this.cmb_turno.TabIndex = 34;
            // 
            // FrmAgregarOrdenanza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.cmb_turno);
            this.Controls.Add(this.lbl_turno);
            this.Name = "FrmAgregarOrdenanza";
            this.Text = "FrmAgregarOrdenanza";
            this.Load += new System.EventHandler(this.FrmAgregarOrdenanza_Load);
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
            this.Controls.SetChildIndex(this.lbl_turno, 0);
            this.Controls.SetChildIndex(this.cmb_turno, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nud_pComprados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_plata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_compras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_turno;
        private System.Windows.Forms.ComboBox cmb_turno;
    }
}