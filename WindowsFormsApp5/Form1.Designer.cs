namespace WindowsFormsApp5
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
            this.lisFName = new System.Windows.Forms.ListBox();
            this.lisLName = new System.Windows.Forms.ListBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLB1Count = new System.Windows.Forms.Label();
            this.lblLB2Count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.remBtn = new System.Windows.Forms.Button();
            this.remABtn = new System.Windows.Forms.Button();
            this.comFName = new System.Windows.Forms.ComboBox();
            this.comLName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.remACBtn = new System.Windows.Forms.Button();
            this.remCBtn = new System.Windows.Forms.Button();
            this.addCBtn = new System.Windows.Forms.Button();
            this.lblCFName = new System.Windows.Forms.Label();
            this.lblCLName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lisFName
            // 
            this.lisFName.FormattingEnabled = true;
            this.lisFName.ItemHeight = 16;
            this.lisFName.Location = new System.Drawing.Point(25, 157);
            this.lisFName.Name = "lisFName";
            this.lisFName.Size = new System.Drawing.Size(120, 84);
            this.lisFName.TabIndex = 0;
            this.lisFName.SelectedIndexChanged += new System.EventHandler(this.lisFName_SelectedIndexChanged);
            // 
            // lisLName
            // 
            this.lisLName.FormattingEnabled = true;
            this.lisLName.ItemHeight = 16;
            this.lisLName.Location = new System.Drawing.Point(252, 157);
            this.lisLName.Name = "lisLName";
            this.lisLName.Size = new System.Drawing.Size(120, 84);
            this.lisLName.TabIndex = 1;
            this.lisLName.SelectedIndexChanged += new System.EventHandler(this.lisLName_SelectedIndexChanged);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(154, 36);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(123, 22);
            this.txtFname.TabIndex = 2;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(154, 64);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(123, 22);
            this.txtLname.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(383, 58);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(115, 34);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // lblLB1Count
            // 
            this.lblLB1Count.AutoSize = true;
            this.lblLB1Count.Location = new System.Drawing.Point(151, 168);
            this.lblLB1Count.Name = "lblLB1Count";
            this.lblLB1Count.Size = new System.Drawing.Size(0, 17);
            this.lblLB1Count.TabIndex = 7;
            // 
            // lblLB2Count
            // 
            this.lblLB2Count.AutoSize = true;
            this.lblLB2Count.Location = new System.Drawing.Point(359, 168);
            this.lblLB2Count.Name = "lblLB2Count";
            this.lblLB2Count.Size = new System.Drawing.Size(0, 17);
            this.lblLB2Count.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name";
            // 
            // remBtn
            // 
            this.remBtn.Location = new System.Drawing.Point(504, 58);
            this.remBtn.Name = "remBtn";
            this.remBtn.Size = new System.Drawing.Size(109, 34);
            this.remBtn.TabIndex = 11;
            this.remBtn.Text = "remove";
            this.remBtn.UseVisualStyleBackColor = true;
            this.remBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // remABtn
            // 
            this.remABtn.Location = new System.Drawing.Point(619, 58);
            this.remABtn.Name = "remABtn";
            this.remABtn.Size = new System.Drawing.Size(112, 34);
            this.remABtn.TabIndex = 12;
            this.remABtn.Text = "remove All";
            this.remABtn.UseVisualStyleBackColor = true;
            this.remABtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comFName
            // 
            this.comFName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comFName.FormattingEnabled = true;
            this.comFName.Location = new System.Drawing.Point(575, 168);
            this.comFName.Name = "comFName";
            this.comFName.Size = new System.Drawing.Size(121, 24);
            this.comFName.TabIndex = 13;
            this.comFName.SelectedIndexChanged += new System.EventHandler(this.comFName_SelectedIndexChanged);
            // 
            // comLName
            // 
            this.comLName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comLName.FormattingEnabled = true;
            this.comLName.Location = new System.Drawing.Point(575, 198);
            this.comLName.Name = "comLName";
            this.comLName.Size = new System.Drawing.Size(121, 24);
            this.comLName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "First Name";
            // 
            // remACBtn
            // 
            this.remACBtn.Location = new System.Drawing.Point(619, 18);
            this.remACBtn.Name = "remACBtn";
            this.remACBtn.Size = new System.Drawing.Size(112, 34);
            this.remACBtn.TabIndex = 19;
            this.remACBtn.Text = "remove All com";
            this.remACBtn.UseVisualStyleBackColor = true;
            // 
            // remCBtn
            // 
            this.remCBtn.Location = new System.Drawing.Point(501, 18);
            this.remCBtn.Name = "remCBtn";
            this.remCBtn.Size = new System.Drawing.Size(112, 34);
            this.remCBtn.TabIndex = 18;
            this.remCBtn.Text = "remove com";
            this.remCBtn.UseVisualStyleBackColor = true;
            // 
            // addCBtn
            // 
            this.addCBtn.Location = new System.Drawing.Point(383, 18);
            this.addCBtn.Name = "addCBtn";
            this.addCBtn.Size = new System.Drawing.Size(112, 34);
            this.addCBtn.TabIndex = 17;
            this.addCBtn.Text = "add com";
            this.addCBtn.UseVisualStyleBackColor = true;
            this.addCBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblCFName
            // 
            this.lblCFName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblCFName.AutoSize = true;
            this.lblCFName.Location = new System.Drawing.Point(719, 168);
            this.lblCFName.Name = "lblCFName";
            this.lblCFName.Size = new System.Drawing.Size(0, 17);
            this.lblCFName.TabIndex = 20;
            // 
            // lblCLName
            // 
            this.lblCLName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblCLName.AutoSize = true;
            this.lblCLName.Location = new System.Drawing.Point(719, 199);
            this.lblCLName.Name = "lblCLName";
            this.lblCLName.Size = new System.Drawing.Size(0, 17);
            this.lblCLName.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 258);
            this.Controls.Add(this.lblCLName);
            this.Controls.Add(this.lblCFName);
            this.Controls.Add(this.remACBtn);
            this.Controls.Add(this.remCBtn);
            this.Controls.Add(this.addCBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comLName);
            this.Controls.Add(this.comFName);
            this.Controls.Add(this.remABtn);
            this.Controls.Add(this.remBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLB2Count);
            this.Controls.Add(this.lblLB1Count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lisLName);
            this.Controls.Add(this.lisFName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lisFName;
        private System.Windows.Forms.ListBox lisLName;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLB1Count;
        private System.Windows.Forms.Label lblLB2Count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button remBtn;
        private System.Windows.Forms.Button remABtn;
        private System.Windows.Forms.ComboBox comFName;
        private System.Windows.Forms.ComboBox comLName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button remACBtn;
        private System.Windows.Forms.Button remCBtn;
        private System.Windows.Forms.Button addCBtn;
        private System.Windows.Forms.Label lblCFName;
        private System.Windows.Forms.Label lblCLName;
    }
}

