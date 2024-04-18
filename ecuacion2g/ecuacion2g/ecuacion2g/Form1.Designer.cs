namespace ecuacion2g
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ecuacion de segundo grado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "El resultado de la ecuacion de segundo grado es:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "ax^2 + bx + c=0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(154, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Enabled = false;
            this.txtresultado.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(498, 258);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(165, 32);
            this.txtresultado.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(345, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(534, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingrese el valor de b:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingrese el valor de a:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ingrese el valor de c:";
            // 
            // txtc
            // 
            this.txtc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc.Location = new System.Drawing.Point(255, 208);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 32);
            this.txtc.TabIndex = 10;
            // 
            // txtb
            // 
            this.txtb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb.Location = new System.Drawing.Point(255, 166);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 32);
            this.txtb.TabIndex = 11;
            // 
            // txta
            // 
            this.txta.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txta.Location = new System.Drawing.Point(255, 125);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 32);
            this.txta.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
    }
}

