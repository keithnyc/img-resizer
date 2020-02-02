namespace img_resizer
{
    partial class winMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winMain));
            this.btnResize = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dlgBrowseDir = new System.Windows.Forms.FolderBrowserDialog();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPerc = new System.Windows.Forms.TextBox();
            this.rdoPerc = new System.Windows.Forms.RadioButton();
            this.rdoAbs = new System.Windows.Forms.RadioButton();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkFlipV = new System.Windows.Forms.CheckBox();
            this.chkFlipH = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdoRot270 = new System.Windows.Forms.RadioButton();
            this.rdoRot180 = new System.Windows.Forms.RadioButton();
            this.rdoRot90 = new System.Windows.Forms.RadioButton();
            this.rdoRotNone = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pbOperation = new System.Windows.Forms.ProgressBar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(540, 605);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(87, 27);
            this.btnResize.TabIndex = 0;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(10, 37);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(597, 23);
            this.txtPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Image Directory:";
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.ItemHeight = 15;
            this.lbFiles.Location = new System.Drawing.Point(14, 214);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(256, 394);
            this.lbFiles.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Files to be resized:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "W:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPerc);
            this.groupBox2.Controls.Add(this.rdoPerc);
            this.groupBox2.Controls.Add(this.rdoAbs);
            this.groupBox2.Controls.Add(this.txtH);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtW);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(275, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 156);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resize Options";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "%:";
            // 
            // txtPerc
            // 
            this.txtPerc.Location = new System.Drawing.Point(45, 126);
            this.txtPerc.Name = "txtPerc";
            this.txtPerc.Size = new System.Drawing.Size(67, 23);
            this.txtPerc.TabIndex = 12;
            this.txtPerc.Text = "0.25";
            // 
            // rdoPerc
            // 
            this.rdoPerc.AutoSize = true;
            this.rdoPerc.Location = new System.Drawing.Point(7, 99);
            this.rdoPerc.Name = "rdoPerc";
            this.rdoPerc.Size = new System.Drawing.Size(84, 19);
            this.rdoPerc.TabIndex = 11;
            this.rdoPerc.Text = "Percentage";
            this.rdoPerc.UseVisualStyleBackColor = true;
            // 
            // rdoAbs
            // 
            this.rdoAbs.AutoSize = true;
            this.rdoAbs.Checked = true;
            this.rdoAbs.Location = new System.Drawing.Point(7, 31);
            this.rdoAbs.Name = "rdoAbs";
            this.rdoAbs.Size = new System.Drawing.Size(95, 19);
            this.rdoAbs.TabIndex = 10;
            this.rdoAbs.TabStop = true;
            this.rdoAbs.Text = "Absolute Size";
            this.rdoAbs.UseVisualStyleBackColor = true;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(159, 58);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(67, 23);
            this.txtH.TabIndex = 7;
            this.txtH.Text = "768";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "H:";
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(45, 58);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(67, 23);
            this.txtW.TabIndex = 5;
            this.txtW.Text = "1024";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkFlipV);
            this.groupBox3.Controls.Add(this.chkFlipH);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.rdoRot270);
            this.groupBox3.Controls.Add(this.rdoRot180);
            this.groupBox3.Controls.Add(this.rdoRot90);
            this.groupBox3.Controls.Add(this.rdoRotNone);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(275, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 140);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transformation Options";
            // 
            // chkFlipV
            // 
            this.chkFlipV.AutoSize = true;
            this.chkFlipV.Location = new System.Drawing.Point(159, 70);
            this.chkFlipV.Name = "chkFlipV";
            this.chkFlipV.Size = new System.Drawing.Size(73, 19);
            this.chkFlipV.TabIndex = 7;
            this.chkFlipV.Text = "Vertically";
            this.chkFlipV.UseVisualStyleBackColor = true;
            // 
            // chkFlipH
            // 
            this.chkFlipH.AutoSize = true;
            this.chkFlipH.Location = new System.Drawing.Point(159, 48);
            this.chkFlipH.Name = "chkFlipH";
            this.chkFlipH.Size = new System.Drawing.Size(90, 19);
            this.chkFlipH.TabIndex = 6;
            this.chkFlipH.Text = "Horizontally";
            this.chkFlipH.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(155, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Flip";
            // 
            // rdoRot270
            // 
            this.rdoRot270.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoRot270.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdoRot270.BackgroundImage")));
            this.rdoRot270.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdoRot270.Location = new System.Drawing.Point(21, 69);
            this.rdoRot270.Name = "rdoRot270";
            this.rdoRot270.Size = new System.Drawing.Size(27, 28);
            this.rdoRot270.TabIndex = 4;
            this.rdoRot270.UseVisualStyleBackColor = true;
            // 
            // rdoRot180
            // 
            this.rdoRot180.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoRot180.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdoRot180.BackgroundImage")));
            this.rdoRot180.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdoRot180.Location = new System.Drawing.Point(45, 96);
            this.rdoRot180.Name = "rdoRot180";
            this.rdoRot180.Size = new System.Drawing.Size(27, 28);
            this.rdoRot180.TabIndex = 3;
            this.rdoRot180.UseVisualStyleBackColor = true;
            // 
            // rdoRot90
            // 
            this.rdoRot90.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoRot90.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdoRot90.BackgroundImage")));
            this.rdoRot90.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdoRot90.Location = new System.Drawing.Point(71, 69);
            this.rdoRot90.Name = "rdoRot90";
            this.rdoRot90.Size = new System.Drawing.Size(27, 28);
            this.rdoRot90.TabIndex = 2;
            this.rdoRot90.UseVisualStyleBackColor = true;
            // 
            // rdoRotNone
            // 
            this.rdoRotNone.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoRotNone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdoRotNone.BackgroundImage")));
            this.rdoRotNone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdoRotNone.Checked = true;
            this.rdoRotNone.Location = new System.Drawing.Point(45, 42);
            this.rdoRotNone.Name = "rdoRotNone";
            this.rdoRotNone.Size = new System.Drawing.Size(27, 28);
            this.rdoRotNone.TabIndex = 1;
            this.rdoRotNone.TabStop = true;
            this.rdoRotNone.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rotation";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 605);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Preview";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPrefix);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(276, 517);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 82);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Misc Options";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(7, 43);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(219, 23);
            this.txtPrefix.TabIndex = 11;
            this.txtPrefix.Text = "resized_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "File Name:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(520, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(10, 109);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(597, 23);
            this.txtOutput.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Output Directory:";
            // 
            // pbOperation
            // 
            this.pbOperation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbOperation.Location = new System.Drawing.Point(0, 640);
            this.pbOperation.Name = "pbOperation";
            this.pbOperation.Size = new System.Drawing.Size(638, 23);
            this.pbOperation.TabIndex = 12;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(223, 196);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(46, 15);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Refresh";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // winMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 663);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pbOperation);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResize);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "winMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Resizer";
            this.Load += new System.EventHandler(this.winMain_Load);
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

        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog dlgBrowseDir;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPerc;
        private System.Windows.Forms.RadioButton rdoPerc;
        private System.Windows.Forms.RadioButton rdoAbs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoRotNone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdoRot270;
        private System.Windows.Forms.RadioButton rdoRot180;
        private System.Windows.Forms.RadioButton rdoRot90;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkFlipV;
        private System.Windows.Forms.CheckBox chkFlipH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar pbOperation;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

