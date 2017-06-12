namespace TaiTieSyunBao_Server
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trainNum_label = new System.Windows.Forms.Label();
            this.carNum_label = new System.Windows.Forms.Label();
            this.seatNum_label = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connect_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.order_listView = new System.Windows.Forms.ListView();
            this.good_listView = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.dataBaseToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // dataBaseToolStripMenuItem1
            // 
            this.dataBaseToolStripMenuItem1.Name = "dataBaseToolStripMenuItem1";
            this.dataBaseToolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.dataBaseToolStripMenuItem1.Text = "DataBase";
            this.dataBaseToolStripMenuItem1.Click += new System.EventHandler(this.dataBaseToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(322, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "車次";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(322, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "車號";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(322, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "座位";
            // 
            // trainNum_label
            // 
            this.trainNum_label.AutoSize = true;
            this.trainNum_label.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.trainNum_label.ForeColor = System.Drawing.Color.Red;
            this.trainNum_label.Location = new System.Drawing.Point(403, 118);
            this.trainNum_label.Name = "trainNum_label";
            this.trainNum_label.Size = new System.Drawing.Size(0, 24);
            this.trainNum_label.TabIndex = 6;
            // 
            // carNum_label
            // 
            this.carNum_label.AutoSize = true;
            this.carNum_label.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.carNum_label.ForeColor = System.Drawing.Color.Red;
            this.carNum_label.Location = new System.Drawing.Point(403, 162);
            this.carNum_label.Name = "carNum_label";
            this.carNum_label.Size = new System.Drawing.Size(0, 24);
            this.carNum_label.TabIndex = 7;
            // 
            // seatNum_label
            // 
            this.seatNum_label.AutoSize = true;
            this.seatNum_label.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.seatNum_label.ForeColor = System.Drawing.Color.Red;
            this.seatNum_label.Location = new System.Drawing.Point(403, 206);
            this.seatNum_label.Name = "seatNum_label";
            this.seatNum_label.Size = new System.Drawing.Size(0, 24);
            this.seatNum_label.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connect_toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(560, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connect_toolStripStatusLabel
            // 
            this.connect_toolStripStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.connect_toolStripStatusLabel.Name = "connect_toolStripStatusLabel";
            this.connect_toolStripStatusLabel.Size = new System.Drawing.Size(69, 17);
            this.connect_toolStripStatusLabel.Text = "Disconnect";
            // 
            // order_listView
            // 
            this.order_listView.FullRowSelect = true;
            this.order_listView.Location = new System.Drawing.Point(24, 99);
            this.order_listView.Name = "order_listView";
            this.order_listView.Size = new System.Drawing.Size(268, 278);
            this.order_listView.TabIndex = 12;
            this.order_listView.UseCompatibleStateImageBehavior = false;
            this.order_listView.View = System.Windows.Forms.View.Details;
            this.order_listView.SelectedIndexChanged += new System.EventHandler(this.order_listView_SelectedIndexChanged);
            // 
            // good_listView
            // 
            this.good_listView.FullRowSelect = true;
            this.good_listView.Location = new System.Drawing.Point(326, 250);
            this.good_listView.Name = "good_listView";
            this.good_listView.Size = new System.Drawing.Size(222, 127);
            this.good_listView.TabIndex = 13;
            this.good_listView.UseCompatibleStateImageBehavior = false;
            this.good_listView.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 420);
            this.Controls.Add(this.good_listView);
            this.Controls.Add(this.order_listView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.seatNum_label);
            this.Controls.Add(this.carNum_label);
            this.Controls.Add(this.trainNum_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TaiTieSyunBao Server";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label trainNum_label;
        private System.Windows.Forms.Label carNum_label;
        private System.Windows.Forms.Label seatNum_label;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connect_toolStripStatusLabel;
        private System.Windows.Forms.ListView order_listView;
        private System.Windows.Forms.ListView good_listView;
    }
}