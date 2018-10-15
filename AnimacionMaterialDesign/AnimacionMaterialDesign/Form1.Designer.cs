namespace AnimacionMaterialDesign
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmpInteractivoOri3 = new AnimacionMaterialDesign.Componentes.CmpInteractivoOri(this.components);
            this.cmpInteractivoOri2 = new AnimacionMaterialDesign.Componentes.CmpInteractivoOri(this.components);
            this.cmpInteractivoOri1 = new AnimacionMaterialDesign.Componentes.CmpInteractivoOri(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmpInteractivoOri3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmpInteractivoOri2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmpInteractivoOri1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Probando movimiento acelerado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(62, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opcion #1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Opcion #2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(118)))));
            this.label4.Location = new System.Drawing.Point(276, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Opcion #3";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(65, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ease In";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ease Out";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ease InOut";
            // 
            // cmpInteractivoOri3
            // 
            this.cmpInteractivoOri3.Image = global::AnimacionMaterialDesign.Properties.Resources.database;
            this.cmpInteractivoOri3.Location = new System.Drawing.Point(131, 173);
            this.cmpInteractivoOri3.Name = "cmpInteractivoOri3";
            this.cmpInteractivoOri3.Size = new System.Drawing.Size(48, 48);
            this.cmpInteractivoOri3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cmpInteractivoOri3.TabIndex = 11;
            this.cmpInteractivoOri3.TabStop = false;
            this.cmpInteractivoOri3.Tipo = AnimacionMaterialDesign.Componentes.CmpInteractivoOri.tipoMovimiento.CubicOut;
            // 
            // cmpInteractivoOri2
            // 
            this.cmpInteractivoOri2.Image = global::AnimacionMaterialDesign.Properties.Resources.arrow_right_bold_circle;
            this.cmpInteractivoOri2.Location = new System.Drawing.Point(131, 84);
            this.cmpInteractivoOri2.Name = "cmpInteractivoOri2";
            this.cmpInteractivoOri2.Size = new System.Drawing.Size(48, 48);
            this.cmpInteractivoOri2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cmpInteractivoOri2.TabIndex = 10;
            this.cmpInteractivoOri2.TabStop = false;
            this.cmpInteractivoOri2.Tipo = AnimacionMaterialDesign.Componentes.CmpInteractivoOri.tipoMovimiento.CubicIn;
            // 
            // cmpInteractivoOri1
            // 
            this.cmpInteractivoOri1.Image = global::AnimacionMaterialDesign.Properties.Resources.alert_box;
            this.cmpInteractivoOri1.Location = new System.Drawing.Point(131, 261);
            this.cmpInteractivoOri1.Name = "cmpInteractivoOri1";
            this.cmpInteractivoOri1.Size = new System.Drawing.Size(48, 48);
            this.cmpInteractivoOri1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cmpInteractivoOri1.TabIndex = 5;
            this.cmpInteractivoOri1.TabStop = false;
            this.cmpInteractivoOri1.Tipo = AnimacionMaterialDesign.Componentes.CmpInteractivoOri.tipoMovimiento.CubicInOut;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnimacionMaterialDesign.Properties.Resources.a4ebc70bd6_Owl;
            this.pictureBox1.Location = new System.Drawing.Point(248, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 469);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmpInteractivoOri3);
            this.Controls.Add(this.cmpInteractivoOri2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmpInteractivoOri1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cmpInteractivoOri3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmpInteractivoOri2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmpInteractivoOri1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Componentes.CmpInteractivoOri cmpInteractivoOri1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Componentes.CmpInteractivoOri cmpInteractivoOri2;
        private Componentes.CmpInteractivoOri cmpInteractivoOri3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

