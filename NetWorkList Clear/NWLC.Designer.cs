namespace NetWorkList_Clear
{
    partial class NWLC
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.profileList = new System.Windows.Forms.CheckedListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.del_btn1 = new System.Windows.Forms.Button();
            this.refresh_btn1 = new System.Windows.Forms.Button();
            this.SelectAll_btn1 = new System.Windows.Forms.Button();
            this.UnSelectAll_btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.signatureUnamedList = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.del_btn2 = new System.Windows.Forms.Button();
            this.refresh_btn2 = new System.Windows.Forms.Button();
            this.SelectAll_btn2 = new System.Windows.Forms.Button();
            this.UnSelectAll_btn2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileList
            // 
            this.profileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileList.FormattingEnabled = true;
            this.profileList.HorizontalScrollbar = true;
            this.profileList.Location = new System.Drawing.Point(3, 23);
            this.profileList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.profileList.Name = "profileList";
            this.profileList.Size = new System.Drawing.Size(360, 459);
            this.profileList.TabIndex = 1;
            this.profileList.SelectedIndexChanged += new System.EventHandler(this.profileList_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(931, 488);
            this.splitContainer1.SplitterDistance = 457;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 510F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 488);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.profileList, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(366, 482);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Profile";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.del_btn1);
            this.flowLayoutPanel1.Controls.Add(this.refresh_btn1);
            this.flowLayoutPanel1.Controls.Add(this.SelectAll_btn1);
            this.flowLayoutPanel1.Controls.Add(this.UnSelectAll_btn1);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(375, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(79, 482);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // del_btn1
            // 
            this.del_btn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.del_btn1.Font = new System.Drawing.Font("宋体", 7.5F);
            this.del_btn1.Location = new System.Drawing.Point(3, 3);
            this.del_btn1.Name = "del_btn1";
            this.del_btn1.Size = new System.Drawing.Size(75, 23);
            this.del_btn1.TabIndex = 2;
            this.del_btn1.Text = "Delete";
            this.del_btn1.UseVisualStyleBackColor = true;
            this.del_btn1.Click += new System.EventHandler(this.del_btn1_Click);
            // 
            // refresh_btn1
            // 
            this.refresh_btn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.refresh_btn1.Font = new System.Drawing.Font("宋体", 7.5F);
            this.refresh_btn1.Location = new System.Drawing.Point(3, 32);
            this.refresh_btn1.Name = "refresh_btn1";
            this.refresh_btn1.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn1.TabIndex = 3;
            this.refresh_btn1.Text = "Refresh";
            this.refresh_btn1.UseVisualStyleBackColor = true;
            this.refresh_btn1.Click += new System.EventHandler(this.refresh_btn1_Click);
            // 
            // SelectAll_btn1
            // 
            this.SelectAll_btn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.SelectAll_btn1.Font = new System.Drawing.Font("宋体", 7.5F);
            this.SelectAll_btn1.Location = new System.Drawing.Point(3, 61);
            this.SelectAll_btn1.Name = "SelectAll_btn1";
            this.SelectAll_btn1.Size = new System.Drawing.Size(75, 23);
            this.SelectAll_btn1.TabIndex = 5;
            this.SelectAll_btn1.Text = "Select All";
            this.SelectAll_btn1.UseVisualStyleBackColor = true;
            this.SelectAll_btn1.Click += new System.EventHandler(this.SelectAll_btn1_Click);
            // 
            // UnSelectAll_btn1
            // 
            this.UnSelectAll_btn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.UnSelectAll_btn1.Font = new System.Drawing.Font("宋体", 7.5F);
            this.UnSelectAll_btn1.Location = new System.Drawing.Point(3, 90);
            this.UnSelectAll_btn1.Name = "UnSelectAll_btn1";
            this.UnSelectAll_btn1.Size = new System.Drawing.Size(75, 23);
            this.UnSelectAll_btn1.TabIndex = 6;
            this.UnSelectAll_btn1.Text = "UnSelect All";
            this.UnSelectAll_btn1.UseVisualStyleBackColor = true;
            this.UnSelectAll_btn1.Click += new System.EventHandler(this.UnSelectAll_btn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Items";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(470, 488);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.signatureUnamedList, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(379, 482);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unsignaure Unamed";
            // 
            // signatureUnamedList
            // 
            this.signatureUnamedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signatureUnamedList.FormattingEnabled = true;
            this.signatureUnamedList.HorizontalScrollbar = true;
            this.signatureUnamedList.Location = new System.Drawing.Point(3, 23);
            this.signatureUnamedList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.signatureUnamedList.Name = "signatureUnamedList";
            this.signatureUnamedList.Size = new System.Drawing.Size(373, 459);
            this.signatureUnamedList.TabIndex = 4;
            this.signatureUnamedList.SelectedIndexChanged += new System.EventHandler(this.signatureUnamedList_SelectedIndexChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.del_btn2);
            this.flowLayoutPanel2.Controls.Add(this.refresh_btn2);
            this.flowLayoutPanel2.Controls.Add(this.SelectAll_btn2);
            this.flowLayoutPanel2.Controls.Add(this.UnSelectAll_btn2);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(388, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(79, 482);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // del_btn2
            // 
            this.del_btn2.Cursor = System.Windows.Forms.Cursors.Default;
            this.del_btn2.Font = new System.Drawing.Font("宋体", 7.5F);
            this.del_btn2.Location = new System.Drawing.Point(3, 3);
            this.del_btn2.Name = "del_btn2";
            this.del_btn2.Size = new System.Drawing.Size(75, 23);
            this.del_btn2.TabIndex = 2;
            this.del_btn2.Text = "Delete";
            this.del_btn2.UseVisualStyleBackColor = true;
            this.del_btn2.Click += new System.EventHandler(this.del_btn2_Click);
            // 
            // refresh_btn2
            // 
            this.refresh_btn2.Cursor = System.Windows.Forms.Cursors.Default;
            this.refresh_btn2.Font = new System.Drawing.Font("宋体", 7.5F);
            this.refresh_btn2.Location = new System.Drawing.Point(3, 32);
            this.refresh_btn2.Name = "refresh_btn2";
            this.refresh_btn2.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn2.TabIndex = 3;
            this.refresh_btn2.Text = "Refresh";
            this.refresh_btn2.UseVisualStyleBackColor = true;
            this.refresh_btn2.Click += new System.EventHandler(this.refresh_btn2_Click);
            // 
            // SelectAll_btn2
            // 
            this.SelectAll_btn2.Cursor = System.Windows.Forms.Cursors.Default;
            this.SelectAll_btn2.Font = new System.Drawing.Font("宋体", 7.5F);
            this.SelectAll_btn2.Location = new System.Drawing.Point(3, 61);
            this.SelectAll_btn2.Name = "SelectAll_btn2";
            this.SelectAll_btn2.Size = new System.Drawing.Size(75, 23);
            this.SelectAll_btn2.TabIndex = 6;
            this.SelectAll_btn2.Text = "Select All";
            this.SelectAll_btn2.UseVisualStyleBackColor = true;
            this.SelectAll_btn2.Click += new System.EventHandler(this.SelectAll_btn2_Click);
            // 
            // UnSelectAll_btn2
            // 
            this.UnSelectAll_btn2.Cursor = System.Windows.Forms.Cursors.Default;
            this.UnSelectAll_btn2.Font = new System.Drawing.Font("宋体", 7.5F);
            this.UnSelectAll_btn2.Location = new System.Drawing.Point(3, 90);
            this.UnSelectAll_btn2.Name = "UnSelectAll_btn2";
            this.UnSelectAll_btn2.Size = new System.Drawing.Size(75, 23);
            this.UnSelectAll_btn2.TabIndex = 7;
            this.UnSelectAll_btn2.Text = "UnSelect All";
            this.UnSelectAll_btn2.UseVisualStyleBackColor = true;
            this.UnSelectAll_btn2.Click += new System.EventHandler(this.UnSelectAll_btn2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Items";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(931, 573);
            this.splitContainer2.SplitterDistance = 81;
            this.splitContainer2.TabIndex = 3;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.textBox2);
            this.splitContainer3.Size = new System.Drawing.Size(931, 81);
            this.splitContainer3.SplitterDistance = 457;
            this.splitContainer3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(457, 81);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Profile Info";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(470, 81);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Unsignaure Unamed Info";
            // 
            // NWLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 573);
            this.Controls.Add(this.splitContainer2);
            this.Name = "NWLC";
            this.Text = "NetWorkList Clear";
            this.Load += new System.EventHandler(this.NWLC_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox profileList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button del_btn1;
        private System.Windows.Forms.Button refresh_btn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button del_btn2;
        private System.Windows.Forms.Button refresh_btn2;
        private System.Windows.Forms.CheckedListBox signatureUnamedList;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SelectAll_btn1;
        private System.Windows.Forms.Button UnSelectAll_btn1;
        private System.Windows.Forms.Button SelectAll_btn2;
        private System.Windows.Forms.Button UnSelectAll_btn2;
    }
}

