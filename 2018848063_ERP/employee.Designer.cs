namespace _2018848063_ERP
{
    partial class Employee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sch_Depart = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sch_Name = new System.Windows.Forms.TextBox();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.Btn_Regi = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.table_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 605);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.Sch_Depart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Sch_Name);
            this.groupBox1.Controls.Add(this.Btn_Print);
            this.groupBox1.Controls.Add(this.Btn_Regi);
            this.groupBox1.Controls.Add(this.Btn_Delete);
            this.groupBox1.Controls.Add(this.Btn_Search);
            this.groupBox1.Location = new System.Drawing.Point(0, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Sch_Depart
            // 
            this.Sch_Depart.FormattingEnabled = true;
            this.Sch_Depart.Items.AddRange(new object[] {
            "",
            "개발파트",
            "영업팀",
            "생산관리",
            "가공팀",
            "조립반",
            "해외자재파트",
            "판금A",
            "판금B"});
            this.Sch_Depart.Location = new System.Drawing.Point(266, 26);
            this.Sch_Depart.Name = "Sch_Depart";
            this.Sch_Depart.Size = new System.Drawing.Size(121, 20);
            this.Sch_Depart.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "부서";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "이름";
            // 
            // Sch_Name
            // 
            this.Sch_Name.Location = new System.Drawing.Point(85, 26);
            this.Sch_Name.Name = "Sch_Name";
            this.Sch_Name.Size = new System.Drawing.Size(100, 21);
            this.Sch_Name.TabIndex = 4;
            // 
            // Btn_Print
            // 
            this.Btn_Print.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Print.Location = new System.Drawing.Point(993, 9);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(58, 53);
            this.Btn_Print.TabIndex = 2;
            this.Btn_Print.Text = "인쇄";
            this.Btn_Print.UseVisualStyleBackColor = true;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // Btn_Regi
            // 
            this.Btn_Regi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Regi.Location = new System.Drawing.Point(865, 9);
            this.Btn_Regi.Name = "Btn_Regi";
            this.Btn_Regi.Size = new System.Drawing.Size(58, 53);
            this.Btn_Regi.TabIndex = 1;
            this.Btn_Regi.Text = "등록";
            this.Btn_Regi.UseVisualStyleBackColor = true;
            this.Btn_Regi.Click += new System.EventHandler(this.Btn_Regi_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Delete.Location = new System.Drawing.Point(929, 9);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(58, 53);
            this.Btn_Delete.TabIndex = 3;
            this.Btn_Delete.Text = "삭제";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Search
            // 
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Search.Location = new System.Drawing.Point(801, 9);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(58, 53);
            this.Btn_Search.TabIndex = 0;
            this.Btn_Search.Text = "조회";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.table_Check});
            this.dataGridView1.Location = new System.Drawing.Point(0, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 546);
            this.dataGridView1.TabIndex = 1;
            // 
            // table_Check
            // 
            this.table_Check.Frozen = true;
            this.table_Check.HeaderText = " ";
            this.table_Check.Name = "table_Check";
            this.table_Check.Width = 15;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 605);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Employee";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Print;
        private System.Windows.Forms.Button Btn_Regi;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.ComboBox Sch_Depart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Sch_Name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn table_Check;
    }
}