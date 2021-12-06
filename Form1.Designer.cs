namespace CurrencyConverter3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.from_comboBox1 = new System.Windows.Forms.ComboBox();
            this.to_comboBox2 = new System.Windows.Forms.ComboBox();
            this.conv_button1 = new System.Windows.Forms.Button();
            this.display_txt = new System.Windows.Forms.Label();
            this.upd_btn = new System.Windows.Forms.Button();
            this.cur_label = new System.Windows.Forms.Label();
            this.pre_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convertfrom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "convertto";
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(113, 39);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(121, 20);
            this.amount_txt.TabIndex = 3;
            // 
            // from_comboBox1
            // 
            this.from_comboBox1.FormattingEnabled = true;
            this.from_comboBox1.Items.AddRange(new object[] {
            "Rupees",
            "Cdollars",
            "Dollar",
            "Euro",
            "Liras",
            "Yuan",
            "Riyal",
            "Pounds",
            "Dinar",
            "Dirham"});
            this.from_comboBox1.Location = new System.Drawing.Point(113, 78);
            this.from_comboBox1.Name = "from_comboBox1";
            this.from_comboBox1.Size = new System.Drawing.Size(121, 21);
            this.from_comboBox1.TabIndex = 4;
            // 
            // to_comboBox2
            // 
            this.to_comboBox2.FormattingEnabled = true;
            this.to_comboBox2.Items.AddRange(new object[] {
            "Rupees",
            "Cdollars",
            "Dollar",
            "Euro",
            "Liras",
            "Yuan",
            "Riyal",
            "Pounds",
            "Dinar",
            "Dirham"});
            this.to_comboBox2.Location = new System.Drawing.Point(113, 113);
            this.to_comboBox2.Name = "to_comboBox2";
            this.to_comboBox2.Size = new System.Drawing.Size(121, 21);
            this.to_comboBox2.TabIndex = 5;
            // 
            // conv_button1
            // 
            this.conv_button1.Location = new System.Drawing.Point(113, 164);
            this.conv_button1.Name = "conv_button1";
            this.conv_button1.Size = new System.Drawing.Size(75, 23);
            this.conv_button1.TabIndex = 6;
            this.conv_button1.Text = "Convert";
            this.conv_button1.UseVisualStyleBackColor = true;
            this.conv_button1.Click += new System.EventHandler(this.conv_button1_Click);
            // 
            // display_txt
            // 
            this.display_txt.AutoSize = true;
            this.display_txt.Location = new System.Drawing.Point(293, 173);
            this.display_txt.Name = "display_txt";
            this.display_txt.Size = new System.Drawing.Size(86, 13);
            this.display_txt.TabIndex = 7;
            this.display_txt.Text = "Converted Value";
            // 
            // upd_btn
            // 
            this.upd_btn.Location = new System.Drawing.Point(113, 213);
            this.upd_btn.Name = "upd_btn";
            this.upd_btn.Size = new System.Drawing.Size(75, 23);
            this.upd_btn.TabIndex = 8;
            this.upd_btn.Text = "Updation";
            this.upd_btn.UseVisualStyleBackColor = true;
            this.upd_btn.Click += new System.EventHandler(this.upd_btn_Click);
            // 
            // cur_label
            // 
            this.cur_label.AutoSize = true;
            this.cur_label.Location = new System.Drawing.Point(113, 264);
            this.cur_label.Name = "cur_label";
            this.cur_label.Size = new System.Drawing.Size(41, 13);
            this.cur_label.TabIndex = 9;
            this.cur_label.Text = "Current";
            // 
            // pre_label
            // 
            this.pre_label.AutoSize = true;
            this.pre_label.Location = new System.Drawing.Point(209, 264);
            this.pre_label.Name = "pre_label";
            this.pre_label.Size = new System.Drawing.Size(48, 13);
            this.pre_label.TabIndex = 10;
            this.pre_label.Text = "Previous";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 357);
            this.Controls.Add(this.pre_label);
            this.Controls.Add(this.cur_label);
            this.Controls.Add(this.upd_btn);
            this.Controls.Add(this.display_txt);
            this.Controls.Add(this.conv_button1);
            this.Controls.Add(this.to_comboBox2);
            this.Controls.Add(this.from_comboBox1);
            this.Controls.Add(this.amount_txt);
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
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.ComboBox from_comboBox1;
        private System.Windows.Forms.ComboBox to_comboBox2;
        private System.Windows.Forms.Button conv_button1;
        private System.Windows.Forms.Label display_txt;
        private System.Windows.Forms.Button upd_btn;
        private System.Windows.Forms.Label cur_label;
        private System.Windows.Forms.Label pre_label;
    }
}

