
namespace prInteresCompuesto
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.txtrazon = new System.Windows.Forms.TextBox();
            this.txtcapital = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmontofinal = new System.Windows.Forms.TextBox();
            this.txttotalinteres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.txttiempo);
            this.groupBox1.Controls.Add(this.txtrazon);
            this.groupBox1.Controls.Add(this.txtcapital);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(41, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interes";
      
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Green;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(323, 182);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(139, 47);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.Green;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btnnuevo.ForeColor = System.Drawing.Color.White;
            this.btnnuevo.Location = new System.Drawing.Point(178, 182);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(139, 47);
            this.btnnuevo.TabIndex = 7;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click_1);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Green;
            this.btncalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalcular.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btncalcular.ForeColor = System.Drawing.Color.White;
            this.btncalcular.Location = new System.Drawing.Point(33, 182);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(139, 47);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txttiempo
            // 
            this.txttiempo.BackColor = System.Drawing.Color.SeaShell;
            this.txttiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttiempo.Location = new System.Drawing.Point(108, 132);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.PlaceholderText = "Periodo de tiempo en relación a la tasa de interés";
            this.txttiempo.Size = new System.Drawing.Size(302, 23);
            this.txttiempo.TabIndex = 5;
   
            // 
            // txtrazon
            // 
            this.txtrazon.BackColor = System.Drawing.Color.SeaShell;
            this.txtrazon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrazon.Location = new System.Drawing.Point(108, 81);
            this.txtrazon.Name = "txtrazon";
            this.txtrazon.PlaceholderText = "Tasa en formato decimal (por ejemplo, 0.05 para el 5%)";
            this.txtrazon.Size = new System.Drawing.Size(302, 23);
            this.txtrazon.TabIndex = 4;

            // 
            // txtcapital
            // 
            this.txtcapital.BackColor = System.Drawing.Color.SeaShell;
            this.txtcapital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcapital.Location = new System.Drawing.Point(108, 33);
            this.txtcapital.Name = "txtcapital";
            this.txtcapital.PlaceholderText = "Cantidad a invertir";
            this.txtcapital.Size = new System.Drawing.Size(302, 23);
            this.txtcapital.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(30, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tiempo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(41, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Razón:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(34, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Capital:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.txtmontofinal);
            this.groupBox2.Controls.Add(this.txttotalinteres);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(41, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtmontofinal
            // 
            this.txtmontofinal.BackColor = System.Drawing.Color.SeaShell;
            this.txtmontofinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmontofinal.Location = new System.Drawing.Point(277, 68);
            this.txtmontofinal.Name = "txtmontofinal";
            this.txtmontofinal.Size = new System.Drawing.Size(185, 23);
            this.txtmontofinal.TabIndex = 7;
            // 
            // txttotalinteres
            // 
            this.txttotalinteres.BackColor = System.Drawing.Color.SeaShell;
            this.txttotalinteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalinteres.Location = new System.Drawing.Point(39, 68);
            this.txttotalinteres.Name = "txttotalinteres";
            this.txttotalinteres.Size = new System.Drawing.Size(185, 23);
            this.txttotalinteres.TabIndex = 6;

            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(251, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Monto final  (Capital + Interés):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(64, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total de Interés:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMULARIO CALCULAR INTERES COMPUESTO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttiempo;
        private System.Windows.Forms.TextBox txtrazon;
        private System.Windows.Forms.TextBox txtcapital;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtmontofinal;
        private System.Windows.Forms.TextBox txttotalinteres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsalir;
    }
}

