namespace _5_UNFV.PF.UI
{
    partial class frmRegistraAlumno
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPractica4 = new System.Windows.Forms.TextBox();
            this.txtPractica3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPractica2 = new System.Windows.Forms.TextBox();
            this.txtPractica1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPromedioFinal = new System.Windows.Forms.Label();
            this.lblPromedioPracticas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(189, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(28, 21);
            this.btnBuscar.TabIndex = 111;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(109, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(74, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(81, 13);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Ingrese Código:";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(20, 98);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkEstado.Size = new System.Drawing.Size(59, 17);
            this.chkEstado.TabIndex = 110;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(109, 74);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(215, 20);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(109, 48);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(215, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.chkEstado);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 124);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPractica4);
            this.groupBox2.Controls.Add(this.txtPractica3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPractica2);
            this.groupBox2.Controls.Add(this.txtPractica1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(21, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 116);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prácticas";
            // 
            // txtPractica4
            // 
            this.txtPractica4.Location = new System.Drawing.Point(236, 76);
            this.txtPractica4.Name = "txtPractica4";
            this.txtPractica4.Size = new System.Drawing.Size(43, 20);
            this.txtPractica4.TabIndex = 5;
            // 
            // txtPractica3
            // 
            this.txtPractica3.Location = new System.Drawing.Point(236, 23);
            this.txtPractica3.Name = "txtPractica3";
            this.txtPractica3.Size = new System.Drawing.Size(43, 20);
            this.txtPractica3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Practica4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Practica3:";
            // 
            // txtPractica2
            // 
            this.txtPractica2.Location = new System.Drawing.Point(78, 77);
            this.txtPractica2.Name = "txtPractica2";
            this.txtPractica2.Size = new System.Drawing.Size(43, 20);
            this.txtPractica2.TabIndex = 4;
            // 
            // txtPractica1
            // 
            this.txtPractica1.Location = new System.Drawing.Point(80, 27);
            this.txtPractica1.Name = "txtPractica1";
            this.txtPractica1.Size = new System.Drawing.Size(43, 20);
            this.txtPractica1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Practica2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Practica1:";
            // 
            // txtParcial
            // 
            this.txtParcial.Location = new System.Drawing.Point(78, 32);
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(43, 20);
            this.txtParcial.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Exa. Parcial:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.btnRegistrar);
            this.groupBox5.Controls.Add(this.btnCerrar);
            this.groupBox5.Location = new System.Drawing.Point(21, 411);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(330, 54);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(9, 19);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(90, 23);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(206, 19);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(113, 23);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPromedioFinal);
            this.groupBox4.Controls.Add(this.lblPromedioPracticas);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(21, 328);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 77);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Promedios";
            // 
            // lblPromedioFinal
            // 
            this.lblPromedioFinal.AutoSize = true;
            this.lblPromedioFinal.Location = new System.Drawing.Point(267, 34);
            this.lblPromedioFinal.Name = "lblPromedioFinal";
            this.lblPromedioFinal.Size = new System.Drawing.Size(20, 16);
            this.lblPromedioFinal.TabIndex = 6;
            this.lblPromedioFinal.Text = "---";
            // 
            // lblPromedioPracticas
            // 
            this.lblPromedioPracticas.AutoSize = true;
            this.lblPromedioPracticas.Location = new System.Drawing.Point(114, 34);
            this.lblPromedioPracticas.Name = "lblPromedioPracticas";
            this.lblPromedioPracticas.Size = new System.Drawing.Size(20, 16);
            this.lblPromedioPracticas.TabIndex = 5;
            this.lblPromedioPracticas.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Promedio Final";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Prom. Prácticas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Exa. Final";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFinal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtParcial);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(21, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 58);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exámenes";
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(236, 32);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(43, 20);
            this.txtFinal.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRegistraAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmRegistraAlumno";
            this.Text = "frmRegistraAlumno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPractica4;
        private System.Windows.Forms.TextBox txtPractica3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPractica2;
        private System.Windows.Forms.TextBox txtPractica1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblPromedioFinal;
        private System.Windows.Forms.Label lblPromedioPracticas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button button1;
    }
}