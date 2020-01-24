namespace Currency
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
            this.OriginalCur = new System.Windows.Forms.TextBox();
            this.ConvertedCur = new System.Windows.Forms.TextBox();
            this.currencyfrom = new System.Windows.Forms.ComboBox();
            this.currencyto = new System.Windows.Forms.ComboBox();
            this.text_currencyfrom = new System.Windows.Forms.Label();
            this.text_currencyto = new System.Windows.Forms.Label();
            this.convertbut = new System.Windows.Forms.Button();
            this.discount = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.discountText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OriginalCur
            // 
            this.OriginalCur.Location = new System.Drawing.Point(12, 56);
            this.OriginalCur.Name = "OriginalCur";
            this.OriginalCur.Size = new System.Drawing.Size(142, 20);
            this.OriginalCur.TabIndex = 0;
            this.OriginalCur.Text = "0";
            this.OriginalCur.TextChanged += new System.EventHandler(this.OriginalCur_TextChanged);
            // 
            // ConvertedCur
            // 
            this.ConvertedCur.Location = new System.Drawing.Point(182, 56);
            this.ConvertedCur.Name = "ConvertedCur";
            this.ConvertedCur.Size = new System.Drawing.Size(158, 20);
            this.ConvertedCur.TabIndex = 1;
            this.ConvertedCur.TextChanged += new System.EventHandler(this.DestiCur_TextChanged);
            // 
            // currencyfrom
            // 
            this.currencyfrom.FormattingEnabled = true;
            this.currencyfrom.Location = new System.Drawing.Point(12, 25);
            this.currencyfrom.Name = "currencyfrom";
            this.currencyfrom.Size = new System.Drawing.Size(142, 21);
            this.currencyfrom.TabIndex = 2;
            this.currencyfrom.Text = "Select original currency";
            this.currencyfrom.SelectedIndexChanged += new System.EventHandler(this.currencyfrom_SelectedIndexChanged);
            // 
            // currencyto
            // 
            this.currencyto.FormattingEnabled = true;
            this.currencyto.Location = new System.Drawing.Point(182, 25);
            this.currencyto.Name = "currencyto";
            this.currencyto.Size = new System.Drawing.Size(158, 21);
            this.currencyto.TabIndex = 3;
            this.currencyto.Text = "Select destination currency";
            // 
            // text_currencyfrom
            // 
            this.text_currencyfrom.AutoSize = true;
            this.text_currencyfrom.Location = new System.Drawing.Point(12, 9);
            this.text_currencyfrom.Name = "text_currencyfrom";
            this.text_currencyfrom.Size = new System.Drawing.Size(87, 13);
            this.text_currencyfrom.TabIndex = 4;
            this.text_currencyfrom.Text = "Original Currency";
            // 
            // text_currencyto
            // 
            this.text_currencyto.AutoSize = true;
            this.text_currencyto.Location = new System.Drawing.Point(179, 9);
            this.text_currencyto.Name = "text_currencyto";
            this.text_currencyto.Size = new System.Drawing.Size(105, 13);
            this.text_currencyto.TabIndex = 5;
            this.text_currencyto.Text = "Destination Currency";
            // 
            // convertbut
            // 
            this.convertbut.Location = new System.Drawing.Point(130, 171);
            this.convertbut.Name = "convertbut";
            this.convertbut.Size = new System.Drawing.Size(75, 23);
            this.convertbut.TabIndex = 6;
            this.convertbut.Text = "Convert";
            this.convertbut.UseVisualStyleBackColor = true;
            this.convertbut.Click += new System.EventHandler(this.convertbut_Click);
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Location = new System.Drawing.Point(130, 104);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(47, 17);
            this.discount.TabIndex = 7;
            this.discount.TabStop = true;
            this.discount.Text = "Staff";
            this.discount.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(130, 127);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // discountText
            // 
            this.discountText.AutoSize = true;
            this.discountText.Location = new System.Drawing.Point(144, 88);
            this.discountText.Name = "discountText";
            this.discountText.Size = new System.Drawing.Size(52, 13);
            this.discountText.TabIndex = 9;
            this.discountText.Text = "Discount:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(348, 206);
            this.Controls.Add(this.discountText);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.convertbut);
            this.Controls.Add(this.text_currencyto);
            this.Controls.Add(this.text_currencyfrom);
            this.Controls.Add(this.currencyto);
            this.Controls.Add(this.currencyfrom);
            this.Controls.Add(this.ConvertedCur);
            this.Controls.Add(this.OriginalCur);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OriginalCur;
        private System.Windows.Forms.TextBox ConvertedCur;
        private System.Windows.Forms.ComboBox currencyfrom;
        private System.Windows.Forms.ComboBox currencyto;
        private System.Windows.Forms.Label text_currencyfrom;
        private System.Windows.Forms.Label text_currencyto;
        private System.Windows.Forms.Button convertbut;
        private System.Windows.Forms.RadioButton discount;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label discountText;
    }
}

