namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.txt_n3 = new System.Windows.Forms.TextBox();
            this.txt_n4 = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota1";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(80, 256);
            this.btn_calcular.Margin = new System.Windows.Forms.Padding(4);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(100, 28);
            this.btn_calcular.TabIndex = 5;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota2";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(209, 256);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 28);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resultado";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(209, 52);
            this.txt_n1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(132, 22);
            this.txt_n1.TabIndex = 1;
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(209, 84);
            this.txt_n2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(132, 22);
            this.txt_n2.TabIndex = 2;
            // 
            // txt_n3
            // 
            this.txt_n3.Location = new System.Drawing.Point(209, 119);
            this.txt_n3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n3.Name = "txt_n3";
            this.txt_n3.Size = new System.Drawing.Size(132, 22);
            this.txt_n3.TabIndex = 3;
            // 
            // txt_n4
            // 
            this.txt_n4.Location = new System.Drawing.Point(209, 155);
            this.txt_n4.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n4.Name = "txt_n4";
            this.txt_n4.Size = new System.Drawing.Size(132, 22);
            this.txt_n4.TabIndex = 4;
            // 
            // txt_result
            // 
            this.txt_result.Enabled = false;
            this.txt_result.Location = new System.Drawing.Point(209, 191);
            this.txt_result.Margin = new System.Windows.Forms.Padding(4);
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(132, 22);
            this.txt_result.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_n4);
            this.Controls.Add(this.txt_n3);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.TextBox txt_n3;
        private System.Windows.Forms.TextBox txt_n4;
        private System.Windows.Forms.TextBox txt_result;
    }
}

