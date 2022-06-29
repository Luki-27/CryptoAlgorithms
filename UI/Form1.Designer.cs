namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Uploadbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.encRdbtn = new System.Windows.Forms.RadioButton();
            this.decRdbtn = new System.Windows.Forms.RadioButton();
            this.fileLbl = new System.Windows.Forms.Label();
            this.AlgorithmslstBox = new System.Windows.Forms.ListBox();
            this.atxtBox = new System.Windows.Forms.TextBox();
            this.btextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.shiftTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.outFileLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.qTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.colKtextbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Uploadbtn
            // 
            this.Uploadbtn.Location = new System.Drawing.Point(57, 199);
            this.Uploadbtn.Name = "Uploadbtn";
            this.Uploadbtn.Size = new System.Drawing.Size(191, 46);
            this.Uploadbtn.TabIndex = 0;
            this.Uploadbtn.Text = "Upload Text File";
            this.Uploadbtn.UseVisualStyleBackColor = true;
            this.Uploadbtn.Click += new System.EventHandler(this.Uploadbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(59, 199);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(207, 46);
            this.Savebtn.TabIndex = 1;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // encRdbtn
            // 
            this.encRdbtn.AutoSize = true;
            this.encRdbtn.Location = new System.Drawing.Point(67, 157);
            this.encRdbtn.Name = "encRdbtn";
            this.encRdbtn.Size = new System.Drawing.Size(100, 41);
            this.encRdbtn.TabIndex = 2;
            this.encRdbtn.Text = "Encrypt";
            this.encRdbtn.UseVisualStyleBackColor = true;
            // 
            // decRdbtn
            // 
            this.decRdbtn.AutoSize = true;
            this.decRdbtn.Location = new System.Drawing.Point(67, 229);
            this.decRdbtn.Name = "decRdbtn";
            this.decRdbtn.Size = new System.Drawing.Size(101, 41);
            this.decRdbtn.TabIndex = 3;
            this.decRdbtn.Text = "Decrypt";
            this.decRdbtn.UseVisualStyleBackColor = true;
            // 
            // fileLbl
            // 
            this.fileLbl.AutoSize = true;
            this.fileLbl.Location = new System.Drawing.Point(6, 260);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(98, 37);
            this.fileLbl.TabIndex = 4;
            this.fileLbl.Text = "File Path : ";
            // 
            // AlgorithmslstBox
            // 
            this.AlgorithmslstBox.FormattingEnabled = true;
            this.AlgorithmslstBox.ItemHeight = 36;
            this.AlgorithmslstBox.Location = new System.Drawing.Point(19, 70);
            this.AlgorithmslstBox.Name = "AlgorithmslstBox";
            this.AlgorithmslstBox.Size = new System.Drawing.Size(226, 328);
            this.AlgorithmslstBox.TabIndex = 5;
            this.AlgorithmslstBox.SelectedIndexChanged += new System.EventHandler(this.AlgorithmslstBox_SelectedIndexChanged);
            // 
            // atxtBox
            // 
            this.atxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.atxtBox.Location = new System.Drawing.Point(123, 90);
            this.atxtBox.Name = "atxtBox";
            this.atxtBox.Size = new System.Drawing.Size(125, 37);
            this.atxtBox.TabIndex = 6;
            // 
            // btextBox
            // 
            this.btextBox.BackColor = System.Drawing.SystemColors.Control;
            this.btextBox.Location = new System.Drawing.Point(123, 139);
            this.btextBox.Name = "btextBox";
            this.btextBox.Size = new System.Drawing.Size(125, 37);
            this.btextBox.TabIndex = 7;
            // 
            // keyTextBox
            // 
            this.keyTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.keyTextBox.Location = new System.Drawing.Point(123, 186);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(125, 37);
            this.keyTextBox.TabIndex = 8;
            // 
            // shiftTextBox
            // 
            this.shiftTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.shiftTextBox.Location = new System.Drawing.Point(123, 236);
            this.shiftTextBox.Name = "shiftTextBox";
            this.shiftTextBox.Size = new System.Drawing.Size(125, 37);
            this.shiftTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "A = ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "B =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Key =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 37);
            this.label4.TabIndex = 13;
            this.label4.Text = "Shift =";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBtn.Location = new System.Drawing.Point(682, 558);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(178, 45);
            this.startBtn.TabIndex = 14;
            this.startBtn.Text = "Start Processing ";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "INT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "INT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 37);
            this.label7.TabIndex = 17;
            this.label7.Text = "INT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 37);
            this.label8.TabIndex = 18;
            this.label8.Text = "String";
            // 
            // outFileLbl
            // 
            this.outFileLbl.AutoSize = true;
            this.outFileLbl.Location = new System.Drawing.Point(13, 264);
            this.outFileLbl.Name = "outFileLbl";
            this.outFileLbl.Size = new System.Drawing.Size(98, 37);
            this.outFileLbl.TabIndex = 19;
            this.outFileLbl.Text = "File Path : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Uploadbtn);
            this.groupBox1.Controls.Add(this.fileLbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 456);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 34);
            this.label9.TabIndex = 5;
            this.label9.Text = "Select Your txt File :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.AlgorithmslstBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(323, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 456);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(7, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 34);
            this.label10.TabIndex = 6;
            this.label10.Text = "Select Your Algorithm:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.qTextBox);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.pTextBox);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.colKtextbox);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.atxtBox);
            this.groupBox3.Controls.Add(this.btextBox);
            this.groupBox3.Controls.Add(this.keyTextBox);
            this.groupBox3.Controls.Add(this.shiftTextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(601, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 456);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3";
            // 
            // qTextBox
            // 
            this.qTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.qTextBox.Location = new System.Drawing.Point(123, 403);
            this.qTextBox.Name = "qTextBox";
            this.qTextBox.Size = new System.Drawing.Size(125, 37);
            this.qTextBox.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 406);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 37);
            this.label18.TabIndex = 27;
            this.label18.Text = "Q = ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(254, 406);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 37);
            this.label19.TabIndex = 28;
            this.label19.Text = "INT";
            // 
            // pTextBox
            // 
            this.pTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.pTextBox.Location = new System.Drawing.Point(123, 339);
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(125, 37);
            this.pTextBox.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 342);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 37);
            this.label16.TabIndex = 24;
            this.label16.Text = "P = ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(254, 342);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 37);
            this.label17.TabIndex = 25;
            this.label17.Text = "INT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(254, 283);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 37);
            this.label15.TabIndex = 22;
            this.label15.Text = "String";
            // 
            // colKtextbox
            // 
            this.colKtextbox.BackColor = System.Drawing.SystemColors.Control;
            this.colKtextbox.Location = new System.Drawing.Point(122, 284);
            this.colKtextbox.Name = "colKtextbox";
            this.colKtextbox.Size = new System.Drawing.Size(125, 37);
            this.colKtextbox.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 37);
            this.label14.TabIndex = 21;
            this.label14.Text = "ColumnKey =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(265, 34);
            this.label11.TabIndex = 19;
            this.label11.Text = "Supply The remaining inputs:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.encRdbtn);
            this.groupBox4.Controls.Add(this.decRdbtn);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(945, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 456);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step 4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(12, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(221, 34);
            this.label12.TabIndex = 6;
            this.label12.Text = "Select The Process Type:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.Savebtn);
            this.groupBox5.Controls.Add(this.outFileLbl);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(1202, 65);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(309, 456);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Step 5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(7, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(298, 34);
            this.label13.TabIndex = 20;
            this.label13.Text = "Select The output file destination:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1523, 632);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Uploadbtn;
        private Button Savebtn;
        private RadioButton encRdbtn;
        private RadioButton decRdbtn;
        private Label fileLbl;
        private ListBox AlgorithmslstBox;
        private TextBox atxtBox;
        private TextBox btextBox;
        private TextBox keyTextBox;
        private TextBox shiftTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button startBtn;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label outFileLbl;
        private GroupBox groupBox1;
        private Label label9;
        private GroupBox groupBox2;
        private Label label10;
        private GroupBox groupBox3;
        private Label label11;
        private GroupBox groupBox4;
        private Label label12;
        private GroupBox groupBox5;
        private Label label13;
        private Label label15;
        private TextBox colKtextbox;
        private Label label14;
        private TextBox qTextBox;
        private Label label18;
        private Label label19;
        private TextBox pTextBox;
        private Label label16;
        private Label label17;
    }
}