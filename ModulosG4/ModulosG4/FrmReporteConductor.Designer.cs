namespace ModulosG4
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ci = new System.Windows.Forms.TextBox();
            this.txt_nombreCompleto = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rb1_inconveniente = new System.Windows.Forms.RadioButton();
            this.rb2_inconveniente = new System.Windows.Forms.RadioButton();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_dinComb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rb1_comportamiento = new System.Windows.Forms.RadioButton();
            this.rb2_comportamiento = new System.Windows.Forms.RadioButton();
            this.rb3_comportamiento = new System.Windows.Forms.RadioButton();
            this.rb4_comportamiento = new System.Windows.Forms.RadioButton();
            this.rb5_comportamiento = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(132, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTE DE VIAJE COMPLETADO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_ci, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_nombreCompleto, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_descripcion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_dinComb, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.39759F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.60241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 396);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(2, 259);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cantidad de dinero gastada en combustible";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(2, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descripción del incoveniente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cédula del Conductor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(2, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombres Completos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(2, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "¿El vehículo presentó inconvenientes durante el viaje? ";
            // 
            // txt_ci
            // 
            this.txt_ci.Location = new System.Drawing.Point(370, 2);
            this.txt_ci.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ci.Multiline = true;
            this.txt_ci.Name = "txt_ci";
            this.txt_ci.Size = new System.Drawing.Size(214, 25);
            this.txt_ci.TabIndex = 3;
            // 
            // txt_nombreCompleto
            // 
            this.txt_nombreCompleto.Location = new System.Drawing.Point(370, 45);
            this.txt_nombreCompleto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombreCompleto.Multiline = true;
            this.txt_nombreCompleto.Name = "txt_nombreCompleto";
            this.txt_nombreCompleto.Size = new System.Drawing.Size(214, 26);
            this.txt_nombreCompleto.TabIndex = 4;
            this.txt_nombreCompleto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rb1_inconveniente, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rb2_inconveniente, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(370, 89);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(214, 37);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // rb1_inconveniente
            // 
            this.rb1_inconveniente.AutoSize = true;
            this.rb1_inconveniente.Location = new System.Drawing.Point(2, 2);
            this.rb1_inconveniente.Margin = new System.Windows.Forms.Padding(2);
            this.rb1_inconveniente.Name = "rb1_inconveniente";
            this.rb1_inconveniente.Size = new System.Drawing.Size(36, 17);
            this.rb1_inconveniente.TabIndex = 0;
            this.rb1_inconveniente.TabStop = true;
            this.rb1_inconveniente.Text = "Sí";
            this.rb1_inconveniente.UseVisualStyleBackColor = true;
            this.rb1_inconveniente.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb2_inconveniente
            // 
            this.rb2_inconveniente.AutoSize = true;
            this.rb2_inconveniente.Location = new System.Drawing.Point(109, 2);
            this.rb2_inconveniente.Margin = new System.Windows.Forms.Padding(2);
            this.rb2_inconveniente.Name = "rb2_inconveniente";
            this.rb2_inconveniente.Size = new System.Drawing.Size(39, 17);
            this.rb2_inconveniente.TabIndex = 1;
            this.rb2_inconveniente.TabStop = true;
            this.rb2_inconveniente.Text = "No";
            this.rb2_inconveniente.UseVisualStyleBackColor = true;
            this.rb2_inconveniente.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(370, 143);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(214, 114);
            this.txt_descripcion.TabIndex = 6;
            this.txt_descripcion.Tag = "";
            this.txt_descripcion.Text = "Solo sí existió inconvenientes, describalos";
            // 
            // txt_dinComb
            // 
            this.txt_dinComb.Location = new System.Drawing.Point(370, 261);
            this.txt_dinComb.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dinComb.Multiline = true;
            this.txt_dinComb.Name = "txt_dinComb";
            this.txt_dinComb.Size = new System.Drawing.Size(60, 19);
            this.txt_dinComb.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(2, 303);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Califique el comportamiento de el/los pasajeros";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.rb1_comportamiento, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rb2_comportamiento, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rb3_comportamiento, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.rb4_comportamiento, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.rb5_comportamiento, 4, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(370, 305);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(214, 36);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // rb1_comportamiento
            // 
            this.rb1_comportamiento.AutoSize = true;
            this.rb1_comportamiento.Location = new System.Drawing.Point(2, 2);
            this.rb1_comportamiento.Margin = new System.Windows.Forms.Padding(2);
            this.rb1_comportamiento.Name = "rb1_comportamiento";
            this.rb1_comportamiento.Size = new System.Drawing.Size(31, 17);
            this.rb1_comportamiento.TabIndex = 0;
            this.rb1_comportamiento.TabStop = true;
            this.rb1_comportamiento.Text = "0";
            this.rb1_comportamiento.UseVisualStyleBackColor = true;
            this.rb1_comportamiento.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rb2_comportamiento
            // 
            this.rb2_comportamiento.AutoSize = true;
            this.rb2_comportamiento.Location = new System.Drawing.Point(44, 2);
            this.rb2_comportamiento.Margin = new System.Windows.Forms.Padding(2);
            this.rb2_comportamiento.Name = "rb2_comportamiento";
            this.rb2_comportamiento.Size = new System.Drawing.Size(37, 17);
            this.rb2_comportamiento.TabIndex = 1;
            this.rb2_comportamiento.TabStop = true;
            this.rb2_comportamiento.Text = "25";
            this.rb2_comportamiento.UseVisualStyleBackColor = true;
            // 
            // rb3_comportamiento
            // 
            this.rb3_comportamiento.AutoSize = true;
            this.rb3_comportamiento.Location = new System.Drawing.Point(86, 2);
            this.rb3_comportamiento.Margin = new System.Windows.Forms.Padding(2);
            this.rb3_comportamiento.Name = "rb3_comportamiento";
            this.rb3_comportamiento.Size = new System.Drawing.Size(37, 17);
            this.rb3_comportamiento.TabIndex = 2;
            this.rb3_comportamiento.TabStop = true;
            this.rb3_comportamiento.Text = "50";
            this.rb3_comportamiento.UseVisualStyleBackColor = true;
            this.rb3_comportamiento.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rb4_comportamiento
            // 
            this.rb4_comportamiento.AutoSize = true;
            this.rb4_comportamiento.Location = new System.Drawing.Point(128, 2);
            this.rb4_comportamiento.Margin = new System.Windows.Forms.Padding(2);
            this.rb4_comportamiento.Name = "rb4_comportamiento";
            this.rb4_comportamiento.Size = new System.Drawing.Size(37, 17);
            this.rb4_comportamiento.TabIndex = 3;
            this.rb4_comportamiento.TabStop = true;
            this.rb4_comportamiento.Text = "75";
            this.rb4_comportamiento.UseVisualStyleBackColor = true;
            // 
            // rb5_comportamiento
            // 
            this.rb5_comportamiento.AutoSize = true;
            this.rb5_comportamiento.Location = new System.Drawing.Point(170, 2);
            this.rb5_comportamiento.Margin = new System.Windows.Forms.Padding(2);
            this.rb5_comportamiento.Name = "rb5_comportamiento";
            this.rb5_comportamiento.Size = new System.Drawing.Size(42, 17);
            this.rb5_comportamiento.TabIndex = 4;
            this.rb5_comportamiento.TabStop = true;
            this.rb5_comportamiento.Text = "100";
            this.rb5_comportamiento.UseVisualStyleBackColor = true;
            this.rb5_comportamiento.CheckedChanged += new System.EventHandler(this.rb5_comportamiento_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 346);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 346);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 474);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ci;
        private System.Windows.Forms.TextBox txt_nombreCompleto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rb1_inconveniente;
        private System.Windows.Forms.RadioButton rb2_inconveniente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_dinComb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rb1_comportamiento;
        private System.Windows.Forms.RadioButton rb2_comportamiento;
        private System.Windows.Forms.RadioButton rb3_comportamiento;
        private System.Windows.Forms.RadioButton rb4_comportamiento;
        private System.Windows.Forms.RadioButton rb5_comportamiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}