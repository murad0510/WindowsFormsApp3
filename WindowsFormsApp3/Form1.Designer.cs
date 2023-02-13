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
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(312, 381);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeBtn.TabIndex = 10;
            this.ChangeBtn.Text = "Change";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(312, 331);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // BirthDayDateTimePictute
            // 
            this.BirthDayDateTimePictute.Location = new System.Drawing.Point(228, 286);
            this.BirthDayDateTimePictute.Name = "BirthDayDateTimePictute";
            this.BirthDayDateTimePictute.Size = new System.Drawing.Size(200, 20);
            this.BirthDayDateTimePictute.TabIndex = 8;
            // 
            // PhoneNumberMaskedTextBox
            // 
            this.PhoneNumberMaskedTextBox.Location = new System.Drawing.Point(228, 227);
            this.PhoneNumberMaskedTextBox.Mask = "(+994) -00-000-00-00";
            this.PhoneNumberMaskedTextBox.Name = "PhoneNumberMaskedTextBox";
            this.PhoneNumberMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.PhoneNumberMaskedTextBox.TabIndex = 6;
            // 
            // SurnameMaskedTextBox
            // 
            this.SurnameMaskedTextBox.Location = new System.Drawing.Point(228, 113);
            this.SurnameMaskedTextBox.Name = "SurnameMaskedTextBox";
            this.SurnameMaskedTextBox.Size = new System.Drawing.Size(187, 20);
            this.SurnameMaskedTextBox.TabIndex = 5;
            // 
            // EmailMaskedTextBox
            // 
            this.EmailMaskedTextBox.Location = new System.Drawing.Point(228, 165);
            this.EmailMaskedTextBox.Name = "EmailMaskedTextBox";
            this.EmailMaskedTextBox.Size = new System.Drawing.Size(187, 20);
            this.EmailMaskedTextBox.TabIndex = 5;
            // 
            // NameMaskedTextBox
            // 
            this.NameMaskedTextBox.Location = new System.Drawing.Point(228, 60);
            this.NameMaskedTextBox.Name = "NameMaskedTextBox";
            this.NameMaskedTextBox.Size = new System.Drawing.Size(187, 20);
            this.NameMaskedTextBox.TabIndex = 5;
            this.NameMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.NameMaskedTextBox_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birth date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // UserListBox
            // 
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.Location = new System.Drawing.Point(504, 37);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(266, 303);
            this.UserListBox.TabIndex = 1;
            this.UserListBox.SelectedIndexChanged += new System.EventHandler(this.UserListBox_SelectedIndexChanged);
            // 
            // JsonFileEnter
            // 
            this.JsonFileEnter.Location = new System.Drawing.Point(504, 359);
            this.JsonFileEnter.Multiline = true;
            this.JsonFileEnter.Name = "JsonFileEnter";
            this.JsonFileEnter.Size = new System.Drawing.Size(266, 32);
            this.JsonFileEnter.TabIndex = 2;
            this.JsonFileEnter.Text = "\\";
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(504, 410);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(91, 23);
            this.LoadBtn.TabIndex = 3;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 445);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.JsonFileEnter);
            this.Controls.Add(this.UserListBox);
            this.Controls.Add(this.groupBox1);
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

