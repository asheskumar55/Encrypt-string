namespace Encrypt_string
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
            this.valuetextbox = new System.Windows.Forms.TextBox();
            this.encrypttextbox = new System.Windows.Forms.TextBox();
            this.decrypttextbox = new System.Windows.Forms.TextBox();
            this.encryptbutton = new System.Windows.Forms.Button();
            this.decryptbutton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Encrypt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Decrypt";
            // 
            // valuetextbox
            // 
            this.valuetextbox.Location = new System.Drawing.Point(148, 25);
            this.valuetextbox.Name = "valuetextbox";
            this.valuetextbox.Size = new System.Drawing.Size(100, 20);
            this.valuetextbox.TabIndex = 1;
            // 
            // encrypttextbox
            // 
            this.encrypttextbox.Location = new System.Drawing.Point(148, 74);
            this.encrypttextbox.Name = "encrypttextbox";
            this.encrypttextbox.Size = new System.Drawing.Size(100, 20);
            this.encrypttextbox.TabIndex = 1;
            // 
            // decrypttextbox
            // 
            this.decrypttextbox.Location = new System.Drawing.Point(148, 131);
            this.decrypttextbox.Name = "decrypttextbox";
            this.decrypttextbox.Size = new System.Drawing.Size(100, 20);
            this.decrypttextbox.TabIndex = 1;
            // 
            // encryptbutton
            // 
            this.encryptbutton.Location = new System.Drawing.Point(76, 188);
            this.encryptbutton.Name = "encryptbutton";
            this.encryptbutton.Size = new System.Drawing.Size(75, 23);
            this.encryptbutton.TabIndex = 2;
            this.encryptbutton.Text = "Encrypt";
            this.encryptbutton.UseVisualStyleBackColor = true;
            this.encryptbutton.Click += new System.EventHandler(this.encryptbutton_Click);
            // 
            // decryptbutton
            // 
            this.decryptbutton.Location = new System.Drawing.Point(224, 188);
            this.decryptbutton.Name = "decryptbutton";
            this.decryptbutton.Size = new System.Drawing.Size(75, 23);
            this.decryptbutton.TabIndex = 2;
            this.decryptbutton.Text = "Decrypt";
            this.decryptbutton.UseVisualStyleBackColor = true;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(344, 74);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.decryptbutton);
            this.Controls.Add(this.encryptbutton);
            this.Controls.Add(this.decrypttextbox);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.encrypttextbox);
            this.Controls.Add(this.valuetextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valuetextbox;
        private System.Windows.Forms.TextBox encrypttextbox;
        private System.Windows.Forms.TextBox decrypttextbox;
        private System.Windows.Forms.Button encryptbutton;
        private System.Windows.Forms.Button decryptbutton;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

