namespace Auto_Certificate_Sender
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.@__formMover = new System.Windows.Forms.Panel();
            this.@__closeBtn = new System.Windows.Forms.Label();
            this.@__minimizeBtn = new System.Windows.Forms.Label();
            this.@__titleLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.autoSendEmailCb = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this._statusLbl = new System.Windows.Forms.Label();
            this.includeAttachmentCb = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subjectTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.messageTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // __formMover
            // 
            this.@__formMover.BackColor = System.Drawing.Color.DodgerBlue;
            this.@__formMover.Dock = System.Windows.Forms.DockStyle.Top;
            this.@__formMover.Location = new System.Drawing.Point(0, 0);
            this.@__formMover.Name = "__formMover";
            this.@__formMover.Size = new System.Drawing.Size(586, 10);
            this.@__formMover.TabIndex = 1;
            // 
            // __closeBtn
            // 
            this.@__closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.@__closeBtn.ForeColor = System.Drawing.Color.Tomato;
            this.@__closeBtn.Location = new System.Drawing.Point(549, 11);
            this.@__closeBtn.Name = "__closeBtn";
            this.@__closeBtn.Size = new System.Drawing.Size(35, 35);
            this.@__closeBtn.TabIndex = 2;
            this.@__closeBtn.Text = "❌";
            this.@__closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.@__closeBtn.Click += new System.EventHandler(this.@__closeBtn_Click);
            // 
            // __minimizeBtn
            // 
            this.@__minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.@__minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.@__minimizeBtn.Location = new System.Drawing.Point(508, 11);
            this.@__minimizeBtn.Name = "__minimizeBtn";
            this.@__minimizeBtn.Size = new System.Drawing.Size(35, 35);
            this.@__minimizeBtn.TabIndex = 3;
            this.@__minimizeBtn.Text = "_";
            this.@__minimizeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.@__minimizeBtn.Click += new System.EventHandler(this.@__minimizeBtn_Click);
            // 
            // __titleLbl
            // 
            this.@__titleLbl.AutoSize = true;
            this.@__titleLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.@__titleLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.@__titleLbl.Location = new System.Drawing.Point(36, 22);
            this.@__titleLbl.Name = "__titleLbl";
            this.@__titleLbl.Size = new System.Drawing.Size(310, 24);
            this.@__titleLbl.TabIndex = 4;
            this.@__titleLbl.Text = "Certificate generator by devil";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(37, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data source _____________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(511, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Config _________________________________________________________________";
            // 
            // autoSendEmailCb
            // 
            this.autoSendEmailCb.AutoSize = true;
            this.autoSendEmailCb.Checked = true;
            this.autoSendEmailCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoSendEmailCb.Location = new System.Drawing.Point(43, 109);
            this.autoSendEmailCb.Name = "autoSendEmailCb";
            this.autoSendEmailCb.Size = new System.Drawing.Size(137, 21);
            this.autoSendEmailCb.TabIndex = 9;
            this.autoSendEmailCb.Text = "Auto send emails";
            this.autoSendEmailCb.UseVisualStyleBackColor = true;
            this.autoSendEmailCb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(37, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Source file";
            // 
            // emailInput
            // 
            this.emailInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.emailInput.Location = new System.Drawing.Point(124, 382);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(423, 23);
            this.emailInput.TabIndex = 11;
            this.emailInput.Text = "Students.txt";
            // 
            // generateBtn
            // 
            this.generateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.generateBtn.Location = new System.Drawing.Point(432, 438);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(116, 34);
            this.generateBtn.TabIndex = 13;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // _statusLbl
            // 
            this._statusLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._statusLbl.AutoSize = true;
            this._statusLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this._statusLbl.ForeColor = System.Drawing.Color.Yellow;
            this._statusLbl.Location = new System.Drawing.Point(40, 447);
            this._statusLbl.Name = "_statusLbl";
            this._statusLbl.Size = new System.Drawing.Size(31, 17);
            this._statusLbl.TabIndex = 14;
            this._statusLbl.Text = "Idle";
            this._statusLbl.TextChanged += new System.EventHandler(this._statusLbl_TextChanged);
            // 
            // includeAttachmentCb
            // 
            this.includeAttachmentCb.AutoSize = true;
            this.includeAttachmentCb.Checked = true;
            this.includeAttachmentCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeAttachmentCb.Location = new System.Drawing.Point(239, 109);
            this.includeAttachmentCb.Name = "includeAttachmentCb";
            this.includeAttachmentCb.Size = new System.Drawing.Size(156, 21);
            this.includeAttachmentCb.TabIndex = 15;
            this.includeAttachmentCb.Text = "Include Attachment";
            this.includeAttachmentCb.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(38, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Subject";
            // 
            // subjectTb
            // 
            this.subjectTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.subjectTb.Location = new System.Drawing.Point(124, 146);
            this.subjectTb.Name = "subjectTb";
            this.subjectTb.Size = new System.Drawing.Size(424, 23);
            this.subjectTb.TabIndex = 16;
            this.subjectTb.Text = "Certificate of Participation - Coders\' Club";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(38, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Message";
            // 
            // messageTb
            // 
            this.messageTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.messageTb.Location = new System.Drawing.Point(124, 185);
            this.messageTb.Multiline = true;
            this.messageTb.Name = "messageTb";
            this.messageTb.Size = new System.Drawing.Size(424, 142);
            this.messageTb.TabIndex = 18;
            this.messageTb.Text = resources.GetString("messageTb.Text");
            // 
            // MainUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(586, 505);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.messageTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subjectTb);
            this.Controls.Add(this.includeAttachmentCb);
            this.Controls.Add(this._statusLbl);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.autoSendEmailCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.@__titleLbl);
            this.Controls.Add(this.@__minimizeBtn);
            this.Controls.Add(this.@__closeBtn);
            this.Controls.Add(this.@__formMover);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Text = "Coders\' Club - Certificate generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel __formMover;
        private System.Windows.Forms.Label __closeBtn;
        private System.Windows.Forms.Label __minimizeBtn;
        private System.Windows.Forms.Label __titleLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox autoSendEmailCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Label _statusLbl;
        private System.Windows.Forms.CheckBox includeAttachmentCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subjectTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox messageTb;
    }
}

