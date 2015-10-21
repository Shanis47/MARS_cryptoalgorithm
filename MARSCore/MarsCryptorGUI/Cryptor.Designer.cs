namespace MarsCryptorGUI
{
    partial class Cryptor
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
            this.InputFileNameTB = new System.Windows.Forms.TextBox();
            this.OutputFileNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenInputButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenOutputButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SetKeyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputFileNameTB
            // 
            this.InputFileNameTB.Location = new System.Drawing.Point(12, 57);
            this.InputFileNameTB.Name = "InputFileNameTB";
            this.InputFileNameTB.ReadOnly = true;
            this.InputFileNameTB.Size = new System.Drawing.Size(266, 20);
            this.InputFileNameTB.TabIndex = 0;
            // 
            // OutputFileNameTB
            // 
            this.OutputFileNameTB.Location = new System.Drawing.Point(12, 96);
            this.OutputFileNameTB.Name = "OutputFileNameTB";
            this.OutputFileNameTB.ReadOnly = true;
            this.OutputFileNameTB.Size = new System.Drawing.Size(266, 20);
            this.OutputFileNameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output file:";
            // 
            // OpenInputButton
            // 
            this.OpenInputButton.Location = new System.Drawing.Point(284, 55);
            this.OpenInputButton.Name = "OpenInputButton";
            this.OpenInputButton.Size = new System.Drawing.Size(55, 23);
            this.OpenInputButton.TabIndex = 4;
            this.OpenInputButton.Text = "Open";
            this.OpenInputButton.UseVisualStyleBackColor = true;
            this.OpenInputButton.Click += new System.EventHandler(this.OpenInputButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenOutputButton
            // 
            this.OpenOutputButton.Location = new System.Drawing.Point(284, 94);
            this.OpenOutputButton.Name = "OpenOutputButton";
            this.OpenOutputButton.Size = new System.Drawing.Size(55, 23);
            this.OpenOutputButton.TabIndex = 5;
            this.OpenOutputButton.Text = "Open";
            this.OpenOutputButton.UseVisualStyleBackColor = true;
            this.OpenOutputButton.Click += new System.EventHandler(this.OpenOutputButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Enabled = false;
            this.EncryptButton.Location = new System.Drawing.Point(12, 122);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(55, 23);
            this.EncryptButton.TabIndex = 6;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Enabled = false;
            this.DecryptButton.Location = new System.Drawing.Point(73, 122);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(55, 23);
            this.DecryptButton.TabIndex = 7;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(12, 19);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(266, 20);
            this.PasswordBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // SetKeyButton
            // 
            this.SetKeyButton.Location = new System.Drawing.Point(284, 16);
            this.SetKeyButton.Name = "SetKeyButton";
            this.SetKeyButton.Size = new System.Drawing.Size(55, 23);
            this.SetKeyButton.TabIndex = 10;
            this.SetKeyButton.Text = "Set key";
            this.SetKeyButton.UseVisualStyleBackColor = true;
            this.SetKeyButton.Click += new System.EventHandler(this.SetKeyButton_Click);
            // 
            // Cryptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 148);
            this.Controls.Add(this.SetKeyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.OpenOutputButton);
            this.Controls.Add(this.OpenInputButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputFileNameTB);
            this.Controls.Add(this.InputFileNameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Cryptor";
            this.Text = "Cryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputFileNameTB;
        private System.Windows.Forms.TextBox OutputFileNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenInputButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button OpenOutputButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SetKeyButton;
    }
}

