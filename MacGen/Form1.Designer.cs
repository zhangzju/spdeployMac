namespace MacGen
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonGen = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.checkBoxPasswd = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.checkBoxUser = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.checkBoxPIN = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonDirectory = new System.Windows.Forms.Button();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBrowse);
            this.groupBox1.Controls.Add(this.textBoxFilePath);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(513, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MAC File Source";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(425, 12);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(84, 30);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(4, 19);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(418, 21);
            this.textBoxFilePath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonGen);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.checkBoxPasswd);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.checkBoxUser);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.checkBoxPIN);
            this.groupBox2.Location = new System.Drawing.Point(8, 139);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(405, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters Generate";
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(313, 19);
            this.buttonGen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(84, 54);
            this.buttonGen.TabIndex = 7;
            this.buttonGen.Text = "Generate Parameters";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxPasswd);
            this.groupBox5.Location = new System.Drawing.Point(205, 44);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(75, 35);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pass Len";
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.Location = new System.Drawing.Point(6, 13);
            this.textBoxPasswd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.Size = new System.Drawing.Size(51, 21);
            this.textBoxPasswd.TabIndex = 0;
            this.textBoxPasswd.Text = "16";
            // 
            // checkBoxPasswd
            // 
            this.checkBoxPasswd.AutoSize = true;
            this.checkBoxPasswd.Location = new System.Drawing.Point(196, 25);
            this.checkBoxPasswd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxPasswd.Name = "checkBoxPasswd";
            this.checkBoxPasswd.Size = new System.Drawing.Size(72, 16);
            this.checkBoxPasswd.TabIndex = 5;
            this.checkBoxPasswd.Text = "Password";
            this.checkBoxPasswd.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxUser);
            this.groupBox4.Location = new System.Drawing.Point(109, 44);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(74, 35);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "User Len";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(6, 13);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(51, 21);
            this.textBoxUser.TabIndex = 0;
            this.textBoxUser.Text = "8";
            // 
            // checkBoxUser
            // 
            this.checkBoxUser.AutoSize = true;
            this.checkBoxUser.Location = new System.Drawing.Point(100, 25);
            this.checkBoxUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxUser.Name = "checkBoxUser";
            this.checkBoxUser.Size = new System.Drawing.Size(48, 16);
            this.checkBoxUser.TabIndex = 3;
            this.checkBoxUser.Text = "User";
            this.checkBoxUser.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxPIN);
            this.groupBox3.Location = new System.Drawing.Point(13, 44);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(83, 35);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PIN Len";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Location = new System.Drawing.Point(6, 13);
            this.textBoxPIN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.Size = new System.Drawing.Size(51, 21);
            this.textBoxPIN.TabIndex = 0;
            this.textBoxPIN.Text = "16";
            // 
            // checkBoxPIN
            // 
            this.checkBoxPIN.AutoSize = true;
            this.checkBoxPIN.Location = new System.Drawing.Point(4, 25);
            this.checkBoxPIN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxPIN.Name = "checkBoxPIN";
            this.checkBoxPIN.Size = new System.Drawing.Size(66, 16);
            this.checkBoxPIN.TabIndex = 0;
            this.checkBoxPIN.Text = "MAC PIN";
            this.checkBoxPIN.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonDirectory);
            this.groupBox6.Controls.Add(this.textBoxDirectory);
            this.groupBox6.Location = new System.Drawing.Point(8, 73);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(513, 47);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "mac.bin Directory";
            // 
            // buttonDirectory
            // 
            this.buttonDirectory.Location = new System.Drawing.Point(425, 12);
            this.buttonDirectory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDirectory.Name = "buttonDirectory";
            this.buttonDirectory.Size = new System.Drawing.Size(84, 30);
            this.buttonDirectory.TabIndex = 1;
            this.buttonDirectory.Text = "Browse";
            this.buttonDirectory.UseVisualStyleBackColor = true;
            this.buttonDirectory.Click += new System.EventHandler(this.buttonDirectory_Click);
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Location = new System.Drawing.Point(4, 19);
            this.textBoxDirectory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(418, 21);
            this.textBoxDirectory.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 151);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate mac.bin";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 235);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "TP-Link Agile Config mac.bin generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxPasswd;
        private System.Windows.Forms.CheckBox checkBoxPasswd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.CheckBox checkBoxUser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.CheckBox checkBoxPIN;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonDirectory;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Button button1;
    }
}

