namespace CustomerQueueManagementSystem
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
            this.enqueButton = new System.Windows.Forms.Button();
            this.complainEnqueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameEnqueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dequeButton = new System.Windows.Forms.Button();
            this.serialNoTextBox = new System.Windows.Forms.TextBox();
            this.nameDequeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.complainDequeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.showCustomerListView = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Complain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enqueButton);
            this.groupBox1.Controls.Add(this.complainEnqueTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameEnqueTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enque Customer";
            // 
            // enqueButton
            // 
            this.enqueButton.Location = new System.Drawing.Point(145, 119);
            this.enqueButton.Name = "enqueButton";
            this.enqueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueButton.TabIndex = 2;
            this.enqueButton.Text = "Enqueue";
            this.enqueButton.UseVisualStyleBackColor = true;
            this.enqueButton.Click += new System.EventHandler(this.enqueButton_Click);
            // 
            // complainEnqueTextBox
            // 
            this.complainEnqueTextBox.Location = new System.Drawing.Point(145, 79);
            this.complainEnqueTextBox.Name = "complainEnqueTextBox";
            this.complainEnqueTextBox.Size = new System.Drawing.Size(218, 20);
            this.complainEnqueTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Complain";
            // 
            // nameEnqueTextBox
            // 
            this.nameEnqueTextBox.Location = new System.Drawing.Point(145, 42);
            this.nameEnqueTextBox.Name = "nameEnqueTextBox";
            this.nameEnqueTextBox.Size = new System.Drawing.Size(218, 20);
            this.nameEnqueTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dequeButton);
            this.groupBox2.Controls.Add(this.serialNoTextBox);
            this.groupBox2.Controls.Add(this.nameDequeTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.complainDequeTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(387, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 157);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DeQueue Customer";
            // 
            // dequeButton
            // 
            this.dequeButton.Location = new System.Drawing.Point(226, 56);
            this.dequeButton.Name = "dequeButton";
            this.dequeButton.Size = new System.Drawing.Size(75, 23);
            this.dequeButton.TabIndex = 2;
            this.dequeButton.Text = "Dequeue";
            this.dequeButton.UseVisualStyleBackColor = true;
            this.dequeButton.Click += new System.EventHandler(this.dequeButton_Click);
            // 
            // serialNoTextBox
            // 
            this.serialNoTextBox.Location = new System.Drawing.Point(102, 56);
            this.serialNoTextBox.Name = "serialNoTextBox";
            this.serialNoTextBox.Size = new System.Drawing.Size(86, 20);
            this.serialNoTextBox.TabIndex = 1;
            // 
            // nameDequeTextBox
            // 
            this.nameDequeTextBox.Location = new System.Drawing.Point(102, 82);
            this.nameDequeTextBox.Name = "nameDequeTextBox";
            this.nameDequeTextBox.Size = new System.Drawing.Size(218, 20);
            this.nameDequeTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Serial No";
            // 
            // complainDequeTextBox
            // 
            this.complainDequeTextBox.Location = new System.Drawing.Point(102, 119);
            this.complainDequeTextBox.Name = "complainDequeTextBox";
            this.complainDequeTextBox.Size = new System.Drawing.Size(218, 20);
            this.complainDequeTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Complain";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.showCustomerListView);
            this.groupBox3.Location = new System.Drawing.Point(12, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(695, 222);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox1";
            // 
            // showCustomerListView
            // 
            this.showCustomerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Name,
            this.Complain});
            this.showCustomerListView.Location = new System.Drawing.Point(6, 41);
            this.showCustomerListView.Name = "showCustomerListView";
            this.showCustomerListView.Size = new System.Drawing.Size(660, 175);
            this.showCustomerListView.TabIndex = 0;
            this.showCustomerListView.UseCompatibleStateImageBehavior = false;
            this.showCustomerListView.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 191;
            // 
            // Complain
            // 
            this.Complain.Text = "Complain";
            this.Complain.Width = 324;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 489);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Text = "Customer Queue Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enqueButton;
        private System.Windows.Forms.TextBox complainEnqueTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameEnqueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dequeButton;
        private System.Windows.Forms.TextBox serialNoTextBox;
        private System.Windows.Forms.TextBox nameDequeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox complainDequeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView showCustomerListView;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Complain;
    }
}

