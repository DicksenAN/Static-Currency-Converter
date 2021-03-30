
namespace Static_Currency_Converter
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
            this.from_combo_box = new System.Windows.Forms.ComboBox();
            this.to_combo_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.convert_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amount_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Converted_amount_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // from_combo_box
            // 
            this.from_combo_box.FormattingEnabled = true;
            this.from_combo_box.Items.AddRange(new object[] {
            "Indonesian Rupiah (IDR)",
            "United States Dollar (USD)",
            "Renminbi (RMB)",
            "Singapore Dollar (SGD)",
            "Japanese Yen (JPY)"});
            this.from_combo_box.Location = new System.Drawing.Point(86, 203);
            this.from_combo_box.Name = "from_combo_box";
            this.from_combo_box.Size = new System.Drawing.Size(225, 23);
            this.from_combo_box.TabIndex = 0;
            this.from_combo_box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // to_combo_box
            // 
            this.to_combo_box.FormattingEnabled = true;
            this.to_combo_box.Items.AddRange(new object[] {
            "Indonesian Rupiah (IDR)",
            "United States Dollar (USD)",
            "Renminbi (RMB)",
            "Singapore Dollar (SGD)",
            "Japanese Yen (JPY)"});
            this.to_combo_box.Location = new System.Drawing.Point(486, 203);
            this.to_combo_box.Name = "to_combo_box";
            this.to_combo_box.Size = new System.Drawing.Size(225, 23);
            this.to_combo_box.TabIndex = 1;
            this.to_combo_box.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(237, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "CURRENCY CONVERTER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // convert_button
            // 
            this.convert_button.Location = new System.Drawing.Point(345, 267);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(119, 48);
            this.convert_button.TabIndex = 3;
            this.convert_button.Text = "Convert";
            this.convert_button.UseVisualStyleBackColor = true;
            this.convert_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(86, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(486, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // amount_text
            // 
            this.amount_text.Location = new System.Drawing.Point(220, 379);
            this.amount_text.Name = "amount_text";
            this.amount_text.Size = new System.Drawing.Size(178, 23);
            this.amount_text.TabIndex = 6;
            this.amount_text.TextChanged += new System.EventHandler(this.amount_text_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Converted_amount_text
            // 
            this.Converted_amount_text.AutoSize = true;
            this.Converted_amount_text.Location = new System.Drawing.Point(66, 454);
            this.Converted_amount_text.Name = "Converted_amount_text";
            this.Converted_amount_text.Size = new System.Drawing.Size(115, 15);
            this.Converted_amount_text.TabIndex = 8;
            this.Converted_amount_text.Text = "Converted Amount :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.Converted_amount_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amount_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.to_combo_box);
            this.Controls.Add(this.from_combo_box);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter by Dicksen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox from_combo_box;
        private System.Windows.Forms.ComboBox to_combo_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button convert_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amount_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Converted_amount_text;
    }
}

