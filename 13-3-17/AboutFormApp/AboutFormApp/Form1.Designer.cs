namespace AboutFormApp
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
            this.evenCheckBox = new System.Windows.Forms.CheckBox();
            this.oddCheckBox = new System.Windows.Forms.CheckBox();
            this.btnCheckShow = new System.Windows.Forms.Button();
            this.evenRadioButton = new System.Windows.Forms.RadioButton();
            this.oddRadioButton = new System.Windows.Forms.RadioButton();
            this.btnRadioShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // evenCheckBox
            // 
            this.evenCheckBox.AutoSize = true;
            this.evenCheckBox.Location = new System.Drawing.Point(33, 13);
            this.evenCheckBox.Name = "evenCheckBox";
            this.evenCheckBox.Size = new System.Drawing.Size(51, 17);
            this.evenCheckBox.TabIndex = 0;
            this.evenCheckBox.Text = "Even";
            this.evenCheckBox.UseVisualStyleBackColor = true;
            // 
            // oddCheckBox
            // 
            this.oddCheckBox.AutoSize = true;
            this.oddCheckBox.Location = new System.Drawing.Point(33, 46);
            this.oddCheckBox.Name = "oddCheckBox";
            this.oddCheckBox.Size = new System.Drawing.Size(46, 17);
            this.oddCheckBox.TabIndex = 1;
            this.oddCheckBox.Text = "Odd";
            this.oddCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnCheckShow
            // 
            this.btnCheckShow.Location = new System.Drawing.Point(33, 94);
            this.btnCheckShow.Name = "btnCheckShow";
            this.btnCheckShow.Size = new System.Drawing.Size(75, 23);
            this.btnCheckShow.TabIndex = 2;
            this.btnCheckShow.Text = "Show";
            this.btnCheckShow.UseVisualStyleBackColor = true;
            this.btnCheckShow.Click += new System.EventHandler(this.btnCheckShow_Click);
            // 
            // evenRadioButton
            // 
            this.evenRadioButton.AutoSize = true;
            this.evenRadioButton.Checked = true;
            this.evenRadioButton.Location = new System.Drawing.Point(33, 150);
            this.evenRadioButton.Name = "evenRadioButton";
            this.evenRadioButton.Size = new System.Drawing.Size(50, 17);
            this.evenRadioButton.TabIndex = 3;
            this.evenRadioButton.TabStop = true;
            this.evenRadioButton.Text = "Even";
            this.evenRadioButton.UseVisualStyleBackColor = true;
            // 
            // oddRadioButton
            // 
            this.oddRadioButton.AutoSize = true;
            this.oddRadioButton.Location = new System.Drawing.Point(33, 186);
            this.oddRadioButton.Name = "oddRadioButton";
            this.oddRadioButton.Size = new System.Drawing.Size(45, 17);
            this.oddRadioButton.TabIndex = 4;
            this.oddRadioButton.TabStop = true;
            this.oddRadioButton.Text = "Odd";
            this.oddRadioButton.UseVisualStyleBackColor = true;
            // 
            // btnRadioShow
            // 
            this.btnRadioShow.Location = new System.Drawing.Point(33, 232);
            this.btnRadioShow.Name = "btnRadioShow";
            this.btnRadioShow.Size = new System.Drawing.Size(75, 23);
            this.btnRadioShow.TabIndex = 5;
            this.btnRadioShow.Text = "Show";
            this.btnRadioShow.UseVisualStyleBackColor = true;
            this.btnRadioShow.Click += new System.EventHandler(this.btnRadioShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 358);
            this.Controls.Add(this.btnRadioShow);
            this.Controls.Add(this.oddRadioButton);
            this.Controls.Add(this.evenRadioButton);
            this.Controls.Add(this.btnCheckShow);
            this.Controls.Add(this.oddCheckBox);
            this.Controls.Add(this.evenCheckBox);
            this.Name = "Form1";
            this.Text = "MyUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox evenCheckBox;
        private System.Windows.Forms.CheckBox oddCheckBox;
        private System.Windows.Forms.Button btnCheckShow;
        private System.Windows.Forms.RadioButton evenRadioButton;
        private System.Windows.Forms.RadioButton oddRadioButton;
        private System.Windows.Forms.Button btnRadioShow;
    }
}

