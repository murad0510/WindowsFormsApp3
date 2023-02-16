namespace WindowsFormsApp3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.BirthDayDateTimePictute = new System.Windows.Forms.DateTimePicker();
            this.PhoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SurnameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.EmailMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserListBox = new System.Windows.Forms.ListBox();
            this.JsonFileEnter = new System.Windows.Forms.TextBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChangeBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.BirthDayDateTimePictute);
            this.groupBox1.Controls.Add(this.PhoneNumberMaskedTextBox);
            this.groupBox1.Controls.Add(this.SurnameMaskedTextBox);
            this.groupBox1.Controls.Add(this.EmailMaskedTextBox);
            this.groupBox1.Controls.Add(this.NameMaskedTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(595, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(416, 469);
            this.ChangeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(100, 28);
            this.ChangeBtn.TabIndex = 7;
            this.ChangeBtn.Text = "Change";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(416, 407);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 28);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // BirthDayDateTimePictute
            // 
            this.BirthDayDateTimePictute.Location = new System.Drawing.Point(304, 352);
            this.BirthDayDateTimePictute.Margin = new System.Windows.Forms.Padding(4);
            this.BirthDayDateTimePictute.Name = "BirthDayDateTimePictute";
            this.BirthDayDateTimePictute.Size = new System.Drawing.Size(265, 22);
            this.BirthDayDateTimePictute.TabIndex = 5;
            // 
            // PhoneNumberMaskedTextBox
            // 
            this.PhoneNumberMaskedTextBox.Location = new System.Drawing.Point(304, 279);
            this.PhoneNumberMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumberMaskedTextBox.Mask = "(+994) -00-000-00-00";
            this.PhoneNumberMaskedTextBox.Name = "PhoneNumberMaskedTextBox";
            this.PhoneNumberMaskedTextBox.Size = new System.Drawing.Size(160, 22);
            this.PhoneNumberMaskedTextBox.TabIndex = 4;
            // 
            // SurnameMaskedTextBox
            // 
            this.SurnameMaskedTextBox.BackColor = System.Drawing.Color.DimGray;
            this.SurnameMaskedTextBox.Location = new System.Drawing.Point(304, 139);
            this.SurnameMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SurnameMaskedTextBox.Name = "SurnameMaskedTextBox";
            this.SurnameMaskedTextBox.Size = new System.Drawing.Size(248, 22);
            this.SurnameMaskedTextBox.TabIndex = 2;
            // 
            // EmailMaskedTextBox
            // 
            this.EmailMaskedTextBox.BackColor = System.Drawing.Color.DimGray;
            this.EmailMaskedTextBox.Location = new System.Drawing.Point(304, 203);
            this.EmailMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailMaskedTextBox.Name = "EmailMaskedTextBox";
            this.EmailMaskedTextBox.Size = new System.Drawing.Size(248, 22);
            this.EmailMaskedTextBox.TabIndex = 3;
            // 
            // NameMaskedTextBox
            // 
            this.NameMaskedTextBox.BackColor = System.Drawing.Color.DimGray;
            this.NameMaskedTextBox.Location = new System.Drawing.Point(304, 74);
            this.NameMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameMaskedTextBox.Name = "NameMaskedTextBox";
            this.NameMaskedTextBox.Size = new System.Drawing.Size(248, 22);
            this.NameMaskedTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(31, 342);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birth date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // UserListBox
            // 
            this.UserListBox.BackColor = System.Drawing.Color.DimGray;
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.ItemHeight = 16;
            this.UserListBox.Location = new System.Drawing.Point(672, 46);
            this.UserListBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(353, 372);
            this.UserListBox.TabIndex = 1;
            this.UserListBox.SelectedIndexChanged += new System.EventHandler(this.UserListBox_SelectedIndexChanged);
            // 
            // JsonFileEnter
            // 
            this.JsonFileEnter.Location = new System.Drawing.Point(672, 442);
            this.JsonFileEnter.Margin = new System.Windows.Forms.Padding(4);
            this.JsonFileEnter.Multiline = true;
            this.JsonFileEnter.Name = "JsonFileEnter";
            this.JsonFileEnter.Size = new System.Drawing.Size(353, 38);
            this.JsonFileEnter.TabIndex = 8;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(672, 505);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(121, 28);
            this.LoadBtn.TabIndex = 9;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(908, 505);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 548);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.JsonFileEnter);
            this.Controls.Add(this.UserListBox);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DateTimePicker BirthDayDateTimePictute;
        private System.Windows.Forms.MaskedTextBox PhoneNumberMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox SurnameMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox EmailMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox NameMaskedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox UserListBox;
        private System.Windows.Forms.TextBox JsonFileEnter;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button button2;
    }
}

