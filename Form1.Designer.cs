namespace Lab11
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
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.fromGroupBox = new System.Windows.Forms.GroupBox();
            this.fromEnterLabel = new System.Windows.Forms.Label();
            this.toGroupBox = new System.Windows.Forms.GroupBox();
            this.toEnterLabel = new System.Windows.Forms.Label();
            this.fromGroupBox.SuspendLayout();
            this.toGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(34, 65);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(61, 25);
            this.fromLabel.TabIndex = 2;
            this.fromLabel.Text = "From";
            this.fromLabel.Click += new System.EventHandler(this.fromLabel_Click);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(20, 55);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(37, 25);
            this.toLabel.TabIndex = 3;
            this.toLabel.Text = "To";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(142, 59);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(100, 31);
            this.fromTextBox.TabIndex = 4;
            this.fromTextBox.TextChanged += new System.EventHandler(this.fromTextBox_TextChanged);
            this.fromTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fromTextBox_keyDown);
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(114, 55);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(100, 31);
            this.toTextBox.TabIndex = 5;
            this.toTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toTextBox_keyDown);
            // 
            // fromGroupBox
            // 
            this.fromGroupBox.Controls.Add(this.fromEnterLabel);
            this.fromGroupBox.Controls.Add(this.fromLabel);
            this.fromGroupBox.Controls.Add(this.fromTextBox);
            this.fromGroupBox.Location = new System.Drawing.Point(291, 38);
            this.fromGroupBox.Name = "fromGroupBox";
            this.fromGroupBox.Size = new System.Drawing.Size(296, 162);
            this.fromGroupBox.TabIndex = 6;
            this.fromGroupBox.TabStop = false;
            this.fromGroupBox.Text = "Beginning sine value";
            // 
            // fromEnterLabel
            // 
            this.fromEnterLabel.AutoSize = true;
            this.fromEnterLabel.Location = new System.Drawing.Point(39, 110);
            this.fromEnterLabel.Name = "fromEnterLabel";
            this.fromEnterLabel.Size = new System.Drawing.Size(187, 25);
            this.fromEnterLabel.TabIndex = 5;
            this.fromEnterLabel.Text = "Must press \"enter\"";
            // 
            // toGroupBox
            // 
            this.toGroupBox.Controls.Add(this.toEnterLabel);
            this.toGroupBox.Controls.Add(this.toLabel);
            this.toGroupBox.Controls.Add(this.toTextBox);
            this.toGroupBox.Location = new System.Drawing.Point(839, 48);
            this.toGroupBox.Name = "toGroupBox";
            this.toGroupBox.Size = new System.Drawing.Size(240, 152);
            this.toGroupBox.TabIndex = 7;
            this.toGroupBox.TabStop = false;
            this.toGroupBox.Text = "Ending sine value";
            // 
            // toEnterLabel
            // 
            this.toEnterLabel.AutoSize = true;
            this.toEnterLabel.Location = new System.Drawing.Point(25, 100);
            this.toEnterLabel.Name = "toEnterLabel";
            this.toEnterLabel.Size = new System.Drawing.Size(187, 25);
            this.toEnterLabel.TabIndex = 6;
            this.toEnterLabel.Text = "Must press \"enter\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2076, 975);
            this.Controls.Add(this.toGroupBox);
            this.Controls.Add(this.fromGroupBox);
            this.Name = "Form1";
            this.Text = "Lab 11";
            this.fromGroupBox.ResumeLayout(false);
            this.fromGroupBox.PerformLayout();
            this.toGroupBox.ResumeLayout(false);
            this.toGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.GroupBox fromGroupBox;
        private System.Windows.Forms.GroupBox toGroupBox;
        private System.Windows.Forms.Label fromEnterLabel;
        private System.Windows.Forms.Label toEnterLabel;
    }
}

