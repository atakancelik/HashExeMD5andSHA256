namespace asguardCollector
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
            this.btn_select = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.txt_a1 = new System.Windows.Forms.TextBox();
            this.txt_a2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_a3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(568, 42);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "Dosya Seç";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(30, 45);
            this.txt_path.Name = "txt_path";
            this.txt_path.ReadOnly = true;
            this.txt_path.Size = new System.Drawing.Size(532, 20);
            this.txt_path.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lütfen bir .exe seçin";
            // 
            // btn_ask
            // 
            this.btn_ask.Location = new System.Drawing.Point(30, 71);
            this.btn_ask.Name = "btn_ask";
            this.btn_ask.Size = new System.Drawing.Size(137, 23);
            this.btn_ask.TabIndex = 0;
            this.btn_ask.Text = "Dosyayı Asguard\'a sor";
            this.btn_ask.UseVisualStyleBackColor = true;
            this.btn_ask.Click += new System.EventHandler(this.btn_ask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_a3);
            this.groupBox1.Controls.Add(this.txt_a2);
            this.groupBox1.Controls.Add(this.txt_a1);
            this.groupBox1.Controls.Add(this.btn_copy);
            this.groupBox1.Location = new System.Drawing.Point(30, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asguard Cevap";
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(6, 92);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(267, 23);
            this.btn_copy.TabIndex = 0;
            this.btn_copy.Text = "Cevap kopyala";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // txt_a1
            // 
            this.txt_a1.Location = new System.Drawing.Point(52, 22);
            this.txt_a1.Name = "txt_a1";
            this.txt_a1.ReadOnly = true;
            this.txt_a1.Size = new System.Drawing.Size(221, 20);
            this.txt_a1.TabIndex = 1;
            // 
            // txt_a2
            // 
            this.txt_a2.Location = new System.Drawing.Point(52, 44);
            this.txt_a2.Name = "txt_a2";
            this.txt_a2.ReadOnly = true;
            this.txt_a2.Size = new System.Drawing.Size(221, 20);
            this.txt_a2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "[A:1]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "[A:2]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "[A:3]";
            // 
            // txt_a3
            // 
            this.txt_a3.Location = new System.Drawing.Point(52, 66);
            this.txt_a3.Name = "txt_a3";
            this.txt_a3.ReadOnly = true;
            this.txt_a3.Size = new System.Drawing.Size(221, 20);
            this.txt_a3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 260);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_ask);
            this.Controls.Add(this.btn_select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asguard Collector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_a3;
        private System.Windows.Forms.TextBox txt_a2;
        private System.Windows.Forms.TextBox txt_a1;
        private System.Windows.Forms.Button btn_copy;
    }
}

