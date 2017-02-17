namespace CSVEditor
{
	partial class CSVEditorForm
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
			this.btnSelectCSV = new System.Windows.Forms.Button();
			this.gridCSV = new System.Windows.Forms.DataGridView();
			this.lblColumns = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cb = new System.Windows.Forms.ComboBox();
			this.txtCondition = new System.Windows.Forms.TextBox();
			this.textBoxAfter = new System.Windows.Forms.TextBox();
			this.btnBulkUpdate = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.listView = new System.Windows.Forms.ListView();
			this.btnReplace = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtOld = new System.Windows.Forms.TextBox();
			this.txtNew = new System.Windows.Forms.TextBox();
			this.btnTail = new System.Windows.Forms.Button();
			this.btnHead = new System.Windows.Forms.Button();
			this.txtTail = new System.Windows.Forms.TextBox();
			this.txtHead = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnSelectExcel = new System.Windows.Forms.Button();
			this.btnUpdateByExcel = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.gridExcel = new System.Windows.Forms.DataGridView();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.gridOld = new System.Windows.Forms.DataGridView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.gridCSV)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridExcel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridOld)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSelectCSV
			// 
			this.btnSelectCSV.Location = new System.Drawing.Point(601, 12);
			this.btnSelectCSV.Name = "btnSelectCSV";
			this.btnSelectCSV.Size = new System.Drawing.Size(189, 34);
			this.btnSelectCSV.TabIndex = 0;
			this.btnSelectCSV.Text = "选择CSV文件";
			this.btnSelectCSV.UseVisualStyleBackColor = true;
			this.btnSelectCSV.Click += new System.EventHandler(this.btnSelectCSV_Click);
			// 
			// gridCSV
			// 
			this.gridCSV.AllowUserToAddRows = false;
			this.gridCSV.AllowUserToDeleteRows = false;
			this.gridCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCSV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridCSV.Location = new System.Drawing.Point(0, 0);
			this.gridCSV.Name = "gridCSV";
			this.gridCSV.ReadOnly = true;
			this.gridCSV.RowTemplate.Height = 27;
			this.gridCSV.Size = new System.Drawing.Size(701, 278);
			this.gridCSV.TabIndex = 1;
			// 
			// lblColumns
			// 
			this.lblColumns.AutoSize = true;
			this.lblColumns.Location = new System.Drawing.Point(28, 43);
			this.lblColumns.Name = "lblColumns";
			this.lblColumns.Size = new System.Drawing.Size(67, 15);
			this.lblColumns.TabIndex = 3;
			this.lblColumns.Text = "选择列：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(301, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "选择过滤规则：";
			// 
			// cb
			// 
			this.cb.FormattingEnabled = true;
			this.cb.Location = new System.Drawing.Point(426, 39);
			this.cb.Name = "cb";
			this.cb.Size = new System.Drawing.Size(169, 23);
			this.cb.TabIndex = 5;
			this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
			// 
			// txtCondition
			// 
			this.txtCondition.Location = new System.Drawing.Point(712, 37);
			this.txtCondition.Name = "txtCondition";
			this.txtCondition.Size = new System.Drawing.Size(169, 25);
			this.txtCondition.TabIndex = 6;
			this.txtCondition.Visible = false;
			// 
			// textBoxAfter
			// 
			this.textBoxAfter.Location = new System.Drawing.Point(155, 28);
			this.textBoxAfter.Name = "textBoxAfter";
			this.textBoxAfter.Size = new System.Drawing.Size(169, 25);
			this.textBoxAfter.TabIndex = 7;
			// 
			// btnBulkUpdate
			// 
			this.btnBulkUpdate.Location = new System.Drawing.Point(578, 21);
			this.btnBulkUpdate.Name = "btnBulkUpdate";
			this.btnBulkUpdate.Size = new System.Drawing.Size(75, 34);
			this.btnBulkUpdate.TabIndex = 8;
			this.btnBulkUpdate.Text = "确定";
			this.btnBulkUpdate.UseVisualStyleBackColor = true;
			this.btnBulkUpdate.Click += new System.EventHandler(this.btnBulkUpdate_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(601, 482);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(189, 34);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "保存新CSV文件";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// listView
			// 
			this.listView.CheckBoxes = true;
			this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView.Location = new System.Drawing.Point(31, 69);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(233, 308);
			this.listView.TabIndex = 12;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			// 
			// btnReplace
			// 
			this.btnReplace.Location = new System.Drawing.Point(578, 21);
			this.btnReplace.Name = "btnReplace";
			this.btnReplace.Size = new System.Drawing.Size(75, 34);
			this.btnReplace.TabIndex = 13;
			this.btnReplace.Text = "确定";
			this.btnReplace.UseVisualStyleBackColor = true;
			this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 14;
			this.label2.Text = "将内容中";
			// 
			// txtOld
			// 
			this.txtOld.Location = new System.Drawing.Point(99, 28);
			this.txtOld.Name = "txtOld";
			this.txtOld.Size = new System.Drawing.Size(169, 25);
			this.txtOld.TabIndex = 15;
			// 
			// txtNew
			// 
			this.txtNew.Location = new System.Drawing.Point(353, 28);
			this.txtNew.Name = "txtNew";
			this.txtNew.Size = new System.Drawing.Size(169, 25);
			this.txtNew.TabIndex = 17;
			// 
			// btnTail
			// 
			this.btnTail.Location = new System.Drawing.Point(578, 23);
			this.btnTail.Name = "btnTail";
			this.btnTail.Size = new System.Drawing.Size(75, 34);
			this.btnTail.TabIndex = 20;
			this.btnTail.Text = "确定";
			this.btnTail.UseVisualStyleBackColor = true;
			this.btnTail.Click += new System.EventHandler(this.btnTail_Click);
			// 
			// btnHead
			// 
			this.btnHead.Location = new System.Drawing.Point(578, 21);
			this.btnHead.Name = "btnHead";
			this.btnHead.Size = new System.Drawing.Size(75, 34);
			this.btnHead.TabIndex = 21;
			this.btnHead.Text = "确定";
			this.btnHead.UseVisualStyleBackColor = true;
			this.btnHead.Click += new System.EventHandler(this.btnHead_Click);
			// 
			// txtTail
			// 
			this.txtTail.Location = new System.Drawing.Point(50, 30);
			this.txtTail.Name = "txtTail";
			this.txtTail.Size = new System.Drawing.Size(169, 25);
			this.txtTail.TabIndex = 22;
			// 
			// txtHead
			// 
			this.txtHead.Location = new System.Drawing.Point(54, 30);
			this.txtHead.Name = "txtHead";
			this.txtHead.Size = new System.Drawing.Size(169, 25);
			this.txtHead.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 15);
			this.label3.TabIndex = 24;
			this.label3.Text = "将";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(22, 15);
			this.label4.TabIndex = 25;
			this.label4.Text = "将";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(26, 34);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 15);
			this.label5.TabIndex = 26;
			this.label5.Text = "将内容全修改为";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(286, 31);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 15);
			this.label6.TabIndex = 27;
			this.label6.Text = "替换为";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(229, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(97, 15);
			this.label7.TabIndex = 28;
			this.label7.Text = "插入内容头部";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(227, 33);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(97, 15);
			this.label8.TabIndex = 29;
			this.label8.Text = "插入内容尾部";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btnBulkUpdate);
			this.groupBox1.Controls.Add(this.textBoxAfter);
			this.groupBox1.Location = new System.Drawing.Point(304, 79);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(685, 64);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "操作1";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.btnReplace);
			this.groupBox2.Controls.Add(this.txtOld);
			this.groupBox2.Controls.Add(this.txtNew);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(304, 156);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(685, 64);
			this.groupBox2.TabIndex = 31;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "操作2";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.btnHead);
			this.groupBox3.Controls.Add(this.txtHead);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Location = new System.Drawing.Point(304, 229);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(685, 64);
			this.groupBox3.TabIndex = 32;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "操作3";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.btnTail);
			this.groupBox4.Controls.Add(this.txtTail);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Location = new System.Drawing.Point(304, 313);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(685, 64);
			this.groupBox4.TabIndex = 33;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "操作4";
			// 
			// btnSelectExcel
			// 
			this.btnSelectExcel.Location = new System.Drawing.Point(166, 13);
			this.btnSelectExcel.Name = "btnSelectExcel";
			this.btnSelectExcel.Size = new System.Drawing.Size(189, 34);
			this.btnSelectExcel.TabIndex = 0;
			this.btnSelectExcel.Text = "选择Excel文件";
			this.btnSelectExcel.UseVisualStyleBackColor = true;
			this.btnSelectExcel.Click += new System.EventHandler(this.btnSelectExcel_Click);
			// 
			// btnUpdateByExcel
			// 
			this.btnUpdateByExcel.Location = new System.Drawing.Point(1081, 13);
			this.btnUpdateByExcel.Name = "btnUpdateByExcel";
			this.btnUpdateByExcel.Size = new System.Drawing.Size(189, 34);
			this.btnUpdateByExcel.TabIndex = 1;
			this.btnUpdateByExcel.Text = "确定";
			this.btnUpdateByExcel.UseVisualStyleBackColor = true;
			this.btnUpdateByExcel.Click += new System.EventHandler(this.btnUpdateByExcel_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(4, 52);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1406, 424);
			this.tabControl1.TabIndex = 36;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.groupBox4);
			this.tabPage1.Controls.Add(this.listView);
			this.tabPage1.Controls.Add(this.lblColumns);
			this.tabPage1.Controls.Add(this.txtCondition);
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.cb);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1398, 395);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "手动";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.gridExcel);
			this.tabPage2.Controls.Add(this.btnUpdateByExcel);
			this.tabPage2.Controls.Add(this.btnSelectExcel);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1398, 395);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Excel";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// gridExcel
			// 
			this.gridExcel.AllowUserToAddRows = false;
			this.gridExcel.AllowUserToDeleteRows = false;
			this.gridExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridExcel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridExcel.Location = new System.Drawing.Point(3, 53);
			this.gridExcel.Name = "gridExcel";
			this.gridExcel.ReadOnly = true;
			this.gridExcel.RowTemplate.Height = 27;
			this.gridExcel.Size = new System.Drawing.Size(1392, 339);
			this.gridExcel.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 545);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(54, 15);
			this.label9.TabIndex = 37;
			this.label9.Text = "新CSV:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(717, 545);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(54, 15);
			this.label10.TabIndex = 38;
			this.label10.Text = "旧CSV:";
			// 
			// gridOld
			// 
			this.gridOld.AllowUserToAddRows = false;
			this.gridOld.AllowUserToDeleteRows = false;
			this.gridOld.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridOld.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridOld.Location = new System.Drawing.Point(0, 0);
			this.gridOld.Name = "gridOld";
			this.gridOld.ReadOnly = true;
			this.gridOld.RowTemplate.Height = 27;
			this.gridOld.Size = new System.Drawing.Size(701, 278);
			this.gridOld.TabIndex = 39;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitContainer1.Location = new System.Drawing.Point(0, 563);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.gridCSV);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.gridOld);
			this.splitContainer1.Size = new System.Drawing.Size(1406, 278);
			this.splitContainer1.SplitterDistance = 701;
			this.splitContainer1.TabIndex = 40;
			// 
			// CSVEditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1406, 841);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btnSelectCSV);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CSVEditorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CSV批量修改";
			((System.ComponentModel.ISupportInitialize)(this.gridCSV)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridExcel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridOld)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnSelectCSV;
		private System.Windows.Forms.DataGridView gridCSV;
		private System.Windows.Forms.Label lblColumns;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cb;
		private System.Windows.Forms.TextBox txtCondition;
		private System.Windows.Forms.TextBox textBoxAfter;
		private System.Windows.Forms.Button btnBulkUpdate;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.Button btnReplace;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtOld;
		private System.Windows.Forms.TextBox txtNew;
		private System.Windows.Forms.Button btnTail;
		private System.Windows.Forms.Button btnHead;
		private System.Windows.Forms.TextBox txtTail;
		private System.Windows.Forms.TextBox txtHead;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnUpdateByExcel;
		private System.Windows.Forms.Button btnSelectExcel;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView gridExcel;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridView gridOld;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}

