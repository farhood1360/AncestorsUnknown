namespace FriendBirthdayReminder
{
    partial class FriendRecordsForm
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
            reader.Close();
            file.Close();
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.showRecordsButton = new System.Windows.Forms.Button();
            this.monthLabel = new System.Windows.Forms.Label();
            this.monthBox = new System.Windows.Forms.TextBox();
            this.recordBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(51, 47);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(160, 13);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Click The button to view records";
            // 
            // showRecordsButton
            // 
            this.showRecordsButton.Location = new System.Drawing.Point(217, 42);
            this.showRecordsButton.Name = "showRecordsButton";
            this.showRecordsButton.Size = new System.Drawing.Size(94, 23);
            this.showRecordsButton.TabIndex = 1;
            this.showRecordsButton.Text = "View Records";
            this.showRecordsButton.UseVisualStyleBackColor = true;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(51, 102);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(92, 13);
            this.monthLabel.TabIndex = 2;
            this.monthLabel.Text = "Month Of Birthday";
            // 
            // monthBox
            // 
            this.monthBox.Location = new System.Drawing.Point(180, 99);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(100, 20);
            this.monthBox.TabIndex = 3;
            // 
            // recordBox
            // 
            this.recordBox.FormattingEnabled = true;
            this.recordBox.Location = new System.Drawing.Point(54, 140);
            this.recordBox.Name = "recordBox";
            this.recordBox.Size = new System.Drawing.Size(226, 121);
            this.recordBox.TabIndex = 4;
            // 
            // FriendRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 283);
            this.Controls.Add(this.recordBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.showRecordsButton);
            this.Controls.Add(this.inputLabel);
            this.Name = "FriendRecordsForm";
            this.Text = "Friend Records";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button showRecordsButton;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.TextBox monthBox;
        private System.Windows.Forms.ListBox recordBox;
    }
}

