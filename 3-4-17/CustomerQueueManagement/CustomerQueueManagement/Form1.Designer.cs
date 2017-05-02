namespace CustomerQueueManagement
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEnName = new System.Windows.Forms.Label();
            this.lblEnComplain = new System.Windows.Forms.Label();
            this.lblDeComplain = new System.Windows.Forms.Label();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.lblDeName = new System.Windows.Forms.Label();
            this.txtEnName = new System.Windows.Forms.TextBox();
            this.txtEnComplain = new System.Windows.Forms.TextBox();
            this.txtDeSerialNo = new System.Windows.Forms.TextBox();
            this.txtDeName = new System.Windows.Forms.TextBox();
            this.txtDeComplain = new System.Windows.Forms.TextBox();
            this.Dequeue = new System.Windows.Forms.Button();
            this.Enqueue = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstView = new System.Windows.Forms.ListView();
            this.lstSerialNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstComplain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Enqueue);
            this.groupBox1.Controls.Add(this.txtEnComplain);
            this.groupBox1.Controls.Add(this.txtEnName);
            this.groupBox1.Controls.Add(this.lblEnComplain);
            this.groupBox1.Controls.Add(this.lblEnName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enqueue Customer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dequeue);
            this.groupBox2.Controls.Add(this.txtDeComplain);
            this.groupBox2.Controls.Add(this.txtDeName);
            this.groupBox2.Controls.Add(this.txtDeSerialNo);
            this.groupBox2.Controls.Add(this.lblDeName);
            this.groupBox2.Controls.Add(this.lblSerialNo);
            this.groupBox2.Controls.Add(this.lblDeComplain);
            this.groupBox2.Location = new System.Drawing.Point(296, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dequeue Customer";
            // 
            // lblEnName
            // 
            this.lblEnName.AutoSize = true;
            this.lblEnName.Location = new System.Drawing.Point(6, 42);
            this.lblEnName.Name = "lblEnName";
            this.lblEnName.Size = new System.Drawing.Size(41, 13);
            this.lblEnName.TabIndex = 0;
            this.lblEnName.Text = "Name :";
            // 
            // lblEnComplain
            // 
            this.lblEnComplain.AutoSize = true;
            this.lblEnComplain.Location = new System.Drawing.Point(6, 76);
            this.lblEnComplain.Name = "lblEnComplain";
            this.lblEnComplain.Size = new System.Drawing.Size(56, 13);
            this.lblEnComplain.TabIndex = 1;
            this.lblEnComplain.Text = "Complain :";
            // 
            // lblDeComplain
            // 
            this.lblDeComplain.AutoSize = true;
            this.lblDeComplain.Location = new System.Drawing.Point(18, 132);
            this.lblDeComplain.Name = "lblDeComplain";
            this.lblDeComplain.Size = new System.Drawing.Size(56, 13);
            this.lblDeComplain.TabIndex = 2;
            this.lblDeComplain.Text = "Complain :";
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(18, 60);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(56, 13);
            this.lblSerialNo.TabIndex = 3;
            this.lblSerialNo.Text = "Serial No :";
            // 
            // lblDeName
            // 
            this.lblDeName.AutoSize = true;
            this.lblDeName.Location = new System.Drawing.Point(18, 94);
            this.lblDeName.Name = "lblDeName";
            this.lblDeName.Size = new System.Drawing.Size(41, 13);
            this.lblDeName.TabIndex = 2;
            this.lblDeName.Text = "Name :";
            // 
            // txtEnName
            // 
            this.txtEnName.Location = new System.Drawing.Point(89, 39);
            this.txtEnName.Name = "txtEnName";
            this.txtEnName.Size = new System.Drawing.Size(100, 20);
            this.txtEnName.TabIndex = 2;
            // 
            // txtEnComplain
            // 
            this.txtEnComplain.Location = new System.Drawing.Point(89, 71);
            this.txtEnComplain.Name = "txtEnComplain";
            this.txtEnComplain.Size = new System.Drawing.Size(171, 20);
            this.txtEnComplain.TabIndex = 3;
            // 
            // txtDeSerialNo
            // 
            this.txtDeSerialNo.Location = new System.Drawing.Point(87, 57);
            this.txtDeSerialNo.Name = "txtDeSerialNo";
            this.txtDeSerialNo.Size = new System.Drawing.Size(100, 20);
            this.txtDeSerialNo.TabIndex = 4;
            // 
            // txtDeName
            // 
            this.txtDeName.Location = new System.Drawing.Point(87, 87);
            this.txtDeName.Name = "txtDeName";
            this.txtDeName.Size = new System.Drawing.Size(149, 20);
            this.txtDeName.TabIndex = 5;
            // 
            // txtDeComplain
            // 
            this.txtDeComplain.Location = new System.Drawing.Point(87, 125);
            this.txtDeComplain.Name = "txtDeComplain";
            this.txtDeComplain.Size = new System.Drawing.Size(272, 20);
            this.txtDeComplain.TabIndex = 6;
            // 
            // Dequeue
            // 
            this.Dequeue.Location = new System.Drawing.Point(252, 60);
            this.Dequeue.Name = "Dequeue";
            this.Dequeue.Size = new System.Drawing.Size(93, 23);
            this.Dequeue.TabIndex = 7;
            this.Dequeue.Text = "Dequeue";
            this.Dequeue.UseVisualStyleBackColor = true;
            // 
            // Enqueue
            // 
            this.Enqueue.Location = new System.Drawing.Point(89, 114);
            this.Enqueue.Name = "Enqueue";
            this.Enqueue.Size = new System.Drawing.Size(75, 23);
            this.Enqueue.TabIndex = 4;
            this.Enqueue.Text = "Enqueue";
            this.Enqueue.UseVisualStyleBackColor = true;
            this.Enqueue.Click += new System.EventHandler(this.Enqueue_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstView);
            this.groupBox3.Location = new System.Drawing.Point(12, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 263);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wating Queue";
            // 
            // lstView
            // 
            this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstSerialNo,
            this.lstName,
            this.lstComplain});
            this.lstView.Location = new System.Drawing.Point(9, 20);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(646, 237);
            this.lstView.TabIndex = 0;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            // 
            // lstSerialNo
            // 
            this.lstSerialNo.Text = "Serial No";
            this.lstSerialNo.Width = 86;
            // 
            // lstName
            // 
            this.lstName.Text = "Name";
            this.lstName.Width = 136;
            // 
            // lstComplain
            // 
            this.lstComplain.Text = "Complain";
            this.lstComplain.Width = 356;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 502);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Customer Queue Managment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Enqueue;
        private System.Windows.Forms.TextBox txtEnComplain;
        private System.Windows.Forms.TextBox txtEnName;
        private System.Windows.Forms.Label lblEnComplain;
        private System.Windows.Forms.Label lblEnName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Dequeue;
        private System.Windows.Forms.TextBox txtDeComplain;
        private System.Windows.Forms.TextBox txtDeName;
        private System.Windows.Forms.TextBox txtDeSerialNo;
        private System.Windows.Forms.Label lblDeName;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.Label lblDeComplain;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.ColumnHeader lstSerialNo;
        private System.Windows.Forms.ColumnHeader lstName;
        private System.Windows.Forms.ColumnHeader lstComplain;
    }
}

