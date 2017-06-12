namespace TaiTieSyunBao_Server
{
    partial class DataBase_Form
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
            this.goods_listView = new System.Windows.Forms.ListView();
            this.nameUpdate_textBox = new System.Windows.Forms.TextBox();
            this.priceUpdate_textBox = new System.Windows.Forms.TextBox();
            this.amountUpdate_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idUpdate_textBox = new System.Windows.Forms.TextBox();
            this.infoUpdate_textBox = new System.Windows.Forms.TextBox();
            this.picUpdate_pictureBox = new System.Windows.Forms.PictureBox();
            this.picUpdate_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.kindUpdate_comboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.imgurID_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // goods_listView
            // 
            this.goods_listView.FullRowSelect = true;
            this.goods_listView.Location = new System.Drawing.Point(12, 54);
            this.goods_listView.Name = "goods_listView";
            this.goods_listView.Size = new System.Drawing.Size(523, 182);
            this.goods_listView.TabIndex = 0;
            this.goods_listView.UseCompatibleStateImageBehavior = false;
            this.goods_listView.View = System.Windows.Forms.View.Details;
            this.goods_listView.SelectedIndexChanged += new System.EventHandler(this.goods_listView_SelectedIndexChanged);
            // 
            // nameUpdate_textBox
            // 
            this.nameUpdate_textBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.nameUpdate_textBox.Location = new System.Drawing.Point(33, 323);
            this.nameUpdate_textBox.Name = "nameUpdate_textBox";
            this.nameUpdate_textBox.Size = new System.Drawing.Size(200, 22);
            this.nameUpdate_textBox.TabIndex = 1;
            // 
            // priceUpdate_textBox
            // 
            this.priceUpdate_textBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.priceUpdate_textBox.Location = new System.Drawing.Point(395, 323);
            this.priceUpdate_textBox.Name = "priceUpdate_textBox";
            this.priceUpdate_textBox.Size = new System.Drawing.Size(79, 22);
            this.priceUpdate_textBox.TabIndex = 2;
            // 
            // amountUpdate_textBox
            // 
            this.amountUpdate_textBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.amountUpdate_textBox.Location = new System.Drawing.Point(286, 323);
            this.amountUpdate_textBox.Name = "amountUpdate_textBox";
            this.amountUpdate_textBox.Size = new System.Drawing.Size(75, 22);
            this.amountUpdate_textBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "品名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "價格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "庫存";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "種類";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "更新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID";
            // 
            // idUpdate_textBox
            // 
            this.idUpdate_textBox.Enabled = false;
            this.idUpdate_textBox.Location = new System.Drawing.Point(33, 272);
            this.idUpdate_textBox.Name = "idUpdate_textBox";
            this.idUpdate_textBox.ReadOnly = true;
            this.idUpdate_textBox.Size = new System.Drawing.Size(100, 22);
            this.idUpdate_textBox.TabIndex = 11;
            this.idUpdate_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoUpdate_textBox
            // 
            this.infoUpdate_textBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.infoUpdate_textBox.Location = new System.Drawing.Point(286, 377);
            this.infoUpdate_textBox.Multiline = true;
            this.infoUpdate_textBox.Name = "infoUpdate_textBox";
            this.infoUpdate_textBox.Size = new System.Drawing.Size(220, 116);
            this.infoUpdate_textBox.TabIndex = 12;
            // 
            // picUpdate_pictureBox
            // 
            this.picUpdate_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUpdate_pictureBox.Location = new System.Drawing.Point(33, 363);
            this.picUpdate_pictureBox.Name = "picUpdate_pictureBox";
            this.picUpdate_pictureBox.Size = new System.Drawing.Size(160, 120);
            this.picUpdate_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpdate_pictureBox.TabIndex = 13;
            this.picUpdate_pictureBox.TabStop = false;
            // 
            // picUpdate_button
            // 
            this.picUpdate_button.Location = new System.Drawing.Point(180, 512);
            this.picUpdate_button.Name = "picUpdate_button";
            this.picUpdate_button.Size = new System.Drawing.Size(75, 23);
            this.picUpdate_button.TabIndex = 14;
            this.picUpdate_button.Text = "更改圖片";
            this.picUpdate_button.UseVisualStyleBackColor = true;
            this.picUpdate_button.Click += new System.EventHandler(this.picUpdate_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "介紹";
            // 
            // kindUpdate_comboBox
            // 
            this.kindUpdate_comboBox.FormattingEnabled = true;
            this.kindUpdate_comboBox.Items.AddRange(new object[] {
            "FOOD",
            "DRINK",
            "SNACK",
            "OTHER"});
            this.kindUpdate_comboBox.Location = new System.Drawing.Point(286, 274);
            this.kindUpdate_comboBox.Name = "kindUpdate_comboBox";
            this.kindUpdate_comboBox.Size = new System.Drawing.Size(121, 20);
            this.kindUpdate_comboBox.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "新增";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imgurID_textBox
            // 
            this.imgurID_textBox.Location = new System.Drawing.Point(45, 512);
            this.imgurID_textBox.Name = "imgurID_textBox";
            this.imgurID_textBox.ReadOnly = true;
            this.imgurID_textBox.Size = new System.Drawing.Size(100, 22);
            this.imgurID_textBox.TabIndex = 18;
            this.imgurID_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataBase_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 560);
            this.Controls.Add(this.imgurID_textBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kindUpdate_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picUpdate_button);
            this.Controls.Add(this.picUpdate_pictureBox);
            this.Controls.Add(this.infoUpdate_textBox);
            this.Controls.Add(this.idUpdate_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountUpdate_textBox);
            this.Controls.Add(this.priceUpdate_textBox);
            this.Controls.Add(this.nameUpdate_textBox);
            this.Controls.Add(this.goods_listView);
            this.Name = "DataBase_Form";
            this.Text = "DataBase";
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView goods_listView;
        private System.Windows.Forms.TextBox nameUpdate_textBox;
        private System.Windows.Forms.TextBox priceUpdate_textBox;
        private System.Windows.Forms.TextBox amountUpdate_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idUpdate_textBox;
        private System.Windows.Forms.TextBox infoUpdate_textBox;
        private System.Windows.Forms.PictureBox picUpdate_pictureBox;
        private System.Windows.Forms.Button picUpdate_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox kindUpdate_comboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox imgurID_textBox;
    }
}