
namespace FrmAnalisisDeDatos
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_importar = new System.Windows.Forms.Button();
            this.btn_exportarJson = new System.Windows.Forms.Button();
            this.btn_analisis = new System.Windows.Forms.Button();
            this.btn_agregarDatos = new System.Windows.Forms.Button();
            this.btn_comparar = new System.Windows.Forms.Button();
            this.btn_exportarXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_importar
            // 
            this.btn_importar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_importar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_importar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_importar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_importar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_importar.ForeColor = System.Drawing.Color.Coral;
            this.btn_importar.Location = new System.Drawing.Point(371, 54);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(254, 69);
            this.btn_importar.TabIndex = 23;
            this.btn_importar.Text = "Importar datos (xml)";
            this.btn_importar.UseVisualStyleBackColor = true;
            this.btn_importar.Click += new System.EventHandler(this.btn_importar_Click);
            // 
            // btn_exportarJson
            // 
            this.btn_exportarJson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exportarJson.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_exportarJson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_exportarJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportarJson.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exportarJson.ForeColor = System.Drawing.Color.Coral;
            this.btn_exportarJson.Location = new System.Drawing.Point(57, 306);
            this.btn_exportarJson.Name = "btn_exportarJson";
            this.btn_exportarJson.Size = new System.Drawing.Size(258, 69);
            this.btn_exportarJson.TabIndex = 24;
            this.btn_exportarJson.Text = "Exportar datos generales (Json)";
            this.btn_exportarJson.UseVisualStyleBackColor = true;
            this.btn_exportarJson.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // btn_analisis
            // 
            this.btn_analisis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_analisis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_analisis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_analisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_analisis.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_analisis.ForeColor = System.Drawing.Color.Coral;
            this.btn_analisis.Location = new System.Drawing.Point(57, 174);
            this.btn_analisis.Name = "btn_analisis";
            this.btn_analisis.Size = new System.Drawing.Size(254, 69);
            this.btn_analisis.TabIndex = 25;
            this.btn_analisis.Text = "Analisis de datos";
            this.btn_analisis.UseVisualStyleBackColor = true;
            this.btn_analisis.Click += new System.EventHandler(this.btn_analisis_Click);
            // 
            // btn_agregarDatos
            // 
            this.btn_agregarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_agregarDatos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_agregarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_agregarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarDatos.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarDatos.ForeColor = System.Drawing.Color.Coral;
            this.btn_agregarDatos.Location = new System.Drawing.Point(57, 54);
            this.btn_agregarDatos.Name = "btn_agregarDatos";
            this.btn_agregarDatos.Size = new System.Drawing.Size(245, 69);
            this.btn_agregarDatos.TabIndex = 26;
            this.btn_agregarDatos.Text = "Agregar datos";
            this.btn_agregarDatos.UseVisualStyleBackColor = true;
            this.btn_agregarDatos.Click += new System.EventHandler(this.btn_agregarDatos_Click);
            // 
            // btn_comparar
            // 
            this.btn_comparar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_comparar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_comparar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_comparar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comparar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_comparar.ForeColor = System.Drawing.Color.Coral;
            this.btn_comparar.Location = new System.Drawing.Point(371, 174);
            this.btn_comparar.Name = "btn_comparar";
            this.btn_comparar.Size = new System.Drawing.Size(254, 69);
            this.btn_comparar.TabIndex = 27;
            this.btn_comparar.Text = "Comparar dos grupos";
            this.btn_comparar.UseVisualStyleBackColor = true;
            this.btn_comparar.Click += new System.EventHandler(this.btn_comparar_Click);
            // 
            // btn_exportarXml
            // 
            this.btn_exportarXml.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exportarXml.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_exportarXml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_exportarXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportarXml.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exportarXml.ForeColor = System.Drawing.Color.Coral;
            this.btn_exportarXml.Location = new System.Drawing.Point(371, 306);
            this.btn_exportarXml.Name = "btn_exportarXml";
            this.btn_exportarXml.Size = new System.Drawing.Size(258, 69);
            this.btn_exportarXml.TabIndex = 28;
            this.btn_exportarXml.Text = "Exportar datos por grupos (xml)";
            this.btn_exportarXml.UseVisualStyleBackColor = true;
            this.btn_exportarXml.Click += new System.EventHandler(this.btn_exportarXml_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(728, 496);
            this.Controls.Add(this.btn_exportarXml);
            this.Controls.Add(this.btn_comparar);
            this.Controls.Add(this.btn_agregarDatos);
            this.Controls.Add(this.btn_analisis);
            this.Controls.Add(this.btn_exportarJson);
            this.Controls.Add(this.btn_importar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_importar;
        public System.Windows.Forms.Button btn_exportarJson;
        public System.Windows.Forms.Button btn_analisis;
        public System.Windows.Forms.Button btn_agregarDatos;
        public System.Windows.Forms.Button btn_comparar;
        public System.Windows.Forms.Button btn_exportarXml;
    }
}

