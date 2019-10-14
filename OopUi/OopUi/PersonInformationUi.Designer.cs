namespace OopUi
{
    partial class PersonInformationUi
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
            this.saveButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.reverseNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(317, 41);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(317, 73);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 4;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // reverseNameTextBox
            // 
            this.reverseNameTextBox.Location = new System.Drawing.Point(105, 149);
            this.reverseNameTextBox.Name = "reverseNameTextBox";
            this.reverseNameTextBox.Size = new System.Drawing.Size(287, 20);
            this.reverseNameTextBox.TabIndex = 19;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(105, 117);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(287, 20);
            this.fullNameTextBox.TabIndex = 20;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(105, 73);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(105, 48);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.middleNameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(105, 19);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Reverse Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Middle Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "First Name";
            // 
            // PersonInformationUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 248);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.reverseNameTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonInformationUi";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.TextBox reverseNameTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

