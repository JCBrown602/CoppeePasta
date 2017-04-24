namespace BatSite31
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelClip = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.buttonSet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.currentToonText = new System.Windows.Forms.Label();
            this.timeBtn = new System.Windows.Forms.Button();
            this.closeAppBtn = new System.Windows.Forms.Button();
            this.MXrecLabel = new System.Windows.Forms.Label();
            this.MXrecListBox = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Time (UTC):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelClip
            // 
            this.labelClip.AutoSize = true;
            this.labelClip.Location = new System.Drawing.Point(5, 141);
            this.labelClip.Name = "labelClip";
            this.labelClip.Size = new System.Drawing.Size(46, 13);
            this.labelClip.TabIndex = 3;
            this.labelClip.Text = "labelClip";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick_1);
            // 
            // buttonSet
            // 
            this.buttonSet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSet.Location = new System.Drawing.Point(597, 41);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 4;
            this.buttonSet.Text = "buttonSet";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "CHAR:";
            // 
            // currentToonText
            // 
            this.currentToonText.AutoSize = true;
            this.currentToonText.BackColor = System.Drawing.Color.Transparent;
            this.currentToonText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentToonText.ForeColor = System.Drawing.Color.White;
            this.currentToonText.Location = new System.Drawing.Point(149, 96);
            this.currentToonText.Name = "currentToonText";
            this.currentToonText.Size = new System.Drawing.Size(78, 20);
            this.currentToonText.TabIndex = 6;
            this.currentToonText.Text = "charText";
            // 
            // timeBtn
            // 
            this.timeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeBtn.Location = new System.Drawing.Point(597, 70);
            this.timeBtn.Name = "timeBtn";
            this.timeBtn.Size = new System.Drawing.Size(75, 23);
            this.timeBtn.TabIndex = 7;
            this.timeBtn.Text = "Time";
            this.timeBtn.UseVisualStyleBackColor = true;
            this.timeBtn.Click += new System.EventHandler(this.timeBtn_Click);
            // 
            // closeAppBtn
            // 
            this.closeAppBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeAppBtn.Location = new System.Drawing.Point(597, 12);
            this.closeAppBtn.Name = "closeAppBtn";
            this.closeAppBtn.Size = new System.Drawing.Size(75, 23);
            this.closeAppBtn.TabIndex = 8;
            this.closeAppBtn.Text = "Close";
            this.closeAppBtn.UseVisualStyleBackColor = true;
            this.closeAppBtn.Click += new System.EventHandler(this.closeAppBtn_Click);
            // 
            // MXrecLabel
            // 
            this.MXrecLabel.AutoSize = true;
            this.MXrecLabel.Location = new System.Drawing.Point(5, 204);
            this.MXrecLabel.Name = "MXrecLabel";
            this.MXrecLabel.Size = new System.Drawing.Size(85, 13);
            this.MXrecLabel.TabIndex = 9;
            this.MXrecLabel.Text = "MXrecLabelText";
            // 
            // MXrecListBox
            // 
            this.MXrecListBox.FormattingEnabled = true;
            this.MXrecListBox.Location = new System.Drawing.Point(6, 229);
            this.MXrecListBox.Name = "MXrecListBox";
            this.MXrecListBox.Size = new System.Drawing.Size(348, 368);
            this.MXrecListBox.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(361, 229);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(311, 368);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(679, 604);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.MXrecListBox);
            this.Controls.Add(this.MXrecLabel);
            this.Controls.Add(this.closeAppBtn);
            this.Controls.Add(this.timeBtn);
            this.Controls.Add(this.currentToonText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.labelClip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BatMon";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelClip;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentToonText;
        private System.Windows.Forms.Button timeBtn;
        private System.Windows.Forms.Button closeAppBtn;
        private System.Windows.Forms.Label MXrecLabel;
        private System.Windows.Forms.ListBox MXrecListBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

