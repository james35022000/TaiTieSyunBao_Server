namespace TaiTieSyunBao_Server
{
    partial class AddGood_Form
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
            this.kindAdd_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picAdd_pictureBox = new System.Windows.Forms.PictureBox();
            this.infoAdd_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amountAdd_textBox = new System.Windows.Forms.TextBox();
            this.priceAdd_textBox = new System.Windows.Forms.TextBox();
            this.nameAdd_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imgurID_textBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // kindAdd_comboBox
            // 
            this.kindAdd_comboBox.FormattingEnabled = true;
            this.kindAdd_comboBox.Items.AddRange(new object[] {
            "FOOD",
            "DRINK",
            "SNACK",
            "OTHER"});
            this.kindAdd_comboBox.Location = new System.Drawing.Point(306, 38);
            this.kindAdd_comboBox.Name = "kindAdd_comboBox";
            this.kindAdd_comboBox.Size = new System.Drawing.Size(121, 20);
            this.kindAdd_comboBox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "介紹";
            // 
            // picAdd_pictureBox
            // 
            this.picAdd_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAdd_pictureBox.Location = new System.Drawing.Point(290, 120);
            this.picAdd_pictureBox.Name = "picAdd_pictureBox";
            this.picAdd_pictureBox.Size = new System.Drawing.Size(160, 120);
            this.picAdd_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd_pictureBox.TabIndex = 27;
            this.picAdd_pictureBox.TabStop = false;
            // 
            // infoAdd_textBox
            // 
            this.infoAdd_textBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.infoAdd_textBox.Location = new System.Drawing.Point(18, 144);
            this.infoAdd_textBox.Multiline = true;
            this.infoAdd_textBox.Name = "infoAdd_textBox";
            this.infoAdd_textBox.Size = new System.Drawing.Size(242, 116);
            this.infoAdd_textBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "種類";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "庫存";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "價格";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "品名";
            // 
            // amountAdd_textBox
            // 
            this.amountAdd_textBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.amountAdd_textBox.Location = new System.Drawing.Point(18, 91);
            this.amountAdd_textBox.Name = "amountAdd_textBox";
            this.amountAdd_textBox.Size = new System.Drawing.Size(75, 22);
            this.amountAdd_textBox.TabIndex = 19;
            // 
            // priceAdd_textBox
            // 
            this.priceAdd_textBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.priceAdd_textBox.Location = new System.Drawing.Point(121, 91);
            this.priceAdd_textBox.Name = "priceAdd_textBox";
            this.priceAdd_textBox.Size = new System.Drawing.Size(78, 22);
            this.priceAdd_textBox.TabIndex = 18;
            // 
            // nameAdd_textBox
            // 
            this.nameAdd_textBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.nameAdd_textBox.Location = new System.Drawing.Point(18, 36);
            this.nameAdd_textBox.Name = "nameAdd_textBox";
            this.nameAdd_textBox.Size = new System.Drawing.Size(200, 22);
            this.nameAdd_textBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 42);
            this.button1.TabIndex = 30;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "新增圖片";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imgurID_textBox
            // 
            this.imgurID_textBox.Location = new System.Drawing.Point(306, 256);
            this.imgurID_textBox.Name = "imgurID_textBox";
            this.imgurID_textBox.ReadOnly = true;
            this.imgurID_textBox.Size = new System.Drawing.Size(100, 22);
            this.imgurID_textBox.TabIndex = 32;
            this.imgurID_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "產生";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddGood_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 356);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.imgurID_textBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kindAdd_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picAdd_pictureBox);
            this.Controls.Add(this.infoAdd_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountAdd_textBox);
            this.Controls.Add(this.priceAdd_textBox);
            this.Controls.Add(this.nameAdd_textBox);
            this.Name = "AddGood_Form";
            this.Text = "AddGood_Form";
            ((System.ComponentModel.ISupportInitialize)(this.picAdd_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox kindAdd_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picAdd_pictureBox;
        private System.Windows.Forms.TextBox infoAdd_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountAdd_textBox;
        private System.Windows.Forms.TextBox priceAdd_textBox;
        private System.Windows.Forms.TextBox nameAdd_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox imgurID_textBox;
        private System.Windows.Forms.Button button3;
    }
}