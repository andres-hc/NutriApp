namespace NutriApp
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCalculo = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cefalicoTxt = new System.Windows.Forms.TextBox();
            this.cinturaTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sexoCbx = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tallaTxt = new System.Windows.Forms.TextBox();
            this.pesoTxt = new System.Windows.Forms.TextBox();
            this.rutTxt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plieguesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.plieguesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label14 = new System.Windows.Forms.Label();
            this.diagCinturaTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.estadoTxt = new System.Windows.Forms.TextBox();
            this.imcTxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCalculo
            // 
            this.BtnCalculo.Location = new System.Drawing.Point(560, 281);
            this.BtnCalculo.Name = "BtnCalculo";
            this.BtnCalculo.Size = new System.Drawing.Size(97, 30);
            this.BtnCalculo.TabIndex = 60;
            this.BtnCalculo.Text = "Calcular";
            this.BtnCalculo.UseVisualStyleBackColor = true;
            this.BtnCalculo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(411, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 17);
            this.label13.TabIndex = 59;
            // 
            // cefalicoTxt
            // 
            this.cefalicoTxt.Location = new System.Drawing.Point(536, 215);
            this.cefalicoTxt.Name = "cefalicoTxt";
            this.cefalicoTxt.Size = new System.Drawing.Size(121, 22);
            this.cefalicoTxt.TabIndex = 57;
            // 
            // cinturaTxt
            // 
            this.cinturaTxt.Location = new System.Drawing.Point(536, 187);
            this.cinturaTxt.Name = "cinturaTxt";
            this.cinturaTxt.Size = new System.Drawing.Size(121, 22);
            this.cinturaTxt.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(437, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "P. Cefalico";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "C. Cintura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(435, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 25);
            this.label9.TabIndex = 52;
            this.label9.Text = "Datos Antropométricos";
            // 
            // sexoCbx
            // 
            this.sexoCbx.DisplayMember = "--Seleccionar--";
            this.sexoCbx.FormattingEnabled = true;
            this.sexoCbx.Items.AddRange(new object[] {
            "--Seleccionar--",
            "Masculino",
            "Femenino"});
            this.sexoCbx.Location = new System.Drawing.Point(196, 243);
            this.sexoCbx.Name = "sexoCbx";
            this.sexoCbx.Size = new System.Drawing.Size(137, 24);
            this.sexoCbx.TabIndex = 51;
            this.sexoCbx.Tag = "";
            this.sexoCbx.Text = "--Seleccionar--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "Talla";
            // 
            // tallaTxt
            // 
            this.tallaTxt.Location = new System.Drawing.Point(536, 159);
            this.tallaTxt.Name = "tallaTxt";
            this.tallaTxt.Size = new System.Drawing.Size(121, 22);
            this.tallaTxt.TabIndex = 48;
            // 
            // pesoTxt
            // 
            this.pesoTxt.Location = new System.Drawing.Point(536, 131);
            this.pesoTxt.Name = "pesoTxt";
            this.pesoTxt.Size = new System.Drawing.Size(121, 22);
            this.pesoTxt.TabIndex = 47;
            // 
            // rutTxt
            // 
            this.rutTxt.Location = new System.Drawing.Point(196, 215);
            this.rutTxt.Name = "rutTxt";
            this.rutTxt.Size = new System.Drawing.Size(137, 22);
            this.rutTxt.TabIndex = 46;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(196, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 22);
            this.textBox3.TabIndex = 45;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(196, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 22);
            this.textBox2.TabIndex = 44;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Rut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Apellido Paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Datos Personales";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plieguesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1092, 28);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plieguesToolStripMenuItem1
            // 
            this.plieguesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plieguesToolStripMenuItem2});
            this.plieguesToolStripMenuItem1.Name = "plieguesToolStripMenuItem1";
            this.plieguesToolStripMenuItem1.Size = new System.Drawing.Size(122, 24);
            this.plieguesToolStripMenuItem1.Text = "Otras Opciones";
            // 
            // plieguesToolStripMenuItem2
            // 
            this.plieguesToolStripMenuItem2.Name = "plieguesToolStripMenuItem2";
            this.plieguesToolStripMenuItem2.Size = new System.Drawing.Size(139, 26);
            this.plieguesToolStripMenuItem2.Text = "Pliegues";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(779, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 25);
            this.label14.TabIndex = 62;
            this.label14.Text = "Calculos";
            // 
            // diagCinturaTxt
            // 
            this.diagCinturaTxt.Location = new System.Drawing.Point(923, 187);
            this.diagCinturaTxt.Name = "diagCinturaTxt";
            this.diagCinturaTxt.ReadOnly = true;
            this.diagCinturaTxt.Size = new System.Drawing.Size(121, 22);
            this.diagCinturaTxt.TabIndex = 68;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(781, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 17);
            this.label15.TabIndex = 67;
            this.label15.Text = "C. Cintura";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(781, 159);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 17);
            this.label16.TabIndex = 66;
            this.label16.Text = "Estado Nutricional";
            // 
            // estadoTxt
            // 
            this.estadoTxt.Location = new System.Drawing.Point(923, 159);
            this.estadoTxt.Name = "estadoTxt";
            this.estadoTxt.ReadOnly = true;
            this.estadoTxt.Size = new System.Drawing.Size(121, 22);
            this.estadoTxt.TabIndex = 65;
            // 
            // imcTxt
            // 
            this.imcTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imcTxt.Location = new System.Drawing.Point(923, 131);
            this.imcTxt.Name = "imcTxt";
            this.imcTxt.ReadOnly = true;
            this.imcTxt.Size = new System.Drawing.Size(121, 22);
            this.imcTxt.TabIndex = 64;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(781, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 17);
            this.label17.TabIndex = 63;
            this.label17.Text = "IMC";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(110, 346);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 69;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.diagCinturaTxt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.estadoTxt);
            this.Controls.Add(this.imcTxt);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BtnCalculo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cefalicoTxt);
            this.Controls.Add(this.cinturaTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sexoCbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tallaTxt);
            this.Controls.Add(this.pesoTxt);
            this.Controls.Add(this.rutTxt);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NutriApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCalculo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cefalicoTxt;
        private System.Windows.Forms.TextBox cinturaTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sexoCbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tallaTxt;
        private System.Windows.Forms.TextBox pesoTxt;
        private System.Windows.Forms.TextBox rutTxt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plieguesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem plieguesToolStripMenuItem2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox diagCinturaTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox estadoTxt;
        private System.Windows.Forms.TextBox imcTxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

