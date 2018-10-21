namespace Archivos_de_texto_y_archivos_binarios
{
    partial class Archivos
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
            this.btnAgenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblVerifica = new System.Windows.Forms.Label();
            this.lblTamaño = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.lblTamañoMedida = new System.Windows.Forms.Label();
            this.lblAnchoMedida = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblAltoMedida = new System.Windows.Forms.Label();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.lblAlto = new System.Windows.Forms.Label();
            this.lblBitsMedida = new System.Windows.Forms.Label();
            this.txtBits = new System.Windows.Forms.TextBox();
            this.lblBits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgenda
            // 
            this.btnAgenda.AutoSize = true;
            this.btnAgenda.Location = new System.Drawing.Point(253, 249);
            this.btnAgenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(75, 35);
            this.btnAgenda.TabIndex = 0;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona un archivo BMP:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoSize = true;
            this.btnSeleccionar.Location = new System.Drawing.Point(223, 12);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(102, 30);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblVerifica
            // 
            this.lblVerifica.AutoSize = true;
            this.lblVerifica.Location = new System.Drawing.Point(12, 60);
            this.lblVerifica.Name = "lblVerifica";
            this.lblVerifica.Size = new System.Drawing.Size(184, 20);
            this.lblVerifica.TabIndex = 3;
            this.lblVerifica.Text = "Archivo BMP encontrado";
            this.lblVerifica.Visible = false;
            // 
            // lblTamaño
            // 
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Enabled = false;
            this.lblTamaño.Location = new System.Drawing.Point(12, 108);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(71, 20);
            this.lblTamaño.TabIndex = 5;
            this.lblTamaño.Text = "Tamaño:";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Enabled = false;
            this.txtTamaño.Location = new System.Drawing.Point(89, 105);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(118, 26);
            this.txtTamaño.TabIndex = 6;
            // 
            // lblTamañoMedida
            // 
            this.lblTamañoMedida.AutoSize = true;
            this.lblTamañoMedida.Enabled = false;
            this.lblTamañoMedida.Location = new System.Drawing.Point(211, 109);
            this.lblTamañoMedida.Name = "lblTamañoMedida";
            this.lblTamañoMedida.Size = new System.Drawing.Size(47, 20);
            this.lblTamañoMedida.TabIndex = 7;
            this.lblTamañoMedida.Text = "bytes";
            // 
            // lblAnchoMedida
            // 
            this.lblAnchoMedida.AutoSize = true;
            this.lblAnchoMedida.Enabled = false;
            this.lblAnchoMedida.Location = new System.Drawing.Point(181, 142);
            this.lblAnchoMedida.Name = "lblAnchoMedida";
            this.lblAnchoMedida.Size = new System.Drawing.Size(57, 20);
            this.lblAnchoMedida.TabIndex = 10;
            this.lblAnchoMedida.Text = "pixeles";
            // 
            // txtAncho
            // 
            this.txtAncho.Enabled = false;
            this.txtAncho.Location = new System.Drawing.Point(77, 138);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 26);
            this.txtAncho.TabIndex = 9;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Enabled = false;
            this.lblAncho.Location = new System.Drawing.Point(12, 140);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(59, 20);
            this.lblAncho.TabIndex = 8;
            this.lblAncho.Text = "Ancho:";
            // 
            // lblAltoMedida
            // 
            this.lblAltoMedida.AutoSize = true;
            this.lblAltoMedida.Enabled = false;
            this.lblAltoMedida.Location = new System.Drawing.Point(163, 174);
            this.lblAltoMedida.Name = "lblAltoMedida";
            this.lblAltoMedida.Size = new System.Drawing.Size(57, 20);
            this.lblAltoMedida.TabIndex = 13;
            this.lblAltoMedida.Text = "pixeles";
            // 
            // txtAlto
            // 
            this.txtAlto.Enabled = false;
            this.txtAlto.Location = new System.Drawing.Point(59, 170);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(100, 26);
            this.txtAlto.TabIndex = 12;
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.Enabled = false;
            this.lblAlto.Location = new System.Drawing.Point(12, 172);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(41, 20);
            this.lblAlto.TabIndex = 11;
            this.lblAlto.Text = "Alto:";
            // 
            // lblBitsMedida
            // 
            this.lblBitsMedida.AutoSize = true;
            this.lblBitsMedida.Enabled = false;
            this.lblBitsMedida.Location = new System.Drawing.Point(193, 206);
            this.lblBitsMedida.Name = "lblBitsMedida";
            this.lblBitsMedida.Size = new System.Drawing.Size(34, 20);
            this.lblBitsMedida.TabIndex = 16;
            this.lblBitsMedida.Text = "bits";
            // 
            // txtBits
            // 
            this.txtBits.Enabled = false;
            this.txtBits.Location = new System.Drawing.Point(120, 202);
            this.txtBits.Name = "txtBits";
            this.txtBits.Size = new System.Drawing.Size(69, 26);
            this.txtBits.TabIndex = 15;
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.Enabled = false;
            this.lblBits.Location = new System.Drawing.Point(12, 205);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(102, 20);
            this.lblBits.TabIndex = 14;
            this.lblBits.Text = "Bits por pixel:";
            // 
            // Archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 298);
            this.Controls.Add(this.lblBitsMedida);
            this.Controls.Add(this.txtBits);
            this.Controls.Add(this.lblBits);
            this.Controls.Add(this.lblAltoMedida);
            this.Controls.Add(this.txtAlto);
            this.Controls.Add(this.lblAlto);
            this.Controls.Add(this.lblAnchoMedida);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.lblTamañoMedida);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.lblTamaño);
            this.Controls.Add(this.lblVerifica);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgenda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Archivos";
            this.Text = "Archivos";
            this.Load += new System.EventHandler(this.Archivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblVerifica;
        private System.Windows.Forms.Label lblTamaño;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Label lblTamañoMedida;
        private System.Windows.Forms.Label lblAnchoMedida;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label lblAltoMedida;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.Label lblAlto;
        private System.Windows.Forms.Label lblBitsMedida;
        private System.Windows.Forms.TextBox txtBits;
        private System.Windows.Forms.Label lblBits;
    }
}

