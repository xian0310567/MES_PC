namespace _2018848063_ERP
{
    partial class POP_EmpAdd
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Depart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Grade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_WForm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Phone_num = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_Join_Date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(106, 31);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(150, 21);
            this.txt_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "부서";
            // 
            // txt_Depart
            // 
            this.txt_Depart.Location = new System.Drawing.Point(106, 75);
            this.txt_Depart.Name = "txt_Depart";
            this.txt_Depart.ReadOnly = true;
            this.txt_Depart.Size = new System.Drawing.Size(150, 21);
            this.txt_Depart.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "직급";
            // 
            // txt_Grade
            // 
            this.txt_Grade.Location = new System.Drawing.Point(106, 122);
            this.txt_Grade.Name = "txt_Grade";
            this.txt_Grade.ReadOnly = true;
            this.txt_Grade.Size = new System.Drawing.Size(150, 21);
            this.txt_Grade.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "고용형태";
            // 
            // txt_WForm
            // 
            this.txt_WForm.Location = new System.Drawing.Point(106, 169);
            this.txt_WForm.Name = "txt_WForm";
            this.txt_WForm.ReadOnly = true;
            this.txt_WForm.Size = new System.Drawing.Size(150, 21);
            this.txt_WForm.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "휴대폰";
            // 
            // txt_Phone_num
            // 
            this.txt_Phone_num.Location = new System.Drawing.Point(106, 218);
            this.txt_Phone_num.Name = "txt_Phone_num";
            this.txt_Phone_num.Size = new System.Drawing.Size(150, 21);
            this.txt_Phone_num.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "입사일";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 56);
            this.button1.TabIndex = 12;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 56);
            this.button2.TabIndex = 13;
            this.button2.Text = "초기화";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(256, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(256, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_Join_Date
            // 
            this.txt_Join_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Join_Date.Location = new System.Drawing.Point(103, 262);
            this.txt_Join_Date.Name = "txt_Join_Date";
            this.txt_Join_Date.Size = new System.Drawing.Size(153, 21);
            this.txt_Join_Date.TabIndex = 17;
            // 
            // POP_EmpAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 391);
            this.Controls.Add(this.txt_Join_Date);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Phone_num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_WForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Grade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Depart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Name);
            this.Name = "POP_EmpAdd";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Phone_num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.TextBox txt_Depart;
        public System.Windows.Forms.TextBox txt_Grade;
        public System.Windows.Forms.TextBox txt_WForm;
        private System.Windows.Forms.DateTimePicker txt_Join_Date;
    }
}