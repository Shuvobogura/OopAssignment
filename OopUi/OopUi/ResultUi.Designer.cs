namespace OopUi
{
    partial class ResultUi
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
            this.label1 = new System.Windows.Forms.Label();
            this.physicsTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chemistryTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mathTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Physics";
            // 
            // physicsTextBox
            // 
            this.physicsTextBox.Location = new System.Drawing.Point(97, 30);
            this.physicsTextBox.Name = "physicsTextBox";
            this.physicsTextBox.Size = new System.Drawing.Size(118, 20);
            this.physicsTextBox.TabIndex = 0;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(238, 144);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Out of 100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chemistry";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Out of 100";
            // 
            // chemistryTextBox
            // 
            this.chemistryTextBox.Location = new System.Drawing.Point(97, 66);
            this.chemistryTextBox.Name = "chemistryTextBox";
            this.chemistryTextBox.Size = new System.Drawing.Size(118, 20);
            this.chemistryTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Math";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Out of 100";
            // 
            // mathTextBox
            // 
            this.mathTextBox.Location = new System.Drawing.Point(97, 103);
            this.mathTextBox.Name = "mathTextBox";
            this.mathTextBox.Size = new System.Drawing.Size(118, 20);
            this.mathTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Average";
            // 
            // averageTextBox
            // 
            this.averageTextBox.Location = new System.Drawing.Point(108, 146);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.Size = new System.Drawing.Size(107, 20);
            this.averageTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Grade Letter";
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(108, 172);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(107, 20);
            this.gradeTextBox.TabIndex = 1;
            // 
            // ResultUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 221);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.mathTextBox);
            this.Controls.Add(this.chemistryTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.physicsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResultUi";
            this.Text = "ResultUi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox physicsTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox chemistryTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mathTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gradeTextBox;
    }
}