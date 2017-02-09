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
			this.btnSelect = new System.Windows.Forms.Button();
			this.grid = new System.Windows.Forms.DataGridView();
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
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(32, 59);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(127, 67);
			this.btnSelect.TabIndex = 0;
			this.btnSelect.Text = "选择CSV文件";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// grid
			// 
			this.grid.AllowUserToAddRows = false;
			this.grid.AllowUserToDeleteRows = false;
			this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.grid.Location = new System.Drawing.Point(0, 483);
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			this.grid.RowTemplate.Height = 27;
			this.grid.Size = new System.Drawing.Size(1187, 296);
			this.grid.TabIndex = 1;
			// 
			// lblColumns
			// 
			this.lblColumns.AutoSize = true;
			this.lblColumns.Location = new System.Drawing.Point(197, 59);
			this.lblColumns.Name = "lblColumns";
			this.lblColumns.Size = new System.Drawing.Size(67, 15);
			this.lblColumns.TabIndex = 3;
			this.lblColumns.Text = "选择列：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(470, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "选择过滤规则：";
			// 
			// cb
			// 
			this.cb.FormattingEnabled = true;
			this.cb.Location = new System.Drawing.Point(595, 55);
			this.cb.Name = "cb";
			this.cb.Size = new System.Drawing.Size(169, 23);
			this.cb.TabIndex = 5;
			this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
			// 
			// txtCondition
			// 
			this.txtCondition.Location = new System.Drawing.Point(881, 53);
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
			this.btnSave.Location = new System.Drawing.Point(523, 434);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(189, 34);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "保存为新CSV文件";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// listView
			// 
			this.listView.CheckBoxes = true;
			this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView.Location = new System.Drawing.Point(200, 85);
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
			this.groupBox1.Location = new System.Drawing.Point(473, 95);
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
			this.groupBox2.Location = new System.Drawing.Point(473, 172);
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
			this.groupBox3.Location = new System.Drawing.Point(473, 245);
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
			this.groupBox4.Location = new System.Drawing.Point(473, 329);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(685, 64);
			this.groupBox4.TabIndex = 33;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "操作4";
			// 
			// CSVEditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1187, 779);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.listView);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtCondition);
			this.Controls.Add(this.cb);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblColumns);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.btnSelect);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CSVEditorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CSV批量修改";
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.DataGridView grid;
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
	}
}

