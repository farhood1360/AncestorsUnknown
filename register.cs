namespace AncestorsGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
	            // 
	            // textBox1
	            // 
                this.lengthTextBox.Location = new System.Drawing.Point(237, 67);
                this.lengthTextBox.Name = "textBox1";
                this.lengthTextBox.Size = new System.Drawing.Size(85, 20);
                this.lengthTextBox.TabIndex = 1;
		// 
		// textBox2
		// 
		this.lengthTextBox.Location = new System.Drawing.Point(237, 67);
		this.lengthTextBox.Name = "textBox2";
		this.lengthTextBox.Size = new System.Drawing.Size(85, 20);
		this.lengthTextBox.TabIndex = 3;
		// 
		// textBox3
		// 
		this.lengthTextBox.Location = new System.Drawing.Point(237, 67);
		this.lengthTextBox.Name = "textBox3";
		this.lengthTextBox.Size = new System.Drawing.Size(85, 20);
		this.lengthTextBox.TabIndex = 5;
	        // 
	        // label4
	        // 
            	this.label4.AutoSize = true;
            	this.label4.Location = new System.Drawing.Point(181, 209);
            	this.label4.Name = "label4";
            	this.label4.Size = new System.Drawing.Size(0, 13);
            	this.label4.TabIndex = 7;
	        // 
	        // Form1
	        // 
            	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            	this.ClientSize = new System.Drawing.Size(405, 299);
		this.Controls.Add(this.label1);
		this.Controls.Add(this.label2);
		this.Controls.Add(this.label3);
            	this.Controls.Add(this.label4);
            	this.Controls.Add(this.textBox1);
		this.Controls.Add(this.textBox2);
		this.Controls.Add(this.textBox3);
            	this.Controls.Add(this.button1);
            	this.Name = "Form1";
            	this.Text = "Registration Form";
            	this.ResumeLayout(false);
            	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
	private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
	private System.Windows.Forms.TextBox textBox2;
	private System.Windows.Forms.TextBox textBox3;
    }
}