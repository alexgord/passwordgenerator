namespace passwordGenerator
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.nudLen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(106, 62);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(113, 41);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate random password";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(34, 203);
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(246, 20);
            this.txtPass.TabIndex = 1;
            // 
            // nudLen
            // 
            this.nudLen.Location = new System.Drawing.Point(99, 143);
            this.nudLen.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudLen.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudLen.Name = "nudLen";
            this.nudLen.Size = new System.Drawing.Size(120, 20);
            this.nudLen.TabIndex = 2;
            this.nudLen.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password Length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudLen);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Alex\'s Random Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.nudLen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.NumericUpDown nudLen;
        private System.Windows.Forms.Label label1;
    }
}

